using Domain.Models;

namespace ConsumindoAPIDFe
{
    public partial class TransporteForm : Form
    {
        public DetalhesNfe Detalhes {  get; set; }
        public TransporteForm()
        {
            InitializeComponent();
        }

        public void MostrarTransporte()
        {
            txtCnpj.Text = Detalhes.doc.transp.transporta_CNPJ;
            txtNomeFantasia.Text = Detalhes.doc.transp.transporta_xNome;
            txtEndereco.Text = Detalhes.doc.transp.transporta_xEnder;
            txtMunicipio.Text = Detalhes.doc.transp.transporta_xMun;
            txtInscricaoEstadual.Text = Detalhes.doc.transp.transporta_IE;
            txtUfTransportadora.Text = Detalhes.doc.transp.transporta_UF;
            txtFreteConta.Text = Detalhes.doc.transp.modFrete;
            txtCodAntt.Text = Detalhes.doc.transp.veicTransp_RNTC;
            txtPlacaVeiculo.Text = Detalhes.doc.transp.veicTransp_placa;
            txtUfVeiculo.Text = Detalhes.doc.transp.veicTransp_UF;
            txtQuantidade.Text = Detalhes.doc.transp.vol_qVol.ToString();
            txtEspecie.Text = Detalhes.doc.transp.vol_esp;
            txtMarca.Text = Detalhes.doc.transp.vol_marca;
            txtNumeracao.Text = Detalhes.doc.transp.vol_nVol;
            txtPesoBruto.Text = Detalhes.doc.transp.vol_pesoB.ToString();
            txtPesoliquido.Text = Detalhes.doc.transp.vol_pesoL.ToString();

        }
    }
}
