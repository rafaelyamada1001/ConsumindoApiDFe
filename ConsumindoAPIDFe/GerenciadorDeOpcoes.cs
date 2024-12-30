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
            }
            else
            {
                MessageBox.Show("Nenhuma empresa associada ao usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void btnDetalhesNFe_Click(object sender, EventArgs e)
        {
            var chave = txtChaveNfe.Text;
            var detalheNfe = await _getNfeUseCase.Execute(Usuario, Paramentros);
        }

        private async void btnListarNFe_Click(object sender, EventArgs e)
        {
            var chave = string.IsNullOrWhiteSpace(txtChaveNfe.Text) ? null : txtChaveNfe.Text;
            var dataInicial = string.IsNullOrWhiteSpace(dtpDataInicial.Text) ? null : dtpDataInicial.Text;
            var dataFinal = string.IsNullOrWhiteSpace(dtpDataFinal.Text) ? null : dtpDataFinal.Text;
            var modelo = string.IsNullOrWhiteSpace(txtModelo.Text) ? null : txtModelo.Text;
            var tipo = string.IsNullOrWhiteSpace(cmbTipo.Text) ? null : cmbTipo.Text;
            var emissao = string.IsNullOrWhiteSpace(cmbEmissao.Text) ? null : cmbEmissao.Text;
            var numero = string.IsNullOrWhiteSpace(txtNumero.Text) ? null : txtNumero.Text;
            var cnpjcpf = string.IsNullOrWhiteSpace(txtCnpjCpf.Text) ? null : txtCnpjCpf.Text;
            var razaoSocial = string.IsNullOrWhiteSpace(txtRazaoSocial.Text) ? null : txtRazaoSocial.Text;

            // Cria uma instância de ListaNfeParams com os valores coletados
            var parametros = new Parametros
            {
                Chave = chave,
                DataInicial = dataInicial,
                DataFinal = dataFinal,
                Modelo = modelo,
                Tipo = tipo,
                Emissao = emissao,
                Numero = numero,
                CnpjCpf = cnpjcpf,
                RazaoSocial = razaoSocial,              
            };

            try
            {
                var detalhes = await _getListaNfeUseCase.Execute(Usuario, parametros);

                if (detalhes != null)
                {
                    // Aqui você pode processar os detalhes conforme necessário
                    MessageBox.Show("Detalhes da NF-e obtidos com sucesso!");

                    // Exemplo: preencher um DataGridView
                    // dataGridViewNfe.DataSource = detalhes.Lista; // Supondo que 'detalhes' tenha uma propriedade 'Lista'

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
            var chave = txtChaveNfe.Text;
            var eventos = await _getEventosNfeUseCase.Execute(Usuario, Paramentros);
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

                // Aqui você pode salvar ou exibir o PDF
                // Exemplo para salvar o PDF em disco:
                // File.WriteAllBytes("Caminho_Arquivo.pdf", pdfNfe.Conteudo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter o PDF da NF-e: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

