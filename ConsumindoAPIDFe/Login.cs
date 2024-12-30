using Aplication.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace ConsumindoAPIDFe
{
    public partial class Login : Form
    {
        private readonly PostLoginUseCase _postLoginUseCase;
        private readonly IServiceProvider _serviceProvider;

        public Login(PostLoginUseCase postLoginUseCase, IServiceProvider serviceProvider)
        {
            _postLoginUseCase = postLoginUseCase;
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text;
            string senha = txtSenha.Text;

            try
            {
                var usuario = await _postLoginUseCase.Execute(email, senha);

                if (usuario != null)
                {
                    // Resolve o próximo formulário do contêiner
                    var gerenciadorDeOpcoes = _serviceProvider.GetRequiredService<GerenciadorDeOpcoes>();
                    gerenciadorDeOpcoes.Usuario = usuario; // Passa o usuário autenticado para o próximo formulário
                    gerenciadorDeOpcoes.Show();

                    // Oculta o formulário de login
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login inválido. Por favor, verifique suas credenciais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar login: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
