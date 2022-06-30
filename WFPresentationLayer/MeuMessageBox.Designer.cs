namespace WfPresentationLayer
{
    partial class MeuMessageBox
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
            this.LblMensagem = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnSim = new System.Windows.Forms.Button();
            this.BtnNao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMensagem
            // 
            this.LblMensagem.AutoSize = true;
            this.LblMensagem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMensagem.ForeColor = System.Drawing.Color.White;
            this.LblMensagem.Location = new System.Drawing.Point(124, 30);
            this.LblMensagem.Name = "LblMensagem";
            this.LblMensagem.Size = new System.Drawing.Size(104, 20);
            this.LblMensagem.TabIndex = 0;
            this.LblMensagem.Text = "TextoPadrao";
            this.LblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(96, 174);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(201, 61);
            this.BtnOk.TabIndex = 88;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnSim
            // 
            this.BtnSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSim.ForeColor = System.Drawing.Color.White;
            this.BtnSim.Location = new System.Drawing.Point(12, 174);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(178, 61);
            this.BtnSim.TabIndex = 89;
            this.BtnSim.Text = "Sim";
            this.BtnSim.UseVisualStyleBackColor = false;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click_1);
            // 
            // BtnNao
            // 
            this.BtnNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnNao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNao.ForeColor = System.Drawing.Color.White;
            this.BtnNao.Location = new System.Drawing.Point(216, 174);
            this.BtnNao.Name = "BtnNao";
            this.BtnNao.Size = new System.Drawing.Size(174, 61);
            this.BtnNao.TabIndex = 90;
            this.BtnNao.Text = "Nao";
            this.BtnNao.UseVisualStyleBackColor = false;
            this.BtnNao.Click += new System.EventHandler(this.BtnNao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.pictureBox1.Location = new System.Drawing.Point(355, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PctBoxClose);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelTitulo.ForeColor = System.Drawing.Color.White;
            this.LabelTitulo.Location = new System.Drawing.Point(47, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(71, 27);
            this.LabelTitulo.TabIndex = 92;
            this.LabelTitulo.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WfPresentationLayer.Properties.Resources._7483870576_6ab43f2e_d6eb_46e1_a824_b7a61aaf6a32;
            this.pictureBox2.Location = new System.Drawing.Point(12, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // MeuMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(402, 247);
            this.Controls.Add(this.LblMensagem);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnNao);
            this.Controls.Add(this.BtnSim);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeuMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeuMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblMensagem;
        private Button BtnOk;
        private Button BtnSim;
        private Button BtnNao;
        private PictureBox pictureBox1;
        private Label LabelTitulo;
        private PictureBox pictureBox2;
    }
}