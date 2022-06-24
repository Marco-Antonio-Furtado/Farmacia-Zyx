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
            this.BtnCadastrarCidade = new System.Windows.Forms.Button();
            this.LblNomeEstado = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCadastrarCidade
            // 
            this.BtnCadastrarCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastrarCidade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCidade.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCadastrarCidade.Location = new System.Drawing.Point(26, 122);
            this.BtnCadastrarCidade.Name = "BtnCadastrarCidade";
            this.BtnCadastrarCidade.Size = new System.Drawing.Size(125, 43);
            this.BtnCadastrarCidade.TabIndex = 9;
            this.BtnCadastrarCidade.Text = "Cadastrar ";
            this.BtnCadastrarCidade.UseVisualStyleBackColor = false;
            // 
            // LblNomeEstado
            // 
            this.LblNomeEstado.AutoSize = true;
            this.LblNomeEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNomeEstado.ForeColor = System.Drawing.Color.White;
            this.LblNomeEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblNomeEstado.Location = new System.Drawing.Point(12, 9);
            this.LblNomeEstado.Name = "LblNomeEstado";
            this.LblNomeEstado.Size = new System.Drawing.Size(150, 23);
            this.LblNomeEstado.TabIndex = 8;
            this.LblNomeEstado.Text = "Nome Laboratorio";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(25, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 30);
            this.textBox2.TabIndex = 7;
            // 
            // FormCadastrarLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(180, 197);
            this.Controls.Add(this.BtnCadastrarCidade);
            this.Controls.Add(this.LblNomeEstado);
            this.Controls.Add(this.textBox2);
            this.Name = "FormCadastrarLaboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarLaboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnCadastrarCidade;
        private Label LblNomeEstado;
        private TextBox textBox2;
    }
}