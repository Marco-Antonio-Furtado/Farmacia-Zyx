namespace WfPresentationLayer.FormCadastros
{
    partial class FormCadastroEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroEstado));
            this.BtnCadastrarEstado = new System.Windows.Forms.Button();
            this.TxtBoxUf = new System.Windows.Forms.TextBox();
            this.TxtBoxNome = new System.Windows.Forms.TextBox();
            this.LblNomeEstado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCadastrarEstado
            // 
            this.BtnCadastrarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.BtnCadastrarEstado, "BtnCadastrarEstado");
            this.BtnCadastrarEstado.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarEstado.Name = "BtnCadastrarEstado";
            this.BtnCadastrarEstado.UseVisualStyleBackColor = false;
            this.BtnCadastrarEstado.Click += new System.EventHandler(this.BtnCadastrarEstado_Click);
            // 
            // TxtBoxUf
            // 
            this.TxtBoxUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.TxtBoxUf, "TxtBoxUf");
            this.TxtBoxUf.ForeColor = System.Drawing.Color.White;
            this.TxtBoxUf.Name = "TxtBoxUf";
            // 
            // TxtBoxNome
            // 
            this.TxtBoxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.TxtBoxNome, "TxtBoxNome");
            this.TxtBoxNome.ForeColor = System.Drawing.Color.White;
            this.TxtBoxNome.Name = "TxtBoxNome";
            // 
            // LblNomeEstado
            // 
            resources.ApplyResources(this.LblNomeEstado, "LblNomeEstado");
            this.LblNomeEstado.ForeColor = System.Drawing.Color.White;
            this.LblNomeEstado.Name = "LblNomeEstado";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // FormCadastroEstado
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNomeEstado);
            this.Controls.Add(this.TxtBoxNome);
            this.Controls.Add(this.TxtBoxUf);
            this.Controls.Add(this.BtnCadastrarEstado);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormCadastroEstado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCadastrarEstado;
        private TextBox TxtBoxUf;
        private TextBox TxtBoxNome;
        private Label LblNomeEstado;
        private Label label2;
    }
}