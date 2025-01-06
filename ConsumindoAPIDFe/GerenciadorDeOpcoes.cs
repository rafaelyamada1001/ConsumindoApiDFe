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
        public Parametros Paramentros { get; set; }


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
                cmbEmpresa.DisplayMember = "Nome"; // Propriedade que será exibida no ComboBox
                cmbEmpresa.ValueMember = "Id";    // Propriedade usada como valor associado

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
                // Cria e inicializa o objeto Parametros
                var parametros = new Parametros
                {
                    Chave = txtChaveNfe.Text, // Passa o valor da chave da nota fiscal
                    Empresa = null
                };

                // Chama o método que consome a API, passando os parâmetros corretamente
                var detalheNfe = await _getNfeUseCase.Execute(Usuario, Paramentros);
                if (detalheNfe != null)
                {

                    dgvNfe.DataSource = null;
                    dgvNfe.DataSource = detalheNfe;
                }
                else
                {
                    MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Aqui você pode processar o resultado retornado
                MessageBox.Show("Detalhes da NFe obtidos com sucesso!");
            }
            catch (Exception ex)
            {
                // Trata erros
                MessageBox.Show($"Erro ao obter os detalhes da NFe: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private async void btnListarNFe_Click(object sender, EventArgs e)
        {
            var parametros = new Parametros
            {
                Empresa = cmbEmpresa.SelectedValue?.ToString(),
                Chave = txtChaveNfe.Text.Trim(),
                DataInicial = dtpDataInicial.Value.ToString("yyyy-MM-dd"), // Ajusta para o formato esperado pela API
                DataFinal = dtpDataFinal.Value.ToString("yyyy-MM-dd"),   // Ajusta para o formato esperado pela API
                Modelo = txtModelo.Text.Trim(),
                Tipo = cmbTipo.Text.Trim(),
                Emissao = cmbEmissao.Text.Trim(),
                Numero = txtNumero.Text.Trim(),
                CnpjCpf = txtCnpjCpf.Text.Trim(),
                RazaoSocial = txtRazaoSocial.Text.Trim(),
            };

            try
            {
                var detalhes = await _getListaNfeUseCase.Execute(Usuario, parametros);

                if (detalhes != null)
                {
                    MessageBox.Show("Detalhes da NF-e obtidos com sucesso!");

                    dgvNfe.DataSource = null;
                    dgvNfe.DataSource = detalhes;
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
                // Cria e inicializa o objeto Parametros
                var parametros = new Parametros
                {
                    Chave = txtChaveNfe.Text, // Passa o valor da chave da nota fiscal
                    Empresa = cmbEmpresa.SelectedValue?.ToString()
                };

                // Chama o método que consome a API, passando os parâmetros corretamente
                var eventosNfe = await _getNfeUseCase.Execute(Usuario, parametros);
                if (eventosNfe != null)
                {

                    dgvNfe.DataSource = null;
                    dgvNfe.DataSource = eventosNfe;
                }
                else
                {
                    MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Aqui você pode processar o resultado retornado
                MessageBox.Show("Eventos da NFe obtidos com sucesso!");
            }
            catch (Exception ex)
            {
                // Trata erros
                MessageBox.Show($"Erro ao obter os detalhes da NFe: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnPdfNFe_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém os valores necessários
                var parametros = new Parametros
                {
                    Empresa = cmbEmpresa.SelectedValue?.ToString(), // Obtém o ID da empresa selecionada
                    Chave = txtChaveNfe.Text // Obtém a chave informada no TextBox
                };

                if (string.IsNullOrEmpty(parametros.Empresa) || string.IsNullOrEmpty(parametros.Chave))
                {
                    MessageBox.Show("Empresa e Chave são obrigatórias para essa operação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chama o caso de uso para obter o PDF
                var pdfNfe = await _getNfeByChaveUseCase.Execute(Usuario, parametros);

                MessageBox.Show("PDF da NF-e obtido com sucesso!");


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

