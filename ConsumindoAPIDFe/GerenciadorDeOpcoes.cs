using Aplication.UseCase;
using Domain.Models;

namespace ConsumindoAPIDFe
{
    public partial class GerenciadorDeOpcoes : Form
    {
        private readonly GetListaNfeUseCase _getListaNfeUseCase;

        public Usuario Usuario { get; set; } // Propriedade para armazenar o usuário autenticado

        public GerenciadorDeOpcoes(GetListaNfeUseCase getNfeUseCase)
        {
            _getListaNfeUseCase = getNfeUseCase;
            InitializeComponent();

            this.Load += new System.EventHandler(this.GerenciadorDeOpcoes_Load);
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

                // Seleciona o primeiro item (opcional)
                cmbEmpresa.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Nenhuma empresa associada ao usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDetalhesNFe_Click(object sender, EventArgs e)
        {

        }

        private async void btnListarNFe_Click(object sender, EventArgs e)
        {
            try
            {
                // Executa o caso de uso assíncrono
                var detalhes = await _getListaNfeUseCase.Execute(Usuario);

                // Mostra uma mensagem de sucesso
                MessageBox.Show("Detalhes da NF-e obtidos com sucesso!");

                // Aqui você pode exibir os detalhes ou processá-los conforme necessário
            }
            catch (Exception ex)
            {
                // Mostra uma mensagem de erro
                MessageBox.Show($"Erro ao obter detalhes da NF-e: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica quando o usuário selecionar uma empresa
            //if (cmbEmpresa.SelectedItem != null)
            //{
            //    string empresaSelecionada = cmbEmpresa.SelectedItem.ToString();
            //    MessageBox.Show($"Empresa selecionada: {empresaSelecionada}");
            //}
        }
    }
}

