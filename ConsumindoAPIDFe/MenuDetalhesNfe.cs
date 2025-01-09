﻿using Aplication.UseCase;
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
                    var detalhesNfe = _serviceProvider.GetRequiredService<DadosNfe>();
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
                var totais = _serviceProvider.GetRequiredService<Totais>();
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
                var transporte = _serviceProvider.GetRequiredService<Transporte>();
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
    }
}
