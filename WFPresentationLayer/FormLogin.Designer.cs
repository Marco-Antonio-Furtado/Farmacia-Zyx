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
            this.TxtBoxLogin = new System.Windows.Forms.TextBox();
            this.LabelResposta = new System.Windows.Forms.Label();
            this.TxtBoxSenha = new System.Windows.Forms.TextBox();
            this.BtnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBoxLogin
            // 
            this.TxtBoxLogin.Location = new System.Drawing.Point(168, 40);
            this.TxtBoxLogin.Name = "TxtBoxLogin";
            this.TxtBoxLogin.Size = new System.Drawing.Size(126, 27);
            this.TxtBoxLogin.TabIndex = 0;
            this.TxtBoxLogin.Text = "Email";
            this.TxtBoxLogin.Click += new System.EventHandler(this.TxtBoxLogin_TextChanged);
            this.TxtBoxLogin.Leave += new System.EventHandler(this.TxtBoxLogin_TextChanged);
            // 
            // LabelResposta
            // 
            this.LabelResposta.AutoSize = true;
            this.LabelResposta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelResposta.Location = new System.Drawing.Point(109, 158);
            this.LabelResposta.Name = "LabelResposta";
            this.LabelResposta.Size = new System.Drawing.Size(199, 20);
            this.LabelResposta.TabIndex = 4;
            this.LabelResposta.Text = "Cadastre Com Email e Senha";
            // 
            // TxtBoxSenha
            // 
            this.TxtBoxSenha.Location = new System.Drawing.Point(168, 97);
            this.TxtBoxSenha.Name = "TxtBoxSenha";
            this.TxtBoxSenha.Size = new System.Drawing.Size(126, 27);
            this.TxtBoxSenha.TabIndex = 1;
            this.TxtBoxSenha.Text = "Senha";
            this.TxtBoxSenha.Click += new System.EventHandler(this.TxtBoxSenha_TextChanged);
            this.TxtBoxSenha.Leave += new System.EventHandler(this.TxtBoxSenha_TextChanged);
            // 
            // BtnLogar
            // 
            this.BtnLogar.Location = new System.Drawing.Point(339, 40);
            this.BtnLogar.Name = "BtnLogar";
            this.BtnLogar.Size = new System.Drawing.Size(138, 138);
            this.BtnLogar.TabIndex = 2;
            this.BtnLogar.Text = "Logar";
            this.BtnLogar.UseVisualStyleBackColor = true;
            this.BtnLogar.Click += new System.EventHandler(this.BtnLogar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(517, 273);
            this.Controls.Add(this.BtnLogar);
            this.Controls.Add(this.TxtBoxSenha);
            this.Controls.Add(this.LabelResposta);
            this.Controls.Add(this.TxtBoxLogin);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Enter += new System.EventHandler(this.BtnLogar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtBoxLogin;
        private Label LabelResposta;
        private TextBox TxtBoxSenha;
        private Button BtnLogar;
    }
}