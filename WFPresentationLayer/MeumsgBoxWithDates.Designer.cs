namespace WfPresentationLayer
{
    partial class MeumsgBoxWithDates
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.DataFim = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMensagem
            // 
            this.LblMensagem.AutoSize = true;
            this.LblMensagem.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMensagem.ForeColor = System.Drawing.Color.White;
            this.LblMensagem.Location = new System.Drawing.Point(124, 27);
            this.LblMensagem.Name = "LblMensagem";
            this.LblMensagem.Size = new System.Drawing.Size(104, 20);
            this.LblMensagem.TabIndex = 94;
            this.LblMensagem.Text = "TextoPadrao";
            this.LblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.pictureBox1.Location = new System.Drawing.Point(367, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnOk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnOk.ForeColor = System.Drawing.Color.White;
            this.BtnOk.Location = new System.Drawing.Point(105, 200);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(201, 61);
            this.BtnOk.TabIndex = 95;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WfPresentationLayer.Properties.Resources._7483870576_6ab43f2e_d6eb_46e1_a824_b7a61aaf6a32;
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 100;
            this.pictureBox2.TabStop = false;
            // 
            // DataInicio
            // 
            this.DataInicio.Location = new System.Drawing.Point(12, 147);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(187, 27);
            this.DataInicio.TabIndex = 101;
            // 
            // DataFim
            // 
            this.DataFim.Location = new System.Drawing.Point(208, 147);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(192, 27);
            this.DataFim.TabIndex = 102;
            // 
            // MeumsgBoxWithDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(412, 273);
            this.Controls.Add(this.DataFim);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.LblMensagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeumsgBoxWithDates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeumsgBoxWithDates";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblMensagem;
        private PictureBox pictureBox1;
        private Button BtnOk;
        private PictureBox pictureBox2;
        private DateTimePicker DataInicio;
        private DateTimePicker DataFim;
    }
}