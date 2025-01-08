namespace ConsumindoAPIDFe
{
    partial class Informacoes
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
            txtTipoOperacao = new TextBox();
            txtTipoEmissao = new TextBox();
            txtDestinoOperacao = new TextBox();
            txtFinalidade = new TextBox();
            txtModalidadeFrete = new TextBox();
            rtxtInfComplementares = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtTipoOperacao
            // 
            txtTipoOperacao.Location = new Point(12, 75);
            txtTipoOperacao.Name = "txtTipoOperacao";
            txtTipoOperacao.ReadOnly = true;
            txtTipoOperacao.Size = new Size(183, 23);
            txtTipoOperacao.TabIndex = 0;
            // 
            // txtTipoEmissao
            // 
            txtTipoEmissao.Location = new Point(210, 75);
            txtTipoEmissao.Name = "txtTipoEmissao";
            txtTipoEmissao.ReadOnly = true;
            txtTipoEmissao.Size = new Size(183, 23);
            txtTipoEmissao.TabIndex = 1;
            // 
            // txtDestinoOperacao
            // 
            txtDestinoOperacao.Location = new Point(409, 75);
            txtDestinoOperacao.Name = "txtDestinoOperacao";
            txtDestinoOperacao.ReadOnly = true;
            txtDestinoOperacao.Size = new Size(183, 23);
            txtDestinoOperacao.TabIndex = 2;
            // 
            // txtFinalidade
            // 
            txtFinalidade.Location = new Point(605, 75);
            txtFinalidade.Name = "txtFinalidade";
            txtFinalidade.ReadOnly = true;
            txtFinalidade.Size = new Size(183, 23);
            txtFinalidade.TabIndex = 3;
            // 
            // txtModalidadeFrete
            // 
            txtModalidadeFrete.Location = new Point(12, 153);
            txtModalidadeFrete.Name = "txtModalidadeFrete";
            txtModalidadeFrete.ReadOnly = true;
            txtModalidadeFrete.Size = new Size(776, 23);
            txtModalidadeFrete.TabIndex = 4;
            // 
            // rtxtInfComplementares
            // 
            rtxtInfComplementares.Location = new Point(12, 226);
            rtxtInfComplementares.Name = "rtxtInfComplementares";
            rtxtInfComplementares.ReadOnly = true;
            rtxtInfComplementares.Size = new Size(776, 94);
            rtxtInfComplementares.TabIndex = 5;
            rtxtInfComplementares.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 6;
            label1.Text = "Tipo Operação :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 57);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 7;
            label2.Text = "Tipo Emissão :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 57);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 8;
            label3.Text = "Destino Operação :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(605, 57);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Finalidade :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 135);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 10;
            label5.Text = "Modalidade do Frete :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 208);
            label6.Name = "label6";
            label6.Size = new Size(318, 15);
            label6.TabIndex = 11;
            label6.Text = "Informações Complementares de Iteresse do Contribuinte :";
            // 
            // Informacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 367);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtxtInfComplementares);
            Controls.Add(txtModalidadeFrete);
            Controls.Add(txtFinalidade);
            Controls.Add(txtDestinoOperacao);
            Controls.Add(txtTipoEmissao);
            Controls.Add(txtTipoOperacao);
            Name = "Informacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informacoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTipoOperacao;
        private TextBox txtTipoEmissao;
        private TextBox txtDestinoOperacao;
        private TextBox txtFinalidade;
        private TextBox txtModalidadeFrete;
        private RichTextBox rtxtInfComplementares;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}