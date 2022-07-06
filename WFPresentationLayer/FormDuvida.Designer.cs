namespace WfPresentationLayer
{
    partial class FormDuvida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuvida));
            this.ImageBtnFechar = new System.Windows.Forms.PictureBox();
            this.LblText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LinkMarco = new System.Windows.Forms.LinkLabel();
            this.LinkGabriel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBtnFechar
            // 
            this.ImageBtnFechar.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.ImageBtnFechar.Location = new System.Drawing.Point(386, 3);
            this.ImageBtnFechar.Name = "ImageBtnFechar";
            this.ImageBtnFechar.Size = new System.Drawing.Size(68, 28);
            this.ImageBtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtnFechar.TabIndex = 103;
            this.ImageBtnFechar.TabStop = false;
            this.ImageBtnFechar.Click += new System.EventHandler(this.ImageBtnFechar_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblText.ForeColor = System.Drawing.Color.White;
            this.LblText.Location = new System.Drawing.Point(128, 9);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(155, 23);
            this.LblText.TabIndex = 102;
            this.LblText.Text = "A Quem Quiser Ler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 115);
            this.label1.TabIndex = 104;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources._7483870576_6ab43f2e_d6eb_46e1_a824_b7a61aaf6a32;
            this.pictureBox1.Location = new System.Drawing.Point(315, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WfPresentationLayer.Properties.Resources.icons8_linkedin_100;
            this.pictureBox2.Location = new System.Drawing.Point(12, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 110;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WfPresentationLayer.Properties.Resources.icons8_linkedin_100;
            this.pictureBox3.Location = new System.Drawing.Point(12, 326);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            // 
            // LinkMarco
            // 
            this.LinkMarco.AutoSize = true;
            this.LinkMarco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LinkMarco.Location = new System.Drawing.Point(110, 256);
            this.LinkMarco.Name = "LinkMarco";
            this.LinkMarco.Size = new System.Drawing.Size(240, 28);
            this.LinkMarco.TabIndex = 112;
            this.LinkMarco.TabStop = true;
            this.LinkMarco.Text = "Linkedin Marco Antonio";
            this.LinkMarco.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMarco_LinkClicked);
            // 
            // LinkGabriel
            // 
            this.LinkGabriel.AutoSize = true;
            this.LinkGabriel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LinkGabriel.Location = new System.Drawing.Point(110, 326);
            this.LinkGabriel.Name = "LinkGabriel";
            this.LinkGabriel.Size = new System.Drawing.Size(260, 31);
            this.LinkGabriel.TabIndex = 113;
            this.LinkGabriel.TabStop = true;
            this.LinkGabriel.Text = "Linkedin Gabriel Felipe";
            this.LinkGabriel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGabriel_LinkClicked);
            // 
            // FormDuvida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(456, 514);
            this.Controls.Add(this.LinkGabriel);
            this.Controls.Add(this.LinkMarco);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageBtnFechar);
            this.Controls.Add(this.LblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDuvida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDuvida";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ImageBtnFechar;
        private Label LblText;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private LinkLabel LinkMarco;
        private LinkLabel LinkGabriel;
    }
}