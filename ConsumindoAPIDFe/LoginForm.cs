using Aplication.UseCase;
using Microsoft.Extensions.DependencyInjection;

namespace ConsumindoAPIDFe
{
    public partial class LoginForm : Form
    {
        private readonly PostLoginUseCase _postLoginUseCase;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(PostLoginUseCase postLoginUseCase, IServiceProvider serviceProvider)
        {
            _postLoginUseCase = postLoginUseCase;
            _serviceProvider = serviceProvider;

            InitializeComponent();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            var email = txtUsuario.Text.Trim();
            var senha = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha os campos de email e senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                var usuario = await _postLoginUseCase.Execute(email, senha);

                if (usuario.Sucesso)
                {
                    var gerenciadorDeOpcoes = _serviceProvider.GetRequiredService<GerenciadorDeOpcoesForm>();
                    gerenciadorDeOpcoes.Usuario = usuario.Dados; 
                    gerenciadorDeOpcoes.Show();

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
