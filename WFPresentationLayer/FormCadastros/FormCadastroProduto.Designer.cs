namespace WfPresentationLayer
{
    partial class FormCadastroProduto
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
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxDescrisaoProduto = new System.Windows.Forms.TextBox();
            this.Laboratorio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxPrecoUnitario = new System.Windows.Forms.MaskedTextBox();
            this.BtnCadastrarProduto = new System.Windows.Forms.Button();
            this.CmbBoxLaboratorio = new System.Windows.Forms.ComboBox();
            this.TxtBoxId = new System.Windows.Forms.MaskedTextBox();
            this.LblIDPRoduto = new System.Windows.Forms.Label();
            this.BtnCadastrarLab = new System.Windows.Forms.Button();
            this.LblText = new System.Windows.Forms.Label();
            this.ImageBtnFechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descrisao produto";
            // 
            // TxtBoxDescrisaoProduto
            // 
            this.TxtBoxDescrisaoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxDescrisaoProduto.ForeColor = System.Drawing.Color.White;
            this.TxtBoxDescrisaoProduto.Location = new System.Drawing.Point(23, 136);
            this.TxtBoxDescrisaoProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxDescrisaoProduto.Name = "TxtBoxDescrisaoProduto";
            this.TxtBoxDescrisaoProduto.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxDescrisaoProduto.TabIndex = 2;
            this.TxtBoxDescrisaoProduto.Text = "Digite A Descrisao";
            this.TxtBoxDescrisaoProduto.Enter += new System.EventHandler(this.TxtBoxDescrisaoProduto_Enter);
            // 
            // Laboratorio
            // 
            this.Laboratorio.AutoSize = true;
            this.Laboratorio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Laboratorio.ForeColor = System.Drawing.Color.White;
            this.Laboratorio.Location = new System.Drawing.Point(23, 166);
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.Size = new System.Drawing.Size(98, 23);
            this.Laboratorio.TabIndex = 12;
            this.Laboratorio.Text = "Laboratorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome Produto";
            // 
            // TxtBoxNomeProduto
            // 
            this.TxtBoxNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxNomeProduto.ForeColor = System.Drawing.Color.White;
            this.TxtBoxNomeProduto.Location = new System.Drawing.Point(23, 72);
            this.TxtBoxNomeProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxNomeProduto.Name = "TxtBoxNomeProduto";
            this.TxtBoxNomeProduto.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxNomeProduto.TabIndex = 1;
            this.TxtBoxNomeProduto.Text = "Digite Nome Produto";
            this.TxtBoxNomeProduto.Enter += new System.EventHandler(this.TxtBoxNomeProduto_Enter);
            this.TxtBoxNomeProduto.Leave += new System.EventHandler(this.TxtBoxNomeProduto_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Preço";
            // 
            // TxtBoxPrecoUnitario
            // 
            this.TxtBoxPrecoUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxPrecoUnitario.ForeColor = System.Drawing.Color.White;
            this.TxtBoxPrecoUnitario.Location = new System.Drawing.Point(23, 259);
            this.TxtBoxPrecoUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxPrecoUnitario.Name = "TxtBoxPrecoUnitario";
            this.TxtBoxPrecoUnitario.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxPrecoUnitario.TabIndex = 5;
            this.TxtBoxPrecoUnitario.ValidatingType = typeof(int);
            this.TxtBoxPrecoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxPrecoUnitario_KeyPress);
            // 
            // BtnCadastrarProduto
            // 
            this.BtnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastrarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrarProduto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarProduto.Location = new System.Drawing.Point(270, 56);
            this.BtnCadastrarProduto.Name = "BtnCadastrarProduto";
            this.BtnCadastrarProduto.Size = new System.Drawing.Size(224, 199);
            this.BtnCadastrarProduto.TabIndex = 18;
            this.BtnCadastrarProduto.Text = "Cadastrar/Altera Produto";
            this.BtnCadastrarProduto.UseVisualStyleBackColor = false;
            this.BtnCadastrarProduto.Click += new System.EventHandler(this.BtnCadastrarProduto_Click_1);
            // 
            // CmbBoxLaboratorio
            // 
            this.CmbBoxLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxLaboratorio.FormattingEnabled = true;
            this.CmbBoxLaboratorio.Location = new System.Drawing.Point(23, 201);
            this.CmbBoxLaboratorio.Name = "CmbBoxLaboratorio";
            this.CmbBoxLaboratorio.Size = new System.Drawing.Size(203, 28);
            this.CmbBoxLaboratorio.TabIndex = 19;
            // 
            // TxtBoxId
            // 
            this.TxtBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxId.ForeColor = System.Drawing.Color.White;
            this.TxtBoxId.Location = new System.Drawing.Point(23, 323);
            this.TxtBoxId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxId.Name = "TxtBoxId";
            this.TxtBoxId.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxId.TabIndex = 20;
            this.TxtBoxId.ValidatingType = typeof(int);
            this.TxtBoxId.Visible = false;
            // 
            // LblIDPRoduto
            // 
            this.LblIDPRoduto.AutoSize = true;
            this.LblIDPRoduto.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIDPRoduto.ForeColor = System.Drawing.Color.White;
            this.LblIDPRoduto.Location = new System.Drawing.Point(23, 296);
            this.LblIDPRoduto.Name = "LblIDPRoduto";
            this.LblIDPRoduto.Size = new System.Drawing.Size(27, 23);
            this.LblIDPRoduto.TabIndex = 21;
            this.LblIDPRoduto.Text = "ID";
            this.LblIDPRoduto.Visible = false;
            // 
            // BtnCadastrarLab
            // 
            this.BtnCadastrarLab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastrarLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrarLab.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarLab.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarLab.Location = new System.Drawing.Point(338, 275);
            this.BtnCadastrarLab.Name = "BtnCadastrarLab";
            this.BtnCadastrarLab.Size = new System.Drawing.Size(156, 75);
            this.BtnCadastrarLab.TabIndex = 22;
            this.BtnCadastrarLab.Text = "Cadastrar Laboratorio";
            this.BtnCadastrarLab.UseVisualStyleBackColor = false;
            this.BtnCadastrarLab.Click += new System.EventHandler(this.BtnCadastrarLab_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblText.ForeColor = System.Drawing.Color.White;
            this.LblText.Location = new System.Drawing.Point(102, 9);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(145, 23);
            this.LblText.TabIndex = 23;
            this.LblText.Text = "Cadastro Produto";
            // 
            // ImageBtnFechar
            // 
            this.ImageBtnFechar.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.ImageBtnFechar.Location = new System.Drawing.Point(483, 4);
            this.ImageBtnFechar.Name = "ImageBtnFechar";
            this.ImageBtnFechar.Size = new System.Drawing.Size(68, 28);
            this.ImageBtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtnFechar.TabIndex = 24;
            this.ImageBtnFechar.TabStop = false;
            this.ImageBtnFechar.Click += new System.EventHandler(this.ImageBtnFechar_Click);
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(554, 388);
            this.Controls.Add(this.ImageBtnFechar);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnCadastrarLab);
            this.Controls.Add(this.TxtBoxId);
            this.Controls.Add(this.LblIDPRoduto);
            this.Controls.Add(this.CmbBoxLaboratorio);
            this.Controls.Add(this.BtnCadastrarProduto);
            this.Controls.Add(this.TxtBoxPrecoUnitario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxDescrisaoProduto);
            this.Controls.Add(this.Laboratorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxNomeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox TxtBoxDescrisaoProduto;
        private Label Laboratorio;
        private Label label1;
        private TextBox TxtBoxNomeProduto;
        private Label label2;
        private MaskedTextBox TxtBoxPrecoProduto;
        private Button BtnCadastrarProduto;
        private ComboBox CmbBoxLaboratorio;
        private MaskedTextBox TxtBoxId;
        private Label LblIDPRoduto;
        private MaskedTextBox TxtBoxPrecoUnitario;
        private Button BtnCadastrarLab;
        private Label LblText;
        private PictureBox ImageBtnFechar;
    }
}