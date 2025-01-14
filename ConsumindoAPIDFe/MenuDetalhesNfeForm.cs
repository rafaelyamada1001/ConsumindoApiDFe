using Aplication.UseCase;
using Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace ConsumindoAPIDFe
{
    public partial class MenuDetalhesNfeForm : Form
    {
        private readonly GetNfeUseCase _getNfeUseCase;       
        private readonly IServiceProvider _serviceProvider;

        public Usuario Usuario { get; set; }
        public string ChaveNfe { get; set; }
        public MenuDetalhesNfeForm(GetNfeUseCase getNfeUseCase, IServiceProvider serviceProvider, GetEventosNfeUseCase getEventosNfeUseCase)
        {
            _getNfeUseCase = getNfeUseCase;
            _serviceProvider = serviceProvider;

            InitializeComponent();
            Load += MenuDetalhesNfeForm_Load;
        }
        private void MenuDetalhesNfeForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ChaveNfe))
            {
                txtChaveNfe.Text = ChaveNfe;
            }
        }
        private async void btnProdutos_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtChaveNfe.Text))
            {
                MessageBox.Show("O campo 'Chave NF-e' é obrigatório para essa requisição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parametros = new Parametros
            {
                Chave = txtChaveNfe.Text,
            };

            var resultado = await _getNfeUseCase.Execute(Usuario, parametros);
            if (resultado != null)
            {
                dgvNfe.DataSource = null;
                dgvNfe.DataSource = resultado.Dados.doc.item;

                dgvNfe.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                dgvNfe.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                for (int i = 0; i < dgvNfe.Columns.Count; i++)
                {
                    dgvNfe.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            else
            {
                MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnNfe_ClickAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChaveNfe.Text))
            {
                MessageBox.Show("O campo 'Chave NF-e' é obrigatório para essa requisição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parametros = new Parametros
            {
                Chave = txtChaveNfe.Text,
            };

            var resultado = await _getNfeUseCase.Execute(Usuario, parametros);
            if (resultado != null)
            {
                var detalhesNfe = _serviceProvider.GetRequiredService<DetalhesNfeForm>();
                detalhesNfe.Detalhes = resultado.Dados;
                detalhesNfe.MostrarDetalhes();
                detalhesNfe.Show();
            }
            else
            {
                MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnTotais_ClickAsync(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtChaveNfe.Text))
            {
                MessageBox.Show("O campo 'Chave NF-e' é obrigatório para essa requisição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parametros = new Parametros
            {
                Chave = txtChaveNfe.Text,
            };

            var resultado = await _getNfeUseCase.Execute(Usuario, parametros);
            if (resultado != null)
            {
                var totais = _serviceProvider.GetRequiredService<TotaisForm>();
                totais.Detalhes = resultado.Dados;
                totais.MostrarTotais();
                totais.Show();
            }
            else
            {
                MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnTransporte_ClickAsync(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtChaveNfe.Text))
            {
                MessageBox.Show("O campo 'Chave NF-e' é obrigatório para essa requisição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parametros = new Parametros
            {
                Chave = txtChaveNfe.Text,
            };

            var resultado = await _getNfeUseCase.Execute(Usuario, parametros);
            if (resultado != null)
            {
                var transporte = _serviceProvider.GetRequiredService<TransporteForm>();
                transporte.Detalhes = resultado.Dados;
                transporte.MostrarTransporte();
                transporte.Show();
            }
            else
            {
                MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private async void btnInformacoes_ClickAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChaveNfe.Text))
            {
                MessageBox.Show("O campo 'Chave NF-e' é obrigatório para essa requisição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var parametros = new Parametros
            {
                Chave = txtChaveNfe.Text,
            };

            var resultado = await _getNfeUseCase.Execute(Usuario, parametros);

            if (resultado != null)
            {
                var informacoes = _serviceProvider.GetRequiredService<Informacoes>();
                informacoes.Detalhes = resultado.Dados;
                informacoes.MostrarInformacoes();
                informacoes.Show();
            }
            else
            {
                MessageBox.Show("Nenhum detalhe encontrado para os parâmetros fornecidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnEventosNfe_Click(object sender, EventArgs e)
        {
            
        }
    }
}
