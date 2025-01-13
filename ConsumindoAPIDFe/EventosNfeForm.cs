using Domain.Models;
using System.Security.Cryptography.X509Certificates;
namespace ConsumindoAPIDFe
{
    public partial class EventosNfeForm : Form
    {
        public EventosNfe Eventos { get; set; }
        public EventosNfeForm()
        {
            InitializeComponent();
        }

        private void dvgEventosNfe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void MostrarDetalhes()
        {
            dgvEventosNfe.DataSource = null;
            dgvEventosNfe.DataSource = Eventos.ListaEvento;
        }
    }
}
