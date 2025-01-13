namespace ConsumindoAPIDFe
{
    partial class GerenciadorDeOpcoesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvNfe = new DataGridView();
            grpOpcoes = new GroupBox();
            lblRazaoSocial = new Label();
            txtRazaoSocial = new TextBox();
            txtCnpjCpf = new TextBox();
            lblCnpjCpf = new Label();
            lblEmissao = new Label();
            cmbEmissao = new ComboBox();
            cmbTipo = new ComboBox();
            lblTipo = new Label();
            txtModelo = new TextBox();
            txtNumero = new TextBox();
            lblModelo = new Label();
            lblNumero = new Label();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            lblDataFinal = new Label();
            lblDataInicial = new Label();
            txtChaveNfe = new TextBox();
            lblChaveNfe = new Label();
            lblEmpresa = new Label();
            cmbEmpresa = new ComboBox();
            btnPdfNFe = new Button();
            btnDetalhesNFe = new Button();
            btnListarNFe = new Button();
            txtTotalNotas = new TextBox();
            txtVlrTotal = new TextBox();
            txtNotasCanceladas = new TextBox();
            txtVlrCancelado = new TextBox();
            lblTotalNotas = new Label();
            lblVlrTotal = new Label();
            lblNotasCanceladas = new Label();
            lblVlrCancelado = new Label();
            btnEventosNFe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNfe).BeginInit();
            grpOpcoes.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNfe
            // 
            dgvNfe.BackgroundColor = SystemColors.ControlLightLight;
            dgvNfe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNfe.Location = new Point(12, 245);
            dgvNfe.Name = "dgvNfe";
            dgvNfe.ReadOnly = true;
            dgvNfe.Size = new Size(956, 317);
            dgvNfe.TabIndex = 0;
            dgvNfe.CellContentClick += dgvNfe_CellContentClick;
            // 
            // grpOpcoes
            // 
            grpOpcoes.Controls.Add(lblRazaoSocial);
            grpOpcoes.Controls.Add(txtRazaoSocial);
            grpOpcoes.Controls.Add(txtCnpjCpf);
            grpOpcoes.Controls.Add(lblCnpjCpf);
            grpOpcoes.Controls.Add(lblEmissao);
            grpOpcoes.Controls.Add(cmbEmissao);
            grpOpcoes.Controls.Add(cmbTipo);
            grpOpcoes.Controls.Add(lblTipo);
            grpOpcoes.Controls.Add(txtModelo);
            grpOpcoes.Controls.Add(txtNumero);
            grpOpcoes.Controls.Add(lblModelo);
            grpOpcoes.Controls.Add(lblNumero);
            grpOpcoes.Controls.Add(dtpDataFinal);
            grpOpcoes.Controls.Add(dtpDataInicial);
            grpOpcoes.Controls.Add(lblDataFinal);
            grpOpcoes.Controls.Add(lblDataInicial);
            grpOpcoes.Controls.Add(txtChaveNfe);
            grpOpcoes.Controls.Add(lblChaveNfe);
            grpOpcoes.Controls.Add(lblEmpresa);
            grpOpcoes.Controls.Add(cmbEmpresa);
            grpOpcoes.Controls.Add(btnEventosNFe);
            grpOpcoes.Controls.Add(btnPdfNFe);
            grpOpcoes.Controls.Add(btnDetalhesNFe);
            grpOpcoes.Controls.Add(btnListarNFe);
            grpOpcoes.Location = new Point(12, 9);
            grpOpcoes.Name = "grpOpcoes";
            grpOpcoes.Size = new Size(954, 178);
            grpOpcoes.TabIndex = 1;
            grpOpcoes.TabStop = false;
            grpOpcoes.Text = "Opções";
            // 
            // lblRazaoSocial
            // 
            lblRazaoSocial.AutoSize = true;
            lblRazaoSocial.Location = new Point(414, 61);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(78, 15);
            lblRazaoSocial.TabIndex = 23;
            lblRazaoSocial.Text = "Razão Social :";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(408, 79);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(222, 23);
            txtRazaoSocial.TabIndex = 22;
            // 
            // txtCnpjCpf
            // 
            txtCnpjCpf.Location = new Point(159, 79);
            txtCnpjCpf.Name = "txtCnpjCpf";
            txtCnpjCpf.Size = new Size(231, 23);
            txtCnpjCpf.TabIndex = 21;
            // 
            // lblCnpjCpf
            // 
            lblCnpjCpf.AutoSize = true;
            lblCnpjCpf.Location = new Point(166, 61);
            lblCnpjCpf.Name = "lblCnpjCpf";
            lblCnpjCpf.Size = new Size(66, 15);
            lblCnpjCpf.TabIndex = 20;
            lblCnpjCpf.Text = "CNPJ/CPF :";
            // 
            // lblEmissao
            // 
            lblEmissao.AutoSize = true;
            lblEmissao.Location = new Point(513, 121);
            lblEmissao.Name = "lblEmissao";
            lblEmissao.Size = new Size(56, 15);
            lblEmissao.TabIndex = 19;
            lblEmissao.Text = "Emissão :";
            // 
            // cmbEmissao
            // 
            cmbEmissao.FormattingEnabled = true;
            cmbEmissao.Items.AddRange(new object[] { "Todas", "Proprias", "Terceiro" });
            cmbEmissao.Location = new Point(513, 139);
            cmbEmissao.Name = "cmbEmissao";
            cmbEmissao.Size = new Size(151, 23);
            cmbEmissao.TabIndex = 18;
            cmbEmissao.SelectedIndexChanged += cmbEmissao_SelectedIndexChanged;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Todos ", "Entradas ", "Saidas" });
            cmbTipo.Location = new Point(341, 139);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 23);
            cmbTipo.TabIndex = 17;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(341, 121);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(36, 15);
            lblTipo.TabIndex = 16;
            lblTipo.Text = "Tipo :";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(250, 139);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(60, 23);
            txtModelo.TabIndex = 15;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(159, 139);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(60, 23);
            txtNumero.TabIndex = 14;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(250, 121);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(54, 15);
            lblModelo.TabIndex = 13;
            lblModelo.Text = "Modelo :";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(159, 121);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 12;
            lblNumero.Text = "Número :";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Location = new Point(804, 28);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(129, 23);
            dtpDataFinal.TabIndex = 11;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Location = new Point(649, 28);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(135, 23);
            dtpDataInicial.TabIndex = 10;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Location = new Point(804, 10);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(65, 15);
            lblDataFinal.TabIndex = 9;
            lblDataFinal.Text = "Data Final :";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Location = new Point(661, 10);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(71, 15);
            lblDataInicial.TabIndex = 8;
            lblDataInicial.Text = "Data Inicial :";
            // 
            // txtChaveNfe
            // 
            txtChaveNfe.Location = new Point(649, 79);
            txtChaveNfe.Name = "txtChaveNfe";
            txtChaveNfe.Size = new Size(287, 23);
            txtChaveNfe.TabIndex = 7;
            // 
            // lblChaveNfe
            // 
            lblChaveNfe.AutoSize = true;
            lblChaveNfe.Location = new Point(661, 61);
            lblChaveNfe.Name = "lblChaveNfe";
            lblChaveNfe.Size = new Size(73, 15);
            lblChaveNfe.TabIndex = 6;
            lblChaveNfe.Text = "Chave Nf-e :";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(168, 10);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(58, 15);
            lblEmpresa.TabIndex = 5;
            lblEmpresa.Text = "Empresa :";
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(159, 28);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(471, 23);
            cmbEmpresa.TabIndex = 4;
            cmbEmpresa.SelectedIndexChanged += cmbEmpresa_SelectedIndexChanged;
            // 
            // btnPdfNFe
            // 
            btnPdfNFe.BackColor = SystemColors.ControlLightLight;
            btnPdfNFe.Location = new Point(6, 69);
            btnPdfNFe.Name = "btnPdfNFe";
            btnPdfNFe.Size = new Size(128, 33);
            btnPdfNFe.TabIndex = 2;
            btnPdfNFe.Text = "PDF NF-e";
            btnPdfNFe.UseVisualStyleBackColor = false;
            btnPdfNFe.Click += btnPdfNFe_Click;
            // 
            // btnDetalhesNFe
            // 
            btnDetalhesNFe.BackColor = SystemColors.ControlLightLight;
            btnDetalhesNFe.Location = new Point(6, 22);
            btnDetalhesNFe.Name = "btnDetalhesNFe";
            btnDetalhesNFe.Size = new Size(128, 33);
            btnDetalhesNFe.TabIndex = 1;
            btnDetalhesNFe.Text = "Detalhes NF-e";
            btnDetalhesNFe.UseVisualStyleBackColor = false;
            btnDetalhesNFe.Click += btnDetalhesNFe_Click;
            // 
            // btnListarNFe
            // 
            btnListarNFe.BackColor = SystemColors.ButtonHighlight;
            btnListarNFe.Location = new Point(820, 139);
            btnListarNFe.Name = "btnListarNFe";
            btnListarNFe.Size = new Size(128, 33);
            btnListarNFe.TabIndex = 0;
            btnListarNFe.Text = "Listar NF-e";
            btnListarNFe.UseVisualStyleBackColor = false;
            btnListarNFe.Click += btnListarNFe_Click;
            // 
            // txtTotalNotas
            // 
            txtTotalNotas.BackColor = Color.PaleGreen;
            txtTotalNotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalNotas.Location = new Point(12, 216);
            txtTotalNotas.Name = "txtTotalNotas";
            txtTotalNotas.ReadOnly = true;
            txtTotalNotas.Size = new Size(100, 23);
            txtTotalNotas.TabIndex = 2;
            // 
            // txtVlrTotal
            // 
            txtVlrTotal.BackColor = Color.PaleGreen;
            txtVlrTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVlrTotal.Location = new Point(128, 216);
            txtVlrTotal.Name = "txtVlrTotal";
            txtVlrTotal.ReadOnly = true;
            txtVlrTotal.Size = new Size(100, 23);
            txtVlrTotal.TabIndex = 3;
            // 
            // txtNotasCanceladas
            // 
            txtNotasCanceladas.BackColor = Color.Salmon;
            txtNotasCanceladas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNotasCanceladas.Location = new Point(247, 216);
            txtNotasCanceladas.Name = "txtNotasCanceladas";
            txtNotasCanceladas.ReadOnly = true;
            txtNotasCanceladas.Size = new Size(100, 23);
            txtNotasCanceladas.TabIndex = 4;
            // 
            // txtVlrCancelado
            // 
            txtVlrCancelado.BackColor = Color.Salmon;
            txtVlrCancelado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVlrCancelado.Location = new Point(365, 216);
            txtVlrCancelado.Name = "txtVlrCancelado";
            txtVlrCancelado.ReadOnly = true;
            txtVlrCancelado.Size = new Size(100, 23);
            txtVlrCancelado.TabIndex = 5;
            // 
            // lblTotalNotas
            // 
            lblTotalNotas.AutoSize = true;
            lblTotalNotas.BackColor = SystemColors.Highlight;
            lblTotalNotas.Location = new Point(12, 198);
            lblTotalNotas.Name = "lblTotalNotas";
            lblTotalNotas.Size = new Size(44, 15);
            lblTotalNotas.TabIndex = 6;
            lblTotalNotas.Text = "Notas :";
            // 
            // lblVlrTotal
            // 
            lblVlrTotal.AutoSize = true;
            lblVlrTotal.Location = new Point(128, 198);
            lblVlrTotal.Name = "lblVlrTotal";
            lblVlrTotal.Size = new Size(67, 15);
            lblVlrTotal.TabIndex = 7;
            lblVlrTotal.Text = "Valor Total :";
            // 
            // lblNotasCanceladas
            // 
            lblNotasCanceladas.AutoSize = true;
            lblNotasCanceladas.Location = new Point(247, 198);
            lblNotasCanceladas.Name = "lblNotasCanceladas";
            lblNotasCanceladas.Size = new Size(107, 15);
            lblNotasCanceladas.TabIndex = 8;
            lblNotasCanceladas.Text = "Notas Canceladas :";
            // 
            // lblVlrCancelado
            // 
            lblVlrCancelado.AutoSize = true;
            lblVlrCancelado.Location = new Point(365, 198);
            lblVlrCancelado.Name = "lblVlrCancelado";
            lblVlrCancelado.Size = new Size(98, 15);
            lblVlrCancelado.TabIndex = 9;
            lblVlrCancelado.Text = "Valor Cancelado :";
            // 
            // btnEventosNFe
            // 
            btnEventosNFe.BackColor = SystemColors.ControlLightLight;
            btnEventosNFe.Location = new Point(6, 118);
            btnEventosNFe.Name = "btnEventosNFe";
            btnEventosNFe.Size = new Size(128, 33);
            btnEventosNFe.TabIndex = 3;
            btnEventosNFe.Text = "Eventos NF-e";
            btnEventosNFe.UseVisualStyleBackColor = false;
            btnEventosNFe.Click += btnEventosNFe_Click;
            // 
            // GerenciadorDeOpcoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(979, 574);
            Controls.Add(lblVlrCancelado);
            Controls.Add(lblNotasCanceladas);
            Controls.Add(lblVlrTotal);
            Controls.Add(lblTotalNotas);
            Controls.Add(txtVlrCancelado);
            Controls.Add(txtNotasCanceladas);
            Controls.Add(txtVlrTotal);
            Controls.Add(txtTotalNotas);
            Controls.Add(grpOpcoes);
            Controls.Add(dgvNfe);
            Name = "GerenciadorDeOpcoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GerenciadorDeOpcoes";
            ((System.ComponentModel.ISupportInitialize)dgvNfe).EndInit();
            grpOpcoes.ResumeLayout(false);
            grpOpcoes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNfe;
        private GroupBox grpOpcoes;
        private Button btnListarNFe;
        private Button btnPdfNFe;
        private Button btnDetalhesNFe;
        private Label lblEmpresa;
        private ComboBox cmbEmpresa;
        private TextBox txtChaveNfe;
        private Label lblChaveNfe;
        private TextBox txtNumero;
        private Label lblModelo;
        private Label lblNumero;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
        private Label lblDataFinal;
        private Label lblDataInicial;
        private TextBox txtModelo;
        private ComboBox cmbTipo;
        private Label lblTipo;
        private Label lblCnpjCpf;
        private Label lblEmissao;
        private ComboBox cmbEmissao;
        private Label lblRazaoSocial;
        private TextBox txtRazaoSocial;
        private TextBox txtCnpjCpf;
        private TextBox txtTotalNotas;
        private TextBox txtVlrTotal;
        private TextBox txtNotasCanceladas;
        private TextBox txtVlrCancelado;
        private Label lblTotalNotas;
        private Label lblVlrTotal;
        private Label lblNotasCanceladas;
        private Label lblVlrCancelado;
        private Button btnEventosNFe;
    }
}