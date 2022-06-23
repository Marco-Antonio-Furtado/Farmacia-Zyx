namespace WfPresentationLayer.Trancaçoes
{
    partial class FormNovaCompra
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
            this.BtnNovoFornecedor = new System.Windows.Forms.Button();
            this.BtnProcurarFornecedor = new System.Windows.Forms.Button();
            this.GroupBoxCompra = new System.Windows.Forms.GroupBox();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.BtnNovaCompra = new System.Windows.Forms.Button();
            this.BtnNovoProduto = new System.Windows.Forms.Button();
            this.CmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.LabelFormaPagemento = new System.Windows.Forms.Label();
            this.BtnNovoIten = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.TxtBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.LabelValorUnitario = new System.Windows.Forms.Label();
            this.TxtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.TxtBoxCodigoProdutoVenda = new System.Windows.Forms.TextBox();
            this.LabelCodigoProduto = new System.Windows.Forms.Label();
            this.LabelNomeCLiente = new System.Windows.Forms.Label();
            this.TxtBoxSelecionarFornecedor = new System.Windows.Forms.TextBox();
            this.CmbBoxLaboratorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNovoLaboratorio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBoxCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovoFornecedor
            // 
            this.BtnNovoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnNovoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnNovoFornecedor.Location = new System.Drawing.Point(154, 17);
            this.BtnNovoFornecedor.Name = "BtnNovoFornecedor";
            this.BtnNovoFornecedor.Size = new System.Drawing.Size(172, 29);
            this.BtnNovoFornecedor.TabIndex = 21;
            this.BtnNovoFornecedor.Text = "Novo Fornecedor";
            this.BtnNovoFornecedor.UseVisualStyleBackColor = false;
            this.BtnNovoFornecedor.Click += new System.EventHandler(this.BtnNovoFornecedor_Click);
            // 
            // BtnProcurarFornecedor
            // 
            this.BtnProcurarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarFornecedor.Location = new System.Drawing.Point(727, 18);
            this.BtnProcurarFornecedor.Name = "BtnProcurarFornecedor";
            this.BtnProcurarFornecedor.Size = new System.Drawing.Size(125, 29);
            this.BtnProcurarFornecedor.TabIndex = 20;
            this.BtnProcurarFornecedor.Text = "Procurar Fornecedor";
            this.BtnProcurarFornecedor.UseVisualStyleBackColor = false;
            // 
            // GroupBoxCompra
            // 
            this.GroupBoxCompra.Controls.Add(this.label2);
            this.GroupBoxCompra.Controls.Add(this.BtnNovoLaboratorio);
            this.GroupBoxCompra.Controls.Add(this.CmbBoxLaboratorio);
            this.GroupBoxCompra.Controls.Add(this.label1);
            this.GroupBoxCompra.Controls.Add(this.DateTime);
            this.GroupBoxCompra.Controls.Add(this.BtnNovaCompra);
            this.GroupBoxCompra.Controls.Add(this.BtnNovoProduto);
            this.GroupBoxCompra.Controls.Add(this.CmbFormaPagamento);
            this.GroupBoxCompra.Controls.Add(this.LabelFormaPagemento);
            this.GroupBoxCompra.Controls.Add(this.BtnNovoIten);
            this.GroupBoxCompra.Controls.Add(this.DataGrid);
            this.GroupBoxCompra.Controls.Add(this.TxtBoxValorUnitario);
            this.GroupBoxCompra.Controls.Add(this.LabelValorUnitario);
            this.GroupBoxCompra.Controls.Add(this.TxtBoxQuantidade);
            this.GroupBoxCompra.Controls.Add(this.LabelQuantidade);
            this.GroupBoxCompra.Controls.Add(this.TxtBoxCodigoProdutoVenda);
            this.GroupBoxCompra.Controls.Add(this.LabelCodigoProduto);
            this.GroupBoxCompra.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCompra.Location = new System.Drawing.Point(13, 64);
            this.GroupBoxCompra.Name = "GroupBoxCompra";
            this.GroupBoxCompra.Size = new System.Drawing.Size(1136, 724);
            this.GroupBoxCompra.TabIndex = 19;
            this.GroupBoxCompra.TabStop = false;
            this.GroupBoxCompra.Text = "Nova Compra";
            // 
            // DateTime
            // 
            this.DateTime.CalendarMonthBackground = System.Drawing.Color.IndianRed;
            this.DateTime.Location = new System.Drawing.Point(173, 168);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(233, 27);
            this.DateTime.TabIndex = 25;
            // 
            // BtnNovaCompra
            // 
            this.BtnNovaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnNovaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovaCompra.ForeColor = System.Drawing.Color.White;
            this.BtnNovaCompra.Location = new System.Drawing.Point(763, 168);
            this.BtnNovaCompra.Name = "BtnNovaCompra";
            this.BtnNovaCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnNovaCompra.TabIndex = 24;
            this.BtnNovaCompra.Text = "Cadastrar Venda";
            this.BtnNovaCompra.UseVisualStyleBackColor = false;
            // 
            // BtnNovoProduto
            // 
            this.BtnNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnNovoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoProduto.ForeColor = System.Drawing.Color.White;
            this.BtnNovoProduto.Location = new System.Drawing.Point(429, 28);
            this.BtnNovoProduto.Name = "BtnNovoProduto";
            this.BtnNovoProduto.Size = new System.Drawing.Size(158, 29);
            this.BtnNovoProduto.TabIndex = 17;
            this.BtnNovoProduto.Text = "Novo Produto";
            this.BtnNovoProduto.UseVisualStyleBackColor = false;
            this.BtnNovoProduto.Click += new System.EventHandler(this.BtnNovoProduto_Click);
            // 
            // CmbFormaPagamento
            // 
            this.CmbFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormaPagamento.FormattingEnabled = true;
            this.CmbFormaPagamento.Location = new System.Drawing.Point(173, 118);
            this.CmbFormaPagamento.Name = "CmbFormaPagamento";
            this.CmbFormaPagamento.Size = new System.Drawing.Size(233, 28);
            this.CmbFormaPagamento.TabIndex = 23;
            // 
            // LabelFormaPagemento
            // 
            this.LabelFormaPagemento.AutoSize = true;
            this.LabelFormaPagemento.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelFormaPagemento.ForeColor = System.Drawing.Color.White;
            this.LabelFormaPagemento.Location = new System.Drawing.Point(15, 120);
            this.LabelFormaPagemento.Name = "LabelFormaPagemento";
            this.LabelFormaPagemento.Size = new System.Drawing.Size(152, 23);
            this.LabelFormaPagemento.TabIndex = 22;
            this.LabelFormaPagemento.Text = "Forma Pagamento";
            // 
            // BtnNovoIten
            // 
            this.BtnNovoIten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnNovoIten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoIten.ForeColor = System.Drawing.Color.White;
            this.BtnNovoIten.Location = new System.Drawing.Point(452, 168);
            this.BtnNovoIten.Name = "BtnNovoIten";
            this.BtnNovoIten.Size = new System.Drawing.Size(277, 79);
            this.BtnNovoIten.TabIndex = 21;
            this.BtnNovoIten.Text = "Novo Item";
            this.BtnNovoIten.UseVisualStyleBackColor = false;
            this.BtnNovoIten.Click += new System.EventHandler(this.BtnNovoIten_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(6, 257);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 29;
            this.DataGrid.Size = new System.Drawing.Size(1124, 461);
            this.DataGrid.TabIndex = 20;
            // 
            // TxtBoxValorUnitario
            // 
            this.TxtBoxValorUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxValorUnitario.Location = new System.Drawing.Point(735, 75);
            this.TxtBoxValorUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxValorUnitario.Name = "TxtBoxValorUnitario";
            this.TxtBoxValorUnitario.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxValorUnitario.TabIndex = 19;
            // 
            // LabelValorUnitario
            // 
            this.LabelValorUnitario.AutoSize = true;
            this.LabelValorUnitario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelValorUnitario.ForeColor = System.Drawing.Color.White;
            this.LabelValorUnitario.Location = new System.Drawing.Point(614, 78);
            this.LabelValorUnitario.Name = "LabelValorUnitario";
            this.LabelValorUnitario.Size = new System.Drawing.Size(115, 23);
            this.LabelValorUnitario.TabIndex = 18;
            this.LabelValorUnitario.Text = "Valor Unitario";
            // 
            // TxtBoxQuantidade
            // 
            this.TxtBoxQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxQuantidade.Location = new System.Drawing.Point(735, 23);
            this.TxtBoxQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxQuantidade.Name = "TxtBoxQuantidade";
            this.TxtBoxQuantidade.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxQuantidade.TabIndex = 17;
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelQuantidade.ForeColor = System.Drawing.Color.White;
            this.LabelQuantidade.Location = new System.Drawing.Point(614, 24);
            this.LabelQuantidade.Name = "LabelQuantidade";
            this.LabelQuantidade.Size = new System.Drawing.Size(100, 23);
            this.LabelQuantidade.TabIndex = 16;
            this.LabelQuantidade.Text = "Quantidade";
            // 
            // TxtBoxCodigoProdutoVenda
            // 
            this.TxtBoxCodigoProdutoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxCodigoProdutoVenda.Location = new System.Drawing.Point(173, 30);
            this.TxtBoxCodigoProdutoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxCodigoProdutoVenda.Name = "TxtBoxCodigoProdutoVenda";
            this.TxtBoxCodigoProdutoVenda.Size = new System.Drawing.Size(238, 27);
            this.TxtBoxCodigoProdutoVenda.TabIndex = 15;
            // 
            // LabelCodigoProduto
            // 
            this.LabelCodigoProduto.AutoSize = true;
            this.LabelCodigoProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelCodigoProduto.ForeColor = System.Drawing.Color.White;
            this.LabelCodigoProduto.Location = new System.Drawing.Point(17, 30);
            this.LabelCodigoProduto.Name = "LabelCodigoProduto";
            this.LabelCodigoProduto.Size = new System.Drawing.Size(132, 23);
            this.LabelCodigoProduto.TabIndex = 14;
            this.LabelCodigoProduto.Text = "Codigo Produto";
            // 
            // LabelNomeCLiente
            // 
            this.LabelNomeCLiente.AutoSize = true;
            this.LabelNomeCLiente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNomeCLiente.ForeColor = System.Drawing.Color.White;
            this.LabelNomeCLiente.Location = new System.Drawing.Point(332, 23);
            this.LabelNomeCLiente.Name = "LabelNomeCLiente";
            this.LabelNomeCLiente.Size = new System.Drawing.Size(149, 23);
            this.LabelNomeCLiente.TabIndex = 18;
            this.LabelNomeCLiente.Text = "Nome Fornecedor";
            // 
            // TxtBoxSelecionarFornecedor
            // 
            this.TxtBoxSelecionarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxSelecionarFornecedor.Location = new System.Drawing.Point(496, 19);
            this.TxtBoxSelecionarFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxSelecionarFornecedor.Name = "TxtBoxSelecionarFornecedor";
            this.TxtBoxSelecionarFornecedor.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxSelecionarFornecedor.TabIndex = 17;
            // 
            // CmbBoxLaboratorio
            // 
            this.CmbBoxLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmbBoxLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxLaboratorio.FormattingEnabled = true;
            this.CmbBoxLaboratorio.Location = new System.Drawing.Point(173, 73);
            this.CmbBoxLaboratorio.Name = "CmbBoxLaboratorio";
            this.CmbBoxLaboratorio.Size = new System.Drawing.Size(233, 28);
            this.CmbBoxLaboratorio.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Laboratorio";
            // 
            // BtnNovoLaboratorio
            // 
            this.BtnNovoLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnNovoLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoLaboratorio.ForeColor = System.Drawing.Color.White;
            this.BtnNovoLaboratorio.Location = new System.Drawing.Point(429, 72);
            this.BtnNovoLaboratorio.Name = "BtnNovoLaboratorio";
            this.BtnNovoLaboratorio.Size = new System.Drawing.Size(158, 29);
            this.BtnNovoLaboratorio.TabIndex = 30;
            this.BtnNovoLaboratorio.Text = "Novo Laboratorio";
            this.BtnNovoLaboratorio.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Inserir Data";
            // 
            // FormNovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1156, 790);
            this.Controls.Add(this.BtnNovoFornecedor);
            this.Controls.Add(this.BtnProcurarFornecedor);
            this.Controls.Add(this.GroupBoxCompra);
            this.Controls.Add(this.LabelNomeCLiente);
            this.Controls.Add(this.TxtBoxSelecionarFornecedor);
            this.Name = "FormNovaCompra";
            this.Text = "FormNovaCompra";
            this.GroupBoxCompra.ResumeLayout(false);
            this.GroupBoxCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnNovoFornecedor;
        private Button BtnProcurarFornecedor;
        private GroupBox GroupBoxCompra;
        private DateTimePicker DateTime;
        private Button BtnNovaCompra;
        private Button BtnNovoProduto;
        private ComboBox CmbFormaPagamento;
        private Label LabelFormaPagemento;
        private Button BtnNovoIten;
        private DataGridView DataGrid;
        private TextBox TxtBoxValorUnitario;
        private Label LabelValorUnitario;
        private TextBox TxtBoxQuantidade;
        private Label LabelQuantidade;
        private TextBox TxtBoxCodigoProdutoVenda;
        private Label LabelCodigoProduto;
        private Label LabelNomeCLiente;
        private TextBox TxtBoxSelecionarFornecedor;
        private Button BtnNovoLaboratorio;
        private ComboBox CmbBoxLaboratorio;
        private Label label1;
        private Label label2;
    }
}