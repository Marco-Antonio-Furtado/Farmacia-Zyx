namespace WfPresentationLayer
{
    partial class FormCadastroProduto
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
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxDescrisaoProduto = new System.Windows.Forms.TextBox();
            this.TxtBoxLaboratorio = new System.Windows.Forms.MaskedTextBox();
            this.Laboratorio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.BtnCadastrarProduto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxPrecoProduto = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descrisao produto";
            // 
            // TxtBoxDescrisaoProduto
            // 
            this.TxtBoxDescrisaoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxDescrisaoProduto.Location = new System.Drawing.Point(12, 102);
            this.TxtBoxDescrisaoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxDescrisaoProduto.Name = "TxtBoxDescrisaoProduto";
            this.TxtBoxDescrisaoProduto.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxDescrisaoProduto.TabIndex = 2;
            // 
            // TxtBoxLaboratorio
            // 
            this.TxtBoxLaboratorio.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxLaboratorio.Location = new System.Drawing.Point(12, 166);
            this.TxtBoxLaboratorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxLaboratorio.Name = "TxtBoxLaboratorio";
            this.TxtBoxLaboratorio.Size = new System.Drawing.Size(193, 27);
            this.TxtBoxLaboratorio.TabIndex = 3;
            // 
            // Laboratorio
            // 
            this.Laboratorio.AutoSize = true;
            this.Laboratorio.Location = new System.Drawing.Point(12, 132);
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.Size = new System.Drawing.Size(87, 20);
            this.Laboratorio.TabIndex = 12;
            this.Laboratorio.Text = "Laboratorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome Produto";
            // 
            // TxtBoxNomeProduto
            // 
            this.TxtBoxNomeProduto.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxNomeProduto.Location = new System.Drawing.Point(12, 38);
            this.TxtBoxNomeProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxNomeProduto.Name = "TxtBoxNomeProduto";
            this.TxtBoxNomeProduto.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxNomeProduto.TabIndex = 1;
            // 
            // BtnCadastrarProduto
            // 
            this.BtnCadastrarProduto.Location = new System.Drawing.Point(259, 38);
            this.BtnCadastrarProduto.Name = "BtnCadastrarProduto";
            this.BtnCadastrarProduto.Size = new System.Drawing.Size(207, 155);
            this.BtnCadastrarProduto.TabIndex = 10;
            this.BtnCadastrarProduto.Text = "Cadastrar Produto";
            this.BtnCadastrarProduto.UseVisualStyleBackColor = true;
            this.BtnCadastrarProduto.Click += new System.EventHandler(this.BtnCadastrarProduto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Preço";
            // 
            // TxtBoxPrecoProduto
            // 
            this.TxtBoxPrecoProduto.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxPrecoProduto.Location = new System.Drawing.Point(12, 222);
            this.TxtBoxPrecoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxPrecoProduto.Mask = "000,00";
            this.TxtBoxPrecoProduto.Name = "TxtBoxPrecoProduto";
            this.TxtBoxPrecoProduto.Size = new System.Drawing.Size(193, 27);
            this.TxtBoxPrecoProduto.TabIndex = 5;
            this.TxtBoxPrecoProduto.ValidatingType = typeof(int);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 272);
            this.Controls.Add(this.TxtBoxPrecoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCadastrarProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxDescrisaoProduto);
            this.Controls.Add(this.TxtBoxLaboratorio);
            this.Controls.Add(this.Laboratorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxNomeProduto);
            this.Name = "CadastroProduto";
            this.Text = "CadastroProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox TxtBoxDescrisaoProduto;
        private MaskedTextBox TxtBoxLaboratorio;
        private Label Laboratorio;
        private Label label1;
        private TextBox TxtBoxNomeProduto;
        private Button BtnCadastrarProduto;
        private Label label2;
        private MaskedTextBox TxtBoxPrecoProduto;
    }
}