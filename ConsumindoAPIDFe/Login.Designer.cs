namespace ConsumindoAPIDFe
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpLogin = new GroupBox();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.BackColor = Color.Snow;
            grpLogin.Controls.Add(btnEntrar);
            grpLogin.Controls.Add(txtSenha);
            grpLogin.Controls.Add(txtUsuario);
            grpLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpLogin.Location = new Point(12, 12);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(408, 358);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            grpLogin.Text = "Formulário Login";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.MenuHighlight;
            btnEntrar.ForeColor = SystemColors.ButtonHighlight;
            btnEntrar.Location = new Point(104, 204);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(172, 33);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(51, 149);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(291, 27);
            txtSenha.TabIndex = 1;
            txtSenha.Text = "raf1713";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.ButtonHighlight;
            txtUsuario.Location = new Point(51, 101);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Email";
            txtUsuario.Size = new Size(291, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.Tag = "";
            txtUsuario.Text = "rafael.yamada@fourlions.com.br";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(433, 385);
            Controls.Add(grpLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Button btnEntrar;
    }
}
