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
            // Verifica se o usuário possui empresas e preenche o ComboBox
            if (Usuario?.Empresas != null && Usuario.Empresas.Any())
            {
                cmbEmpresa.Items.Clear(); // Limpa os itens existentes

                // Preenche o ComboBox com os nomes das empresas
                foreach (var empresa in Usuario.Empresas)
                {
                    cmbEmpresa.Items.Add(empresa.Nome); // Adiciona o nome da empresa
                }

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
            var detalheNfe = await _getNfeUseCase.Execute(Usuario);
        }

        private async void btnListarNFe_Click(object sender, EventArgs e)
        {
            var chave = txtChaveNfe.Text;
            var dataInicial = dtpDataInicial.Text;
            var dataFinal = dtpDataFinal.Text;
            var modelo = txtModelo.Text;
            var tipo = cmbTipo.Text;
            var emissao = cmbEmissao.Text;
            var numero = txtNumero.Text;
            var cnpjcpf = txtCnpjCpf.Text;
            var razaoSocial = txtRazaoSocial.Text;

            try
            {
                var detalhes = await _getListaNfeUseCase.Execute(Usuario);

                MessageBox.Show("Detalhes da NF-e obtidos com sucesso!");
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
            var eventos = await _getEventosNfeUseCase.Execute(Usuario);
        }

        private async void btnPdfNFe_Click(object sender, EventArgs e)
        {
            var chave = txtChaveNfe.Text;
            var pdfNfe =  await _getNfeByChaveUseCase.Execute(Usuario);
        }
    }
}

