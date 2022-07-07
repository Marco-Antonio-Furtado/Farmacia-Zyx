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
            this.LinkGabriel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LinkMarco = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBtnFechar
            // 
            this.ImageBtnFechar.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.ImageBtnFechar.Location = new System.Drawing.Point(338, 2);
            this.ImageBtnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageBtnFechar.Name = "ImageBtnFechar";
            this.ImageBtnFechar.Size = new System.Drawing.Size(60, 21);
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
            this.LblText.Location = new System.Drawing.Point(112, 7);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(128, 19);
            this.LblText.TabIndex = 102;
            this.LblText.Text = "A Quem Quiser Ler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 95);
            this.label1.TabIndex = 104;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources._7483870576_6ab43f2e_d6eb_46e1_a824_b7a61aaf6a32;
            this.pictureBox1.Location = new System.Drawing.Point(276, 300);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WfPresentationLayer.Properties.Resources.icons8_linkedin_100;
            this.pictureBox2.Location = new System.Drawing.Point(10, 162);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 110;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WfPresentationLayer.Properties.Resources.icons8_linkedin_100;
            this.pictureBox3.Location = new System.Drawing.Point(10, 205);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            // 
            // LinkGabriel
            // 
            this.LinkGabriel.AutoSize = true;
            this.LinkGabriel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LinkGabriel.Location = new System.Drawing.Point(96, 205);
            this.LinkGabriel.Name = "LinkGabriel";
            this.LinkGabriel.Size = new System.Drawing.Size(215, 25);
            this.LinkGabriel.TabIndex = 113;
            this.LinkGabriel.TabStop = true;
            this.LinkGabriel.Text = "Linkedin Gabriel Felipe";
            this.LinkGabriel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkGabriel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(96, 248);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(208, 25);
            this.linkLabel1.TabIndex = 114;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Repositório no github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 248);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 115;
            this.pictureBox4.TabStop = false;
            // 
            // LinkMarco
            // 
            this.LinkMarco.AutoSize = true;
            this.LinkMarco.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LinkMarco.Location = new System.Drawing.Point(96, 162);
            this.LinkMarco.Name = "LinkMarco";
            this.LinkMarco.Size = new System.Drawing.Size(229, 25);
            this.LinkMarco.TabIndex = 116;
            this.LinkMarco.TabStop = true;
            this.LinkMarco.Text = "Linkedin Marco Antônio";
            this.LinkMarco.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMarco_LinkClicked);
            // 
            // FormDuvida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(399, 386);
            this.Controls.Add(this.LinkMarco);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LinkGabriel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImageBtnFechar);
            this.Controls.Add(this.LblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDuvida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDuvida";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private LinkLabel LinkGabriel;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox4;
        private LinkLabel LinkMarco;
    }
}