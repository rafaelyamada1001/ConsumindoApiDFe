
using Domain.Models;

namespace ConsumindoAPIDFe
{
    public partial class Informacoes : Form
    {
        public DetalhesNfe Detalhes {  get; set; }
        public Informacoes()
        {
            InitializeComponent();
        }

        public void MostrarInformacoes()
        {
            txtTipoOperacao.Text = Detalhes.doc.tipoOperacao;
            txtTipoEmissao.Text = Detalhes.doc.tipoEmissao;
            txtDestinoOperacao.Text = Detalhes.doc.destinoOperacao;
            txtFinalidade.Text = Detalhes.doc.finalidade;
            txtModalidadeFrete.Text = Detalhes.doc.modalidadeFrete;

            rtxtInfComplementares.Text = Detalhes.doc.infCpl;
        }
    }
}
