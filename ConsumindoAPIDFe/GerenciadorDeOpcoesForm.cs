using Aplication.UseCase;
using Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ConsumindoAPIDFe
{
    public partial class GerenciadorDeOpcoesForm : Form
    {
        private readonly GetListaNfeUseCase _getListaNfeUseCase;
        private readonly GetEventosNfeUseCase _getEventosNfeUseCase;
        private readonly GetDanfeNfeUseCase _getDanfeNfeUseCase;
        private readonly IServiceProvider _serviceProvider;

        public Usuario Usuario { get; set; }       


        public GerenciadorDeOpcoesForm(GetListaNfeUseCase getListaNfeUseCase, GetEventosNfeUseCase getEventosNfeUseCase, GetDanfeNfeUseCase getDanfeNfeUseCase, IServiceProvider serviceProvider)
        {
            _getListaNfeUseCase = getListaNfeUseCase;
            _getEventosNfeUseCase = getEventosNfeUseCase;
            _getDanfeNfeUseCase = getDanfeNfeUseCase;
            _serviceProvider = serviceProvider;

            

            InitializeComponent();

            Load += new EventHandler(GerenciadorDeOpcoes_Load);
            FormClosing += GerenciadorDeOpcoes_FormClosing;
        }
        private void GerenciadorDeOpcoes_Load(object sender, EventArgs e)
        {
            if (Usuario?.Empresas != null && Usuario.Empresas.Any())
            {
                cmbEmpresa.DataSource = null;

                cmbEmpresa.DataSource = Usuario.Empresas;
                cmbEmpresa.DisplayMember = "Nome";
                cmbEmpresa.ValueMember = "Id";

                cmbEmpresa.SelectedIndex = 0;
                cmbTipo.SelectedIndex = 0;
                cmbEmissao.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Nenhuma empresa associada ao usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDetalhesNFe_Click(object sender, EventArgs e)
        {
            try
            {
                var menuDetalhesNfe = _serviceProvider.GetRequiredService<MenuDetalhesNfeForm>();
                menuDetalhesNfe.Usuario = Usuario;
                menuDetalhesNfe.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnListarNFe_Click(object sender, EventArgs e)
        {
            var parametros = new Parametros
            {
                Empresa = cmbEmpresa.SelectedValue?.ToString(),
                Tipo = cmbTipo.SelectedValue?.ToString(),
                Emissao = cmbEmissao.SelectedValue?.ToString(),
                DataInicial = dtpDataInicial.Value.ToString("yyyy-MM-dd"),
                DataFinal = dtpDataFinal.Value.ToString("yyyy-MM-dd"),
                Chave = txtChaveNfe.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Numero = txtNumero.Text.Trim(),
                CnpjCpf = txtCnpjCpf.Text.Trim(),
                RazaoSocial = txtRazaoSocial.Text.Trim()
            };

            try
            {
                var detalhes = await _getListaNfeUseCase.Execute(Usuario, parametros);

                if (detalhes != null)
                {
                    dgvNfe.DataSource = detalhes.Dados.listaNFe;
                    txtTotalNotas.Text = detalhes.Dados.resumo.qtRegistros.ToString();
                    txtVlrTotal.Text = detalhes.Dados.resumo.vlrTotal.ToString();
                    txtNotasCanceladas.Text = detalhes.Dados.resumo.qtRegistrosCanceladas.ToString();
                    txtVlrCancelado.Text = detalhes.Dados.resumo.vlrCanceladas.ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter detalhes da NF-e: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnEventosNFe_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtChaveNfe.Text))
                {
                    MessageBox.Show("O campo 'Chave NF-e' é obrigatório para essa rquisição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var parametros = new Parametros
                {
                    Chave = txtChaveNfe.Text,
                    Empresa = cmbEmpresa.SelectedValue?.ToString()
                };

                var eventosNfe = await _getEventosNfeUseCase.Execute(Usuario, parametros);
                if (eventosNfe != null)
                {
                    var formsEventosNfe = _serviceProvider.GetRequiredService<EventosNfeForm>();
                    formsEventosNfe.Eventos = eventosNfe.Dados;
                    formsEventosNfe.MostrarDetalhes();
                    formsEventosNfe.Show();


                    
                }
                else
                {
                    MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter os detalhes da NFe: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnPdfNFe_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtChaveNfe.Text))
                {
                    MessageBox.Show("O campo 'Chave NF-e' é obrigatório para essa rquisição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var parametros = new Parametros
                {
                    Empresa = cmbEmpresa.SelectedValue?.ToString(),
                    Chave = txtChaveNfe.Text
                };

                var caminhoDanfe = $@"C:\PdfTeste\DANFE_{txtChaveNfe.Text}.pdf";

                var response = await _getDanfeNfeUseCase.Execute(Usuario, parametros, caminhoDanfe);

                if (response.Sucesso)
                {
                    MessageBox.Show($"PDF da NF-e obtido com sucesso! Salvo em: {response.Dados}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Erro: {response.Mensagem}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter o PDF: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add(new KeyValuePair<string, string>("Todas", "T"));
            cmbTipo.Items.Add(new KeyValuePair<string, string>("Entradas", "E"));
            cmbTipo.Items.Add(new KeyValuePair<string, string>("Saídas", "S"));
            cmbTipo.DisplayMember = "Key";
            cmbTipo.ValueMember = "Value";

        }

        private void cmbEmissao_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEmissao.Items.Clear();
            cmbEmissao.Items.Add(new KeyValuePair<string, string>("Própria", "P"));
            cmbEmissao.Items.Add(new KeyValuePair<string, string>("Terceiro", "T"));
            cmbEmissao.DisplayMember = "Key";
            cmbEmissao.ValueMember = "Value";

        }

        private void dgvNfe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GerenciadorDeOpcoes_FormClosing(object sender, FormClosingEventArgs e)
        {

            var result = MessageBox.Show("Tem certeza de que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

