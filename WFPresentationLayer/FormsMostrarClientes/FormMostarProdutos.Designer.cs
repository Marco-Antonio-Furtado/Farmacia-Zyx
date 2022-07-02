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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnDesabilitados = new System.Windows.Forms.Button();
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
            // BtnDesabilitados
            // 
            this.BtnDesabilitados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDesabilitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDesabilitados.ForeColor = System.Drawing.Color.White;
            this.BtnDesabilitados.Location = new System.Drawing.Point(661, 703);
            this.BtnDesabilitados.Name = "BtnDesabilitados";
            this.BtnDesabilitados.Size = new System.Drawing.Size(277, 79);
            this.BtnDesabilitados.TabIndex = 40;
            this.BtnDesabilitados.Text = "Mostrar Produtos Desabilitados";
            this.BtnDesabilitados.UseVisualStyleBackColor = false;
            this.BtnDesabilitados.Click += new System.EventHandler(this.BtnDesabilitados_Click);
            // 
            // BtnDeletarProdutos
            // 
            this.BtnDeletarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarProdutos.Location = new System.Drawing.Point(995, 703);
            this.BtnDeletarProdutos.Name = "BtnDeletarProdutos";
            this.BtnDeletarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarProdutos.TabIndex = 39;
            this.BtnDeletarProdutos.Text = "Deletar / Desabilitar      Produtos";
            this.BtnDeletarProdutos.UseVisualStyleBackColor = false;
            this.BtnDeletarProdutos.Click += new System.EventHandler(this.BtnDeletarProdutos_Click);
            // 
            // BtnAlterarProdutos
            // 
            this.BtnAlterarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarProdutos.Location = new System.Drawing.Point(331, 703);
            this.BtnAlterarProdutos.Name = "BtnAlterarProdutos";
            this.BtnAlterarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarProdutos.TabIndex = 38;
            this.BtnAlterarProdutos.Text = "Alterar / Habilitar         Produtos";
            this.BtnAlterarProdutos.UseVisualStyleBackColor = false;
            this.BtnAlterarProdutos.Click += new System.EventHandler(this.BtnAlterarProdutos_Click);
            // 
            // BtnCadastrarProduto
            // 
            this.BtnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarProduto.Location = new System.Drawing.Point(12, 703);
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
            this.pnlProduto.Size = new System.Drawing.Size(1295, 685);
            this.pnlProduto.TabIndex = 44;
            // 
            // Gridprodutos
            // 
            this.Gridprodutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridprodutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridprodutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.GridRazaosocial,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridprodutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.Gridprodutos.Location = new System.Drawing.Point(0, -7);
            this.Gridprodutos.Name = "Gridprodutos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridprodutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Gridprodutos.RowHeadersWidth = 51;
            this.Gridprodutos.RowTemplate.Height = 29;
            this.Gridprodutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridprodutos.Size = new System.Drawing.Size(1307, 689);
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
            this.ClientSize = new System.Drawing.Size(1326, 794);
            this.Controls.Add(this.BtnCadastrarProduto);
            this.Controls.Add(this.BtnDesabilitados);
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
        private Button BtnDesabilitados;
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