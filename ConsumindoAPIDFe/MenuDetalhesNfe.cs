using Aplication.UseCase;
using Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ConsumindoAPIDFe
{
    public partial class MenuDetalhesNfe : Form
    {
        private readonly GetNfeUseCase _getNfeUseCase;
        private readonly IServiceProvider _serviceProvider;       
        public Usuario Usuario { get; set; }
        public MenuDetalhesNfe(GetNfeUseCase getNfeUseCase, IServiceProvider serviceProvider)
        {
            _getNfeUseCase = getNfeUseCase;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private async void btnProdutos_Click(object sender, EventArgs e)
        {

            var parametros = new Parametros
            {
                Chave = txtChaveNfe.Text,
            };

            var detalheNfe = await _getNfeUseCase.Execute(Usuario, parametros);
            if (detalheNfe != null)
            {

                dgvNfe.DataSource = null;
                dgvNfe.DataSource = detalheNfe.doc.item;
            }
            else
            {
                MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnNfe_Click(object sender, EventArgs e)
        {
            try
            {
                var detalhesNfe = _serviceProvider.GetRequiredService<DetalhesNfe>();
                detalhesNfe.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTotais_Click(object sender, EventArgs e)
        {
            try
            {
                var totais = _serviceProvider.GetRequiredService<Totais>();
                totais.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            try
            {
                var transporte = _serviceProvider.GetRequiredService<Transporte>();
                transporte.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            try
            {
                var informacoes = _serviceProvider.GetRequiredService<Informacoes>();
                informacoes.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
