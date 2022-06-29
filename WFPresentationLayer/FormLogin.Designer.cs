namespace WfPresentationLayer
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.TxtBoxLogin = new System.Windows.Forms.TextBox();
            this.LabelResposta = new System.Windows.Forms.Label();
            this.TxtBoxSenha = new System.Windows.Forms.TextBox();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageBtnFechar = new System.Windows.Forms.PictureBox();
            this.ImagePessoa = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBoxLogin
            // 
            this.TxtBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxLogin.ForeColor = System.Drawing.Color.White;
            this.TxtBoxLogin.Location = new System.Drawing.Point(201, 254);
            this.TxtBoxLogin.Name = "TxtBoxLogin";
            this.TxtBoxLogin.Size = new System.Drawing.Size(246, 30);
            this.TxtBoxLogin.TabIndex = 0;
            this.TxtBoxLogin.Text = "Digite Seu Email";
            this.TxtBoxLogin.Click += new System.EventHandler(this.TxtBoxLogin_TextChanged);
            this.TxtBoxLogin.DoubleClick += new System.EventHandler(this.TxtBoxLogin_TextChanged);
            this.TxtBoxLogin.Leave += new System.EventHandler(this.TxtBoxLogin_TextChanged);
            // 
            // LabelResposta
            // 
            this.LabelResposta.AutoSize = true;
            this.LabelResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LabelResposta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelResposta.ForeColor = System.Drawing.Color.White;
            this.LabelResposta.Location = new System.Drawing.Point(248, 374);
            this.LabelResposta.Name = "LabelResposta";
            this.LabelResposta.Size = new System.Drawing.Size(199, 20);
            this.LabelResposta.TabIndex = 4;
            this.LabelResposta.Text = "Cadastre Com Email e Senha";
            // 
            // TxtBoxSenha
            // 
            this.TxtBoxSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxSenha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxSenha.ForeColor = System.Drawing.Color.White;
            this.TxtBoxSenha.Location = new System.Drawing.Point(201, 319);
            this.TxtBoxSenha.Name = "TxtBoxSenha";
            this.TxtBoxSenha.Size = new System.Drawing.Size(246, 30);
            this.TxtBoxSenha.TabIndex = 1;
            this.TxtBoxSenha.Text = "Digite Sua Senha";
            this.TxtBoxSenha.Click += new System.EventHandler(this.TxtBoxSenha_TextChanged);
            this.TxtBoxSenha.TextChanged += new System.EventHandler(this.KeyChanger);
            this.TxtBoxSenha.Leave += new System.EventHandler(this.TxtBoxSenha_TextChanged);
            // 
            // BtnLogar
            // 
            this.BtnLogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLogar.ForeColor = System.Drawing.Color.White;
            this.BtnLogar.Location = new System.Drawing.Point(208, 420);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(224, 60);
            this.BtnLogar.TabIndex = 2;
            this.BtnLogar.Text = "LOGAR";
            this.BtnLogar.UseVisualStyleBackColor = false;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources._7483870576_6ab43f2e_d6eb_46e1_a824_b7a61aaf6a32;
            this.pictureBox1.Location = new System.Drawing.Point(171, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Location = new System.Drawing.Point(241, 199);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(133, 28);
            this.LabelLogin.TabIndex = 6;
            this.LabelLogin.Text = "Farmacia ZYX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Se voce ainda nao esta cadastrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Solicite ao administrador de seu ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(223, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "sistema que crie seu usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Farmacia ZYX LOGIN";
            // 
            // ImageBtnFechar
            // 
            this.ImageBtnFechar.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.ImageBtnFechar.Location = new System.Drawing.Point(550, 0);
            this.ImageBtnFechar.Name = "ImageBtnFechar";
            this.ImageBtnFechar.Size = new System.Drawing.Size(68, 28);
            this.ImageBtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtnFechar.TabIndex = 15;
            this.ImageBtnFechar.TabStop = false;
            this.ImageBtnFechar.Click += new System.EventHandler(this.ImageBtnFechar_Click);
            // 
            // ImagePessoa
            // 
            this.ImagePessoa.Image = global::WfPresentationLayer.Properties.Resources.external_person_human_body_anatomy_good_lines_kalash;
            this.ImagePessoa.Location = new System.Drawing.Point(171, 254);
            this.ImagePessoa.Name = "ImagePessoa";
            this.ImagePessoa.Size = new System.Drawing.Size(33, 30);
            this.ImagePessoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePessoa.TabIndex = 16;
            this.ImagePessoa.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WfPresentationLayer.Properties.Resources.unlock;
            this.pictureBox2.Location = new System.Drawing.Point(171, 319);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.BtnLogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(617, 576);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ImagePessoa);
            this.Controls.Add(this.ImageBtnFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.TxtBoxSenha);
            this.Controls.Add(this.LabelResposta);
            this.Controls.Add(this.TxtBoxLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmacia ZYX ";
            this.Enter += new System.EventHandler(this.BtnLogar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtBoxLogin;
        private Label LabelResposta;
        private TextBox TxtBoxSenha;
        private Button BtnLogar;
        private PictureBox pictureBox1;
        private Label LabelLogin;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private PictureBox ImageBtnFechar;
        private PictureBox ImagePessoa;
        private PictureBox pictureBox2;
    }
}