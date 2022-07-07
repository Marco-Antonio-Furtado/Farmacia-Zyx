namespace WfPresentationLayer.FormCadastros
{
    partial class FormCadastrarLaboratorio
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
            this.BtnCadastroLaboratorio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxNomeResponsavel = new System.Windows.Forms.TextBox();
            this.TxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxCnpjFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRazaoSocial = new System.Windows.Forms.TextBox();
            this.TxtBoxId = new System.Windows.Forms.TextBox();
            this.LblIdAlteracao = new System.Windows.Forms.Label();
            this.ImageBtnFechar = new System.Windows.Forms.PictureBox();
            this.LblText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCadastroLaboratorio
            // 
            this.BtnCadastroLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastroLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastroLaboratorio.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroLaboratorio.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroLaboratorio.Location = new System.Drawing.Point(251, 75);
            this.BtnCadastroLaboratorio.Name = "BtnCadastroLaboratorio";
            this.BtnCadastroLaboratorio.Size = new System.Drawing.Size(219, 147);
            this.BtnCadastroLaboratorio.TabIndex = 97;
            this.BtnCadastroLaboratorio.Text = " Cadastrar/Alterar  Laboratorio";
            this.BtnCadastroLaboratorio.UseVisualStyleBackColor = false;
            this.BtnCadastroLaboratorio.Click += new System.EventHandler(this.BtnCadastroLaboratorio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 23);
            this.label6.TabIndex = 96;
            this.label6.Text = "Nome Contato";
            // 
            // TxtBoxNomeResponsavel
            // 
            this.TxtBoxNomeResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxNomeResponsavel.ForeColor = System.Drawing.Color.White;
            this.TxtBoxNomeResponsavel.Location = new System.Drawing.Point(12, 303);
            this.TxtBoxNomeResponsavel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxNomeResponsavel.Name = "TxtBoxNomeResponsavel";
            this.TxtBoxNomeResponsavel.Size = new System.Drawing.Size(196, 27);
            this.TxtBoxNomeResponsavel.TabIndex = 7;
            this.TxtBoxNomeResponsavel.Text = "Digite O Nome Contato";
            this.TxtBoxNomeResponsavel.Enter += new System.EventHandler(this.TxtBoxNomeResponsavel_Enter);
            this.TxtBoxNomeResponsavel.Leave += new System.EventHandler(this.TxtBoxNomeResponsavel_Enter);
            // 
            // TxtBoxTelefone
            // 
            this.TxtBoxTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxTelefone.ForeColor = System.Drawing.Color.White;
            this.TxtBoxTelefone.Location = new System.Drawing.Point(12, 238);
            this.TxtBoxTelefone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxTelefone.Mask = "+55 (99) 90000-0000";
            this.TxtBoxTelefone.Name = "TxtBoxTelefone";
            this.TxtBoxTelefone.Size = new System.Drawing.Size(186, 27);
            this.TxtBoxTelefone.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 95;
            this.label5.Text = "Telefone ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 94;
            this.label4.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBoxEmail.ForeColor = System.Drawing.Color.White;
            this.txtBoxEmail.Location = new System.Drawing.Point(12, 130);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(196, 27);
            this.txtBoxEmail.TabIndex = 2;
            this.txtBoxEmail.Text = "Digite O Email";
            this.txtBoxEmail.Enter += new System.EventHandler(this.txtBoxEmail_Enter_1);
            this.txtBoxEmail.Leave += new System.EventHandler(this.txtBoxEmail_Enter_1);
            // 
            // TxtBoxCnpjFornecedor
            // 
            this.TxtBoxCnpjFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxCnpjFornecedor.ForeColor = System.Drawing.Color.White;
            this.TxtBoxCnpjFornecedor.Location = new System.Drawing.Point(12, 183);
            this.TxtBoxCnpjFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxCnpjFornecedor.Mask = "00.000.000/0000-00";
            this.TxtBoxCnpjFornecedor.Name = "TxtBoxCnpjFornecedor";
            this.TxtBoxCnpjFornecedor.Size = new System.Drawing.Size(186, 27);
            this.TxtBoxCnpjFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 93;
            this.label2.Text = "CNPJ";
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 92;
            this.label1.Text = "Razão Social";
            // 
            // txtBoxRazaoSocial
            // 
            this.txtBoxRazaoSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBoxRazaoSocial.ForeColor = System.Drawing.Color.White;
            this.txtBoxRazaoSocial.Location = new System.Drawing.Point(12, 75);
            this.txtBoxRazaoSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxRazaoSocial.Name = "txtBoxRazaoSocial";
            this.txtBoxRazaoSocial.Size = new System.Drawing.Size(196, 27);
            this.txtBoxRazaoSocial.TabIndex = 0;
            this.txtBoxRazaoSocial.Text = "Digite A Razão Social";
            this.txtBoxRazaoSocial.Enter += new System.EventHandler(this.txtBoxRazaoSocial_Enter);
            this.txtBoxRazaoSocial.Leave += new System.EventHandler(this.txtBoxRazaoSocial_Enter);
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxId.ForeColor = System.Drawing.Color.White;
            this.TxtBoxId.Location = new System.Drawing.Point(251, 272);
            this.TxtBoxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.Size = new System.Drawing.Size(196, 27);
            this.TxtBoxId.TabIndex = 98;
            this.TxtBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBoxId.Visible = false;
            // 
            // LblIdAlteracao
            // 
            this.LblIdAlteracao.AutoSize = true;
            this.LblIdAlteracao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIdAlteracao.ForeColor = System.Drawing.Color.White;
            this.LblIdAlteracao.Location = new System.Drawing.Point(251, 239);
            this.LblIdAlteracao.Name = "LblIdAlteracao";
            this.LblIdAlteracao.Size = new System.Drawing.Size(126, 23);
            this.LblIdAlteracao.TabIndex = 99;
            this.LblIdAlteracao.Text = "ID da alteracao";
            this.LblIdAlteracao.Visible = false;
            // 
            // ImageBtnFechar
            // 
            this.ImageBtnFechar.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.ImageBtnFechar.Location = new System.Drawing.Point(424, 2);
            this.ImageBtnFechar.Name = "ImageBtnFechar";
            this.ImageBtnFechar.Size = new System.Drawing.Size(68, 28);
            this.ImageBtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtnFechar.TabIndex = 101;
            this.ImageBtnFechar.TabStop = false;
            this.ImageBtnFechar.Click += new System.EventHandler(this.ImageBtnFechar_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblText.ForeColor = System.Drawing.Color.White;
            this.LblText.Location = new System.Drawing.Point(125, 7);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(171, 23);
            this.LblText.TabIndex = 100;
            this.LblText.Text = "Cadastro Laboratorio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources.thin_test_tube1;
            this.pictureBox1.Location = new System.Drawing.Point(393, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // FormCadastrarLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(493, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ImageBtnFechar);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.LblIdAlteracao);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.BtnCadastroLaboratorio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBoxNomeResponsavel);
            this.Controls.Add(this.TxtBoxTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.TxtBoxCnpjFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxRazaoSocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastrarLaboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarLaboratorio";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCadastroLaboratorio;
        private Label label6;
        private TextBox TxtBoxNomeResponsavel;
        private MaskedTextBox TxtBoxTelefone;
        private Label label5;
        private Label label4;
        private TextBox txtBoxEmail;
        private MaskedTextBox TxtBoxCnpjFornecedor;
        private Label label2;
        private Label label1;
        private TextBox txtBoxRazaoSocial;
        private TextBox TxtBoxId;
        private Label LblIdAlteracao;
        private PictureBox ImageBtnFechar;
        private Label LblText;
        private PictureBox pictureBox1;
    }
}