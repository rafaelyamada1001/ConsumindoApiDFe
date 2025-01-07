using Aplication.UseCase;
using Domain.Models;

namespace ConsumindoAPIDFe
{
    public partial class GerenciadorDeOpcoes : Form
    {
        private readonly GetListaNfeUseCase _getListaNfeUseCase;
        private readonly GetEventosNfeUseCase _getEventosNfeUseCase;
        private readonly GetNfeUseCase _getNfeUseCase;
        private readonly GetNfeByChaveUseCase _getNfeByChaveUseCase;

        public Usuario Usuario { get; set; } // Propriedade para armazenar o usuário autenticado       


        public GerenciadorDeOpcoes(GetListaNfeUseCase getListaNfeUseCase, GetEventosNfeUseCase getEventosNfeUseCase, GetNfeUseCase getNfeUseCase, GetNfeByChaveUseCase getNfeByChaveUseCase)
        {
            _getListaNfeUseCase = getListaNfeUseCase;
            _getEventosNfeUseCase = getEventosNfeUseCase;
            _getNfeUseCase = getNfeUseCase;
            _getNfeByChaveUseCase = getNfeByChaveUseCase;
            InitializeComponent();

            Load += new EventHandler(GerenciadorDeOpcoes_Load);
        }
        private void GerenciadorDeOpcoes_Load(object sender, EventArgs e)
        {
            if (Usuario?.Empresas != null && Usuario.Empresas.Any())
            {
                cmbEmpresa.DataSource = null;

                // Define a lista de empresas como fonte de dados
                cmbEmpresa.DataSource = Usuario.Empresas;

                // Define qual propriedade será exibida e qual será o valor associado
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
        private async void btnDetalhesNFe_Click(object sender, EventArgs e)
        {
            try
            {
                var parametros = new Parametros
                {
                    Chave = txtChaveNfe.Text,
                    //Empresa = null
                };

                var detalheNfe = await _getNfeUseCase.Execute(Usuario, parametros);
                if (detalheNfe != null)
                {

                    dgvNfe.DataSource = null;
                    dgvNfe.DataSource = detalheNfe.doc.totais;
                }
                else
                {
                    MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Detalhes da NFe obtidos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter os detalhes da NFe: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Detalhes da NF-e obtidos com sucesso!");

                    dgvNfe.DataSource = detalhes.listaNFe;
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

                var parametros = new Parametros
                {
                    Chave = txtChaveNfe.Text, 
                    Empresa = cmbEmpresa.SelectedValue?.ToString()
                };

                var eventosNfe = await _getEventosNfeUseCase.Execute(Usuario, parametros);
                if (eventosNfe != null)
                {

                    dgvNfe.DataSource = null;
                    dgvNfe.DataSource = eventosNfe.ListaEvento;
                }
                else
                {
                    MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Eventos da NFe obtidos com sucesso!");
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

                var parametros = new Parametros
                {
                    Empresa = cmbEmpresa.SelectedValue?.ToString(),
                    Chave = txtChaveNfe.Text 
                };

                if (string.IsNullOrEmpty(parametros.Empresa) || string.IsNullOrEmpty(parametros.Chave))
                {
                    MessageBox.Show("Empresa e Chave são obrigatórias para essa operação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chama o caso de uso para obter o PDF
                var pdfNfe = await _getNfeByChaveUseCase.Execute(Usuario, parametros);

                MessageBox.Show("PDF da NF-e obtido com sucesso!");

                // salvar ou exibir o PDF
                // Exemplo para salvar o PDF em disco:
                // File.WriteAllBytes("Caminho_Arquivo.pdf", pdfNfe.Conteudo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter o PDF da NF-e: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

