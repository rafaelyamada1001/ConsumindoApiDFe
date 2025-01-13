using Domain.Models;

namespace ConsumindoAPIDFe
{
    public partial class TotaisForm : Form
    {
        public DetalhesNfe Detalhes {  get; set; }

        public TotaisForm()
        {
            InitializeComponent();
        }

        public void MostrarTotais()
        {
            txtVlrProdutos.Text = Detalhes.doc.totais.totalProdutos.ToString();
            txtVlrBaseIcms.Text = Detalhes.doc.totais.totalBaseICMS.ToString();
            txtVlrIcms.Text = Detalhes.doc.totais.totalICMS.ToString();
            txtVlrIcmsSt.Text = Detalhes.doc.totais.totalBaseICMSST.ToString();
            txtVlrIcmsSt.Text = Detalhes.doc.totais.totalICMSST.ToString();
            txtVlrFrete.Text = Detalhes.doc.totais.totalFrete.ToString();
            txtVlrSeguro.Text = Detalhes.doc.totais.totalSeguro.ToString();
            txtVlrIpi.Text = Detalhes.doc.totais.totalIPIDevol.ToString();
            txtOutrasDesp.Text = Detalhes.doc.totais.totalOutrasDesp.ToString();
            txtVlrDesconto.Text = Detalhes.doc.totais.totalDesconto.ToString();
            txtTotalNfe.Text = Detalhes.doc.totais.totalNFe.ToString();

            dgvTotais.DataSource = Detalhes.doc.fpgto;
        }
    }
}
