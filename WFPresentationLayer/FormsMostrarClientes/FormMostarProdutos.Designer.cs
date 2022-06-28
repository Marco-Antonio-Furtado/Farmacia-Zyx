namespace WfPresentationLayer.Alteraçoes
{
    partial class FormMostrarProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnProcurarProdutos = new System.Windows.Forms.Button();
            this.BtnDeletarProdutos = new System.Windows.Forms.Button();
            this.BtnAlterarProdutos = new System.Windows.Forms.Button();
            this.BtnCadastrarProduto = new System.Windows.Forms.Button();
            this.pnlProduto = new System.Windows.Forms.Panel();
            this.Gridprodutos = new System.Windows.Forms.DataGridView();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridRazaosocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnProcurarProdutos
            // 
            this.BtnProcurarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarProdutos.Location = new System.Drawing.Point(687, 647);
            this.BtnProcurarProdutos.Name = "BtnProcurarProdutos";
            this.BtnProcurarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarProdutos.TabIndex = 40;
            this.BtnProcurarProdutos.Text = "Selecionar Produtos ";
            this.BtnProcurarProdutos.UseVisualStyleBackColor = false;
            // 
            // BtnDeletarProdutos
            // 
            this.BtnDeletarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarProdutos.Location = new System.Drawing.Point(1021, 647);
            this.BtnDeletarProdutos.Name = "BtnDeletarProdutos";
            this.BtnDeletarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarProdutos.TabIndex = 39;
            this.BtnDeletarProdutos.Text = "Deletar Produtos";
            this.BtnDeletarProdutos.UseVisualStyleBackColor = false;
            this.BtnDeletarProdutos.Click += new System.EventHandler(this.BtnDeletarProdutos_Click);
            // 
            // BtnAlterarProdutos
            // 
            this.BtnAlterarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarProdutos.Location = new System.Drawing.Point(357, 647);
            this.BtnAlterarProdutos.Name = "BtnAlterarProdutos";
            this.BtnAlterarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarProdutos.TabIndex = 38;
            this.BtnAlterarProdutos.Text = "Alterar Produtos";
            this.BtnAlterarProdutos.UseVisualStyleBackColor = false;
            this.BtnAlterarProdutos.Click += new System.EventHandler(this.BtnAlterarProdutos_Click);
            // 
            // BtnCadastrarProduto
            // 
            this.BtnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarProduto.Location = new System.Drawing.Point(38, 647);
            this.BtnCadastrarProduto.Name = "BtnCadastrarProduto";
            this.BtnCadastrarProduto.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarProduto.TabIndex = 42;
            this.BtnCadastrarProduto.Text = "Cadastrar Produtos";
            this.BtnCadastrarProduto.UseVisualStyleBackColor = false;
            this.BtnCadastrarProduto.Click += new System.EventHandler(this.BtnCadastrarProduto_Click);
            // 
            // pnlProduto
            // 
            this.pnlProduto.Controls.Add(this.Gridprodutos);
            this.pnlProduto.Location = new System.Drawing.Point(12, 12);
            this.pnlProduto.Name = "pnlProduto";
            this.pnlProduto.Size = new System.Drawing.Size(1295, 629);
            this.pnlProduto.TabIndex = 44;
            // 
            // Gridprodutos
            // 
            this.Gridprodutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridprodutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Gridprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridprodutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.GridRazaosocial,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridprodutos.DefaultCellStyle = dataGridViewCellStyle5;
            this.Gridprodutos.Location = new System.Drawing.Point(0, -7);
            this.Gridprodutos.Name = "Gridprodutos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridprodutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Gridprodutos.RowHeadersWidth = 51;
            this.Gridprodutos.RowTemplate.Height = 29;
            this.Gridprodutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridprodutos.Size = new System.Drawing.Size(1307, 633);
            this.Gridprodutos.TabIndex = 45;
            // 
            // GridID
            // 
            this.GridID.HeaderText = "ID";
            this.GridID.MinimumWidth = 6;
            this.GridID.Name = "GridID";
            this.GridID.Width = 75;
            // 
            // GridRazaosocial
            // 
            this.GridRazaosocial.HeaderText = "Nome";
            this.GridRazaosocial.MinimumWidth = 6;
            this.GridRazaosocial.Name = "GridRazaosocial";
            this.GridRazaosocial.Width = 175;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Laboratorio";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrisao";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor Compra";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 175;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Valor Venda";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // FormMostrarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1319, 765);
            this.Controls.Add(this.BtnCadastrarProduto);
            this.Controls.Add(this.BtnProcurarProdutos);
            this.Controls.Add(this.BtnDeletarProdutos);
            this.Controls.Add(this.BtnAlterarProdutos);
            this.Controls.Add(this.pnlProduto);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormMostrarProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormMostrarProdutos_Load);
            this.pnlProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gridprodutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnProcurarProdutos;
        private Button BtnDeletarProdutos;
        private Button BtnAlterarProdutos;
        private Button BtnCadastrarProduto;
        private Panel pnlProduto;
        private DataGridView Gridprodutos;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridRazaosocial;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column2;
    }
}