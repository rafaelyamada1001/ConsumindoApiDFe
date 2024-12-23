using Aplication.UseCase;

namespace ConsumindoAPIDFe
{
    public partial class Login : Form
    {
        private readonly PostLoginUseCase _postLoginUseCase;
        public Login(PostLoginUseCase postLoginUseCase)
        {
            _postLoginUseCase = postLoginUseCase;
            InitializeComponent();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text;
            string senha = txtSenha.Text;

            var usuario = await _postLoginUseCase.Execute(email, senha);
            
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
