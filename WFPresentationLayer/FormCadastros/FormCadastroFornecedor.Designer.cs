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
            this.TxtBoxTelefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxCnpjFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.BtnCadastroFornecedor = new System.Windows.Forms.Button();
            this.LblIdAlteracao = new System.Windows.Forms.Label();
            this.TxtBoxID = new System.Windows.Forms.TextBox();
            this.ImageBtnFechar = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 64;
            this.label6.Text = "Nome Contato";
            // 
            // TxtBoxNomeResponsavel
            // 
            this.TxtBoxNomeResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxNomeResponsavel.ForeColor = System.Drawing.Color.White;
            this.TxtBoxNomeResponsavel.Location = new System.Drawing.Point(15, 310);
            this.TxtBoxNomeResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxNomeResponsavel.Name = "TxtBoxNomeResponsavel";
            this.TxtBoxNomeResponsavel.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxNomeResponsavel.TabIndex = 5;
            this.TxtBoxNomeResponsavel.Text = "Digite O Nome Contato";
            this.TxtBoxNomeResponsavel.Enter += new System.EventHandler(this.TxtBoxNomeResponsavel_Enter);
            this.TxtBoxNomeResponsavel.Leave += new System.EventHandler(this.TxtBoxNomeResponsavel_Enter);
            // 
            // TxtBoxTelefoneFornecedor
            // 
            this.TxtBoxTelefoneFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxTelefoneFornecedor.ForeColor = System.Drawing.Color.White;
            this.TxtBoxTelefoneFornecedor.Location = new System.Drawing.Point(15, 245);
            this.TxtBoxTelefoneFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxTelefoneFornecedor.Mask = "+55 (99) 90000-0000";
            this.TxtBoxTelefoneFornecedor.Name = "TxtBoxTelefoneFornecedor";
            this.TxtBoxTelefoneFornecedor.Size = new System.Drawing.Size(193, 27);
            this.TxtBoxTelefoneFornecedor.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "Telefone ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 59;
            this.label4.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBoxEmail.ForeColor = System.Drawing.Color.White;
            this.txtBoxEmail.Location = new System.Drawing.Point(15, 137);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(203, 27);
            this.txtBoxEmail.TabIndex = 2;
            this.txtBoxEmail.Text = "Digite O Email";
            this.txtBoxEmail.Enter += new System.EventHandler(this.txtBoxEmail_Enter);
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Enter);
            // 
            // TxtBoxCnpjFornecedor
            // 
            this.TxtBoxCnpjFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxCnpjFornecedor.ForeColor = System.Drawing.Color.White;
            this.TxtBoxCnpjFornecedor.Location = new System.Drawing.Point(15, 190);
            this.TxtBoxCnpjFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxCnpjFornecedor.Mask = "00.000.000/0000-00";
            this.TxtBoxCnpjFornecedor.Name = "TxtBoxCnpjFornecedor";
            this.TxtBoxCnpjFornecedor.Size = new System.Drawing.Size(193, 27);
            this.TxtBoxCnpjFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "CNPJ";
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Razão Social";
            // 
            // txtBoxRazaoSocial
            // 
            this.txtBoxRazaoSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBoxRazaoSocial.ForeColor = System.Drawing.Color.White;
            this.txtBoxRazaoSocial.Location = new System.Drawing.Point(15, 82);
            this.txtBoxRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxRazaoSocial.Name = "txtBoxRazaoSocial";
            this.txtBoxRazaoSocial.Size = new System.Drawing.Size(203, 27);
            this.txtBoxRazaoSocial.TabIndex = 1;
            this.txtBoxRazaoSocial.Text = "Digite A Razão Social";
            this.txtBoxRazaoSocial.Enter += new System.EventHandler(this.txtBoxRazaoSocial_Enter);
            this.txtBoxRazaoSocial.Leave += new System.EventHandler(this.txtBoxRazaoSocial_Enter);
            // 
            // BtnCadastroFornecedor
            // 
            this.BtnCadastroFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastroFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastroFornecedor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroFornecedor.Location = new System.Drawing.Point(242, 58);
            this.BtnCadastroFornecedor.Name = "BtnCadastroFornecedor";
            this.BtnCadastroFornecedor.Size = new System.Drawing.Size(226, 147);
            this.BtnCadastroFornecedor.TabIndex = 86;
            this.BtnCadastroFornecedor.Text = "Cadastrar Fornecedor";
            this.BtnCadastroFornecedor.UseVisualStyleBackColor = false;
            this.BtnCadastroFornecedor.Click += new System.EventHandler(this.BtnCadastroFornecedor_Click_1);
            // 
            // LblIdAlteracao
            // 
            this.LblIdAlteracao.AutoSize = true;
            this.LblIdAlteracao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIdAlteracao.ForeColor = System.Drawing.Color.White;
            this.LblIdAlteracao.Location = new System.Drawing.Point(243, 218);
            this.LblIdAlteracao.Name = "LblIdAlteracao";
            this.LblIdAlteracao.Size = new System.Drawing.Size(126, 23);
            this.LblIdAlteracao.TabIndex = 93;
            this.LblIdAlteracao.Text = "ID da alteracao";
            this.LblIdAlteracao.Visible = false;
            // 
            // TxtBoxID
            // 
            this.TxtBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxID.Enabled = false;
            this.TxtBoxID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxID.ForeColor = System.Drawing.Color.White;
            this.TxtBoxID.Location = new System.Drawing.Point(242, 245);
            this.TxtBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxID.Name = "TxtBoxID";
            this.TxtBoxID.Size = new System.Drawing.Size(226, 30);
            this.TxtBoxID.TabIndex = 92;
            this.TxtBoxID.Visible = false;
            // 
            // ImageBtnFechar
            // 
            this.ImageBtnFechar.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.ImageBtnFechar.Location = new System.Drawing.Point(448, 2);
            this.ImageBtnFechar.Name = "ImageBtnFechar";
            this.ImageBtnFechar.Size = new System.Drawing.Size(68, 28);
            this.ImageBtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtnFechar.TabIndex = 94;
            this.ImageBtnFechar.TabStop = false;
            this.ImageBtnFechar.Click += new System.EventHandler(this.ImageBtnFechar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.IndianRed;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(108, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(175, 23);
            this.LblTitulo.TabIndex = 95;
            this.LblTitulo.Text = "Cadastrar Fornecedor";
            // 
            // FormCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(518, 354);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.ImageBtnFechar);
            this.Controls.Add(this.LblIdAlteracao);
            this.Controls.Add(this.TxtBoxID);
            this.Controls.Add(this.BtnCadastroFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBoxNomeResponsavel);
            this.Controls.Add(this.TxtBoxTelefoneFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.TxtBoxCnpjFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxRazaoSocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar NOME_FUNCIONARIO";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label6;
        private TextBox TxtBoxNomeResponsavel;
        private MaskedTextBox TxtBoxTelefoneFornecedor;
        private Label label5;
        private Label label4;
        private TextBox txtBoxEmail;
        private MaskedTextBox TxtBoxCnpjFornecedor;
        private Label label2;
        private Label label1;
        private TextBox txtBoxRazaoSocial;
        private Button BtnCadastroFornecedor;
        private Label LblIdAlteracao;
        private TextBox TxtBoxID;
        private PictureBox ImageBtnFechar;
        private Label LblTitulo;
    }
}