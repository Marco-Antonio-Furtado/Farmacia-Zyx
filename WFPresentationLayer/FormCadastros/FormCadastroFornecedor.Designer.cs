namespace WfPresentationLayer.FormCadastros
{
    partial class FormCadastroFornecedor
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
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxNomeResponsavel = new System.Windows.Forms.TextBox();
            this.BtnCadastroFornecedor = new System.Windows.Forms.Button();
            this.TxtBoxTelefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmailFornecedor = new System.Windows.Forms.TextBox();
            this.TxtBoxCnpjFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Nome Responsavel";
            // 
            // TxtBoxNomeResponsavel
            // 
            this.TxtBoxNomeResponsavel.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxNomeResponsavel.Location = new System.Drawing.Point(12, 271);
            this.TxtBoxNomeResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxNomeResponsavel.Name = "TxtBoxNomeResponsavel";
            this.TxtBoxNomeResponsavel.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxNomeResponsavel.TabIndex = 5;
            this.TxtBoxNomeResponsavel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCadastroFornecedor
            // 
            this.BtnCadastroFornecedor.Location = new System.Drawing.Point(240, 19);
            this.BtnCadastroFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCadastroFornecedor.Name = "BtnCadastroFornecedor";
            this.BtnCadastroFornecedor.Size = new System.Drawing.Size(222, 135);
            this.BtnCadastroFornecedor.TabIndex = 6;
            this.BtnCadastroFornecedor.Text = "Cadastrar Fornecedor";
            this.BtnCadastroFornecedor.UseVisualStyleBackColor = true;
            this.BtnCadastroFornecedor.Click += new System.EventHandler(this.BtnCadastroFornecedor_Click);
            // 
            // TxtBoxTelefoneFornecedor
            // 
            this.TxtBoxTelefoneFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxTelefoneFornecedor.Location = new System.Drawing.Point(12, 206);
            this.TxtBoxTelefoneFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxTelefoneFornecedor.Mask = "+55 (99) 90000-0000";
            this.TxtBoxTelefoneFornecedor.Name = "TxtBoxTelefoneFornecedor";
            this.TxtBoxTelefoneFornecedor.Size = new System.Drawing.Size(193, 27);
            this.TxtBoxTelefoneFornecedor.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Telefone ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Email";
            // 
            // txtBoxEmailFornecedor
            // 
            this.txtBoxEmailFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxEmailFornecedor.Location = new System.Drawing.Point(12, 98);
            this.txtBoxEmailFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmailFornecedor.Name = "txtBoxEmailFornecedor";
            this.txtBoxEmailFornecedor.Size = new System.Drawing.Size(203, 27);
            this.txtBoxEmailFornecedor.TabIndex = 2;
            // 
            // TxtBoxCnpjFornecedor
            // 
            this.TxtBoxCnpjFornecedor.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxCnpjFornecedor.Location = new System.Drawing.Point(12, 151);
            this.TxtBoxCnpjFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxCnpjFornecedor.Mask = "00.000.000/0000-00";
            this.TxtBoxCnpjFornecedor.Name = "TxtBoxCnpjFornecedor";
            this.TxtBoxCnpjFornecedor.Size = new System.Drawing.Size(193, 27);
            this.TxtBoxCnpjFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "CNPJ";
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Razão Social";
            // 
            // txtBoxRazaoSocial
            // 
            this.txtBoxRazaoSocial.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxRazaoSocial.Location = new System.Drawing.Point(12, 43);
            this.txtBoxRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxRazaoSocial.Name = "txtBoxRazaoSocial";
            this.txtBoxRazaoSocial.Size = new System.Drawing.Size(203, 27);
            this.txtBoxRazaoSocial.TabIndex = 1;
            // 
            // FormCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 326);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBoxNomeResponsavel);
            this.Controls.Add(this.BtnCadastroFornecedor);
            this.Controls.Add(this.TxtBoxTelefoneFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxEmailFornecedor);
            this.Controls.Add(this.TxtBoxCnpjFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxRazaoSocial);
            this.Name = "FormCadastroFornecedor";
            this.Text = "FormCadastroFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label6;
        private TextBox TxtBoxNomeResponsavel;
        private Button BtnCadastroFornecedor;
        private MaskedTextBox TxtBoxTelefoneFornecedor;
        private Label label5;
        private Label label4;
        private TextBox txtBoxEmailFornecedor;
        private MaskedTextBox TxtBoxCnpjFornecedor;
        private Label label2;
        private Label label1;
        private TextBox txtBoxRazaoSocial;
    }
}