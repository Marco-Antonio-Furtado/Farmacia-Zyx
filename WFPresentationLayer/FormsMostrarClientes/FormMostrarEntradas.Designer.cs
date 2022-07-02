namespace WfPresentationLayer.Alteraçoes
{
    partial class FormMostrarEntradas
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
            this.GridEntrada = new System.Windows.Forms.DataGridView();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnProcurarCompra = new System.Windows.Forms.Button();
            this.BtnCadastrarCompra = new System.Windows.Forms.Button();
            this.PnlCompras = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEntrada
            // 
            this.GridEntrada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEntrada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEntrada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.GridProduto,
            this.GridValorUnitario,
            this.GridQuantidade,
            this.GridValorCompra,
            this.GridFormaPagamento,
            this.GridFornecedor,
            this.GridData,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridEntrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridEntrada.Location = new System.Drawing.Point(3, 3);
            this.GridEntrada.Name = "GridEntrada";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridEntrada.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridEntrada.RowHeadersWidth = 51;
            this.GridEntrada.RowTemplate.Height = 29;
            this.GridEntrada.Size = new System.Drawing.Size(1286, 706);
            this.GridEntrada.TabIndex = 46;
            // 
            // GridID
            // 
            this.GridID.HeaderText = "ID";
            this.GridID.MinimumWidth = 6;
            this.GridID.Name = "GridID";
            this.GridID.Width = 50;
            // 
            // GridProduto
            // 
            this.GridProduto.HeaderText = "Produtos";
            this.GridProduto.MinimumWidth = 6;
            this.GridProduto.Name = "GridProduto";
            this.GridProduto.Width = 125;
            // 
            // GridValorUnitario
            // 
            this.GridValorUnitario.HeaderText = "Valor Unitario";
            this.GridValorUnitario.MinimumWidth = 6;
            this.GridValorUnitario.Name = "GridValorUnitario";
            this.GridValorUnitario.Width = 125;
            // 
            // GridQuantidade
            // 
            this.GridQuantidade.HeaderText = "Quantidade";
            this.GridQuantidade.MinimumWidth = 6;
            this.GridQuantidade.Name = "GridQuantidade";
            this.GridQuantidade.Width = 120;
            // 
            // GridValorCompra
            // 
            this.GridValorCompra.HeaderText = "Valor Total";
            this.GridValorCompra.MinimumWidth = 6;
            this.GridValorCompra.Name = "GridValorCompra";
            this.GridValorCompra.Width = 125;
            // 
            // GridFormaPagamento
            // 
            this.GridFormaPagamento.HeaderText = "Forma Pagamento";
            this.GridFormaPagamento.MinimumWidth = 6;
            this.GridFormaPagamento.Name = "GridFormaPagamento";
            this.GridFormaPagamento.Width = 125;
            // 
            // GridFornecedor
            // 
            this.GridFornecedor.HeaderText = "Fornecedor";
            this.GridFornecedor.MinimumWidth = 6;
            this.GridFornecedor.Name = "GridFornecedor";
            this.GridFornecedor.Width = 120;
            // 
            // GridData
            // 
            this.GridData.HeaderText = "Data";
            this.GridData.MinimumWidth = 6;
            this.GridData.Name = "GridData";
            this.GridData.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Funcionario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // BtnProcurarCompra
            // 
            this.BtnProcurarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarCompra.Location = new System.Drawing.Point(902, 715);
            this.BtnProcurarCompra.Name = "BtnProcurarCompra";
            this.BtnProcurarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarCompra.TabIndex = 45;
            this.BtnProcurarCompra.Text = "Selecionar Todas as Compras";
            this.BtnProcurarCompra.UseVisualStyleBackColor = false;
            this.BtnProcurarCompra.Click += new System.EventHandler(this.BtnProcurarCompra_Click);
            // 
            // BtnCadastrarCompra
            // 
            this.BtnCadastrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCompra.Location = new System.Drawing.Point(69, 715);
            this.BtnCadastrarCompra.Name = "BtnCadastrarCompra";
            this.BtnCadastrarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarCompra.TabIndex = 42;
            this.BtnCadastrarCompra.Text = "Cadastrar Compra";
            this.BtnCadastrarCompra.UseVisualStyleBackColor = false;
            this.BtnCadastrarCompra.Click += new System.EventHandler(this.BtnCadastrarCompra_Click);
            // 
            // PnlCompras
            // 
            this.PnlCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.PnlCompras.Location = new System.Drawing.Point(3, 3);
            this.PnlCompras.Name = "PnlCompras";
            this.PnlCompras.Size = new System.Drawing.Size(1274, 706);
            this.PnlCompras.TabIndex = 47;
            // 
            // FormMostrarEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1289, 794);
            this.Controls.Add(this.BtnProcurarCompra);
            this.Controls.Add(this.BtnCadastrarCompra);
            this.Controls.Add(this.GridEntrada);
            this.Controls.Add(this.PnlCompras);
            this.Name = "FormMostrarEntradas";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.GridEntrada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridEntrada;
        private Button BtnProcurarCompra;
        private Button BtnCadastrarCompra;
        private Panel PnlCompras;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridProduto;
        private DataGridViewTextBoxColumn GridValorCompra;
        private DataGridViewTextBoxColumn GridQuantidade;
        private DataGridViewTextBoxColumn GridFormaPagamento;
        private DataGridViewTextBoxColumn GridFornecedor;
        private DataGridViewTextBoxColumn GridData;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn GridValorUnitario;
    }
}