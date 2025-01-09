using Aplication.UseCase;
using Domain.Models;

namespace ConsumindoAPIDFe
{
    public partial class DadosNfe : Form
    {
        public DetalhesNfe Detalhes { get; set; }

        public DadosNfe()
        {

            InitializeComponent();
        }

        public void MostrarDetalhes()
        {
            txtChaveNfe.Text = Detalhes.doc.chNFe;
            txtNumeroNfe.Text = Detalhes.doc.numero;
            txtModelo.Text = Detalhes.doc.modelo;
            txtSerie.Text = Detalhes.doc.serie;
            txtValorTotal.Text = Detalhes.doc.totais.totalNFe.ToString();
            txtCnpj.Text = Detalhes.doc.emitente.cnpj;
            txtRazaoSocial.Text = Detalhes.doc.emitente.razaoSocial;
            txtInscricaoEstadual.Text = Detalhes.doc.emitente.ie;
            txtUnidadeFederativa.Text = Detalhes.doc.emitente.uf;
            txtDataEmissao.Text = Detalhes.doc.dataEmissao;
            txtDataSaida.Text = Detalhes.doc.dataSaida;
            txtDataEscrituracao.Text = Detalhes.doc.dataEscrituracao;
            txtNatureza.Text = Detalhes.doc.natureza;
        }

        private void txtChaveNfe_TextChanged(object sender, EventArgs e)
        {
            txtChaveNfe.Text = Detalhes.doc.chNFe.ToString();
        }
    }
}


