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
            this.PnlCompras = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnSelecionarVendas = new System.Windows.Forms.Button();
            this.BtnCadastrarVendas = new System.Windows.Forms.Button();
            this.BtnEntradasHoje = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.GridEntrada.RowHeadersVisible = false;
            this.GridEntrada.RowHeadersWidth = 51;
            this.GridEntrada.RowTemplate.Height = 29;
            this.GridEntrada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEntrada.Size = new System.Drawing.Size(1290, 694);
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
            // PnlCompras
            // 
            this.PnlCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.PnlCompras.Location = new System.Drawing.Point(3, 3);
            this.PnlCompras.Name = "PnlCompras";
            this.PnlCompras.Size = new System.Drawing.Size(1293, 694);
            this.PnlCompras.TabIndex = 47;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox3.Image = global::WfPresentationLayer.Properties.Resources.menu__v11;
            this.pictureBox3.Location = new System.Drawing.Point(352, 715);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.BtnProcurarCompra_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox4.Image = global::WfPresentationLayer.Properties.Resources.icons8_comprar_80;
            this.pictureBox4.Location = new System.Drawing.Point(18, 713);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.BtnCadastrarCompra_Click);
            // 
            // BtnSelecionarVendas
            // 
            this.BtnSelecionarVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnSelecionarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSelecionarVendas.ForeColor = System.Drawing.Color.White;
            this.BtnSelecionarVendas.Location = new System.Drawing.Point(343, 705);
            this.BtnSelecionarVendas.Name = "BtnSelecionarVendas";
            this.BtnSelecionarVendas.Size = new System.Drawing.Size(277, 79);
            this.BtnSelecionarVendas.TabIndex = 56;
            this.BtnSelecionarVendas.Text = "              Selecionar Todas as vendas";
            this.BtnSelecionarVendas.UseVisualStyleBackColor = false;
            this.BtnSelecionarVendas.Click += new System.EventHandler(this.BtnSelecionarVendas_Click);
            // 
            // BtnCadastrarVendas
            // 
            this.BtnCadastrarVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarVendas.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarVendas.Location = new System.Drawing.Point(12, 704);
            this.BtnCadastrarVendas.Name = "BtnCadastrarVendas";
            this.BtnCadastrarVendas.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarVendas.TabIndex = 55;
            this.BtnCadastrarVendas.Text = "        Cadastrar Compra";
            this.BtnCadastrarVendas.UseVisualStyleBackColor = false;
            this.BtnCadastrarVendas.Click += new System.EventHandler(this.BtnCadastrarVendas_Click);
            // 
            // BtnEntradasHoje
            // 
            this.BtnEntradasHoje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnEntradasHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEntradasHoje.ForeColor = System.Drawing.Color.White;
            this.BtnEntradasHoje.Location = new System.Drawing.Point(674, 706);
            this.BtnEntradasHoje.Name = "BtnEntradasHoje";
            this.BtnEntradasHoje.Size = new System.Drawing.Size(277, 79);
            this.BtnEntradasHoje.TabIndex = 59;
            this.BtnEntradasHoje.Text = "              Selecionar Todas as       Entradas de hoje";
            this.BtnEntradasHoje.UseVisualStyleBackColor = false;
            this.BtnEntradasHoje.Click += new System.EventHandler(this.BtnEntradasHoje_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources.icons8_calendário_96;
            this.pictureBox1.Location = new System.Drawing.Point(683, 715);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BtnEntradasHoje_Click);
            // 
            // FormMostrarEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1308, 797);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnEntradasHoje);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnSelecionarVendas);
            this.Controls.Add(this.BtnCadastrarVendas);
            this.Controls.Add(this.GridEntrada);
            this.Controls.Add(this.PnlCompras);
            this.Name = "FormMostrarEntradas";
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.GridEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridEntrada;
        private Panel PnlCompras;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button BtnSelecionarVendas;
        private Button BtnCadastrarVendas;
        private Button BtnEntradasHoje;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridProduto;
        private DataGridViewTextBoxColumn GridValorUnitario;
        private DataGridViewTextBoxColumn GridQuantidade;
        private DataGridViewTextBoxColumn GridValorCompra;
        private DataGridViewTextBoxColumn GridFormaPagamento;
        private DataGridViewTextBoxColumn GridFornecedor;
        private DataGridViewTextBoxColumn GridData;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}