namespace ConsumindoAPIDFe
{
    partial class MenuDetalhesNfeForm
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
            btnProdutos = new Button();
            txtChaveNfe = new TextBox();
            lblChaveNfe = new Label();
            btnNfe = new Button();
            btnTotais = new Button();
            btnTransporte = new Button();
            btnInformacoes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNfe).BeginInit();
            SuspendLayout();
            // 
            // dgvNfe
            // 
            dgvNfe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNfe.Location = new Point(12, 69);
            dgvNfe.Name = "dgvNfe";
            dgvNfe.Size = new Size(776, 298);
            dgvNfe.TabIndex = 0;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(492, 9);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(79, 26);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // txtChaveNfe
            // 
            txtChaveNfe.Location = new Point(86, 9);
            txtChaveNfe.Name = "txtChaveNfe";
            txtChaveNfe.Size = new Size(400, 23);
            txtChaveNfe.TabIndex = 2;
            // 
            // lblChaveNfe
            // 
            lblChaveNfe.AutoSize = true;
            lblChaveNfe.Location = new Point(12, 9);
            lblChaveNfe.Name = "lblChaveNfe";
            lblChaveNfe.Size = new Size(68, 15);
            lblChaveNfe.TabIndex = 3;
            lblChaveNfe.Text = "Chave Nfe :";
            // 
            // btnNfe
            // 
            btnNfe.Location = new Point(598, 9);
            btnNfe.Name = "btnNfe";
            btnNfe.Size = new Size(92, 26);
            btnNfe.TabIndex = 4;
            btnNfe.Text = "NFe";
            btnNfe.UseVisualStyleBackColor = true;
            btnNfe.Click += btnNfe_ClickAsync;
            // 
            // btnTotais
            // 
            btnTotais.Location = new Point(598, 41);
            btnTotais.Name = "btnTotais";
            btnTotais.Size = new Size(92, 26);
            btnTotais.TabIndex = 5;
            btnTotais.Text = "Totais";
            btnTotais.UseVisualStyleBackColor = true;
            btnTotais.Click += btnTotais_ClickAsync;
            // 
            // btnTransporte
            // 
            btnTransporte.Location = new Point(696, 9);
            btnTransporte.Name = "btnTransporte";
            btnTransporte.Size = new Size(92, 26);
            btnTransporte.TabIndex = 6;
            btnTransporte.Text = "Transporte";
            btnTransporte.UseVisualStyleBackColor = true;
            btnTransporte.Click += btnTransporte_ClickAsync;
            // 
            // btnInformacoes
            // 
            btnInformacoes.Location = new Point(696, 41);
            btnInformacoes.Name = "btnInformacoes";
            btnInformacoes.Size = new Size(92, 26);
            btnInformacoes.TabIndex = 7;
            btnInformacoes.Text = "Informações";
            btnInformacoes.UseVisualStyleBackColor = true;
            btnInformacoes.Click += btnInformacoes_ClickAsync;
            // 
            // MenuDetalhesNfe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 379);
            Controls.Add(btnInformacoes);
            Controls.Add(btnTransporte);
            Controls.Add(btnTotais);
            Controls.Add(btnNfe);
            Controls.Add(lblChaveNfe);
            Controls.Add(txtChaveNfe);
            Controls.Add(btnProdutos);
            Controls.Add(dgvNfe);
            Name = "MenuDetalhesNfe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Nfe";
            ((System.ComponentModel.ISupportInitialize)dgvNfe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNfe;
        private Button btnProdutos;
        private TextBox txtChaveNfe;
        private Label lblChaveNfe;
        private Button btnNfe;
        private Button btnTotais;
        private Button btnTransporte;
        private Button btnInformacoes;
    }
}