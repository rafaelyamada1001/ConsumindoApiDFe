namespace ConsumindoAPIDFe
{
    partial class GerenciadorDeOpcoes
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
            dataGridView1 = new DataGridView();
            grpOpcoes = new GroupBox();
            lblEmpresa = new Label();
            cmbEmpresa = new ComboBox();
            btnEventosNFe = new Button();
            btnPdfNFe = new Button();
            btnDetalhesNFe = new Button();
            btnListarNFe = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpOpcoes.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(956, 317);
            dataGridView1.TabIndex = 0;
            // 
            // grpOpcoes
            // 
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
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(168, 10);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(55, 15);
            lblEmpresa.TabIndex = 5;
            lblEmpresa.Text = "Empresa:";
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(168, 28);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(475, 23);
            cmbEmpresa.TabIndex = 4;
            cmbEmpresa.SelectedIndexChanged += cmbEmpresa_SelectedIndexChanged;
            // 
            // btnEventosNFe
            // 
            btnEventosNFe.BackColor = SystemColors.ControlLightLight;
            btnEventosNFe.Location = new Point(6, 100);
            btnEventosNFe.Name = "btnEventosNFe";
            btnEventosNFe.Size = new Size(128, 33);
            btnEventosNFe.TabIndex = 3;
            btnEventosNFe.Text = "Eventos NF-e";
            btnEventosNFe.UseVisualStyleBackColor = false;
            // 
            // btnPdfNFe
            // 
            btnPdfNFe.BackColor = SystemColors.ControlLightLight;
            btnPdfNFe.Location = new Point(6, 61);
            btnPdfNFe.Name = "btnPdfNFe";
            btnPdfNFe.Size = new Size(128, 33);
            btnPdfNFe.TabIndex = 2;
            btnPdfNFe.Text = "PDF NF-e";
            btnPdfNFe.UseVisualStyleBackColor = false;
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
            // GerenciadorDeOpcoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(980, 521);
            Controls.Add(grpOpcoes);
            Controls.Add(dataGridView1);
            Name = "GerenciadorDeOpcoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GerenciadorDeOpcoes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpOpcoes.ResumeLayout(false);
            grpOpcoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grpOpcoes;
        private Button btnListarNFe;
        private Button btnEventosNFe;
        private Button btnPdfNFe;
        private Button btnDetalhesNFe;
        private Label lblEmpresa;
        private ComboBox cmbEmpresa;
    }
}