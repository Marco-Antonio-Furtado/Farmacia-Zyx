namespace WfPresentationLayer.FormCadastros
{
    partial class FormCadastroCidade
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
            this.LblNomeEstado = new System.Windows.Forms.Label();
            this.TxtBoxNomeCidade = new System.Windows.Forms.TextBox();
            this.BtnCadastrarCidade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBoxEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblNomeEstado
            // 
            this.LblNomeEstado.AutoSize = true;
            this.LblNomeEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNomeEstado.ForeColor = System.Drawing.Color.White;
            this.LblNomeEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblNomeEstado.Location = new System.Drawing.Point(31, 107);
            this.LblNomeEstado.Name = "LblNomeEstado";
            this.LblNomeEstado.Size = new System.Drawing.Size(115, 23);
            this.LblNomeEstado.TabIndex = 5;
            this.LblNomeEstado.Text = "Nome Cidade";
            // 
            // TxtBoxNomeCidade
            // 
            this.TxtBoxNomeCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxNomeCidade.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomeCidade.ForeColor = System.Drawing.Color.White;
            this.TxtBoxNomeCidade.Location = new System.Drawing.Point(30, 144);
            this.TxtBoxNomeCidade.Name = "TxtBoxNomeCidade";
            this.TxtBoxNomeCidade.Size = new System.Drawing.Size(125, 30);
            this.TxtBoxNomeCidade.TabIndex = 4;
            // 
            // BtnCadastrarCidade
            // 
            this.BtnCadastrarCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastrarCidade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCidade.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCadastrarCidade.Location = new System.Drawing.Point(30, 215);
            this.BtnCadastrarCidade.Name = "BtnCadastrarCidade";
            this.BtnCadastrarCidade.Size = new System.Drawing.Size(125, 43);
            this.BtnCadastrarCidade.TabIndex = 6;
            this.BtnCadastrarCidade.Text = "Cadastrar ";
            this.BtnCadastrarCidade.UseVisualStyleBackColor = false;
            this.BtnCadastrarCidade.Click += new System.EventHandler(this.BtnCadastrarCidade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome Estado";
            // 
            // CmbBoxEstado
            // 
            this.CmbBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxEstado.FormattingEnabled = true;
            this.CmbBoxEstado.Location = new System.Drawing.Point(18, 65);
            this.CmbBoxEstado.Name = "CmbBoxEstado";
            this.CmbBoxEstado.Size = new System.Drawing.Size(151, 28);
            this.CmbBoxEstado.TabIndex = 9;
            // 
            // FormCadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(181, 270);
            this.Controls.Add(this.CmbBoxEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCadastrarCidade);
            this.Controls.Add(this.LblNomeEstado);
            this.Controls.Add(this.TxtBoxNomeCidade);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "FormCadastroCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroCidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblNomeEstado;
        private TextBox TxtBoxNomeCidade;
        private Button BtnCadastrarCidade;
        private Label label1;
        private ComboBox CmbBoxEstado;
    }
}