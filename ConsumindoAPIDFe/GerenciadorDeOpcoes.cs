using Aplication.UseCase;

namespace ConsumindoAPIDFe
{
    public partial class GerenciadorDeOpcoes : Form
    {
        private readonly GetNfeUseCase _getNfeUseCase;
        public GerenciadorDeOpcoes(GetNfeUseCase getNfeUseCase)
        {
            _getNfeUseCase = getNfeUseCase;

            InitializeComponent();
        }
        private void btnDetalhesNFe_Click(object sender, EventArgs e)
        {
            var useCase = _getNfeUseCase.Execute;
        }
    }
}
