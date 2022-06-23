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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNovoFornecedor = new System.Windows.Forms.Button();
            this.BtnProcurarFornecedor = new System.Windows.Forms.Button();
            this.GroupBoxCompra = new System.Windows.Forms.GroupBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnNovoLaboratorio = new System.Windows.Forms.Button();
            this.CmbBoxLaboratorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.BtnCadastrarCompra = new System.Windows.Forms.Button();
            this.BtnNovoProduto = new System.Windows.Forms.Button();
            this.CmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.LabelFormaPagemento = new System.Windows.Forms.Label();
            this.BtnNovoIten = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.DataGridProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridFormaPAgamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.LabelValorUnitario = new System.Windows.Forms.Label();
            this.TxtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.TxtBoxCodigoProdutoVenda = new System.Windows.Forms.TextBox();
            this.LabelCodigoProduto = new System.Windows.Forms.Label();
            this.LabelNomeCLiente = new System.Windows.Forms.Label();
            this.TxtBoxSelecionarFornecedor = new System.Windows.Forms.TextBox();
            this.GroupBoxCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovoFornecedor
            // 
            this.BtnNovoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnNovoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnNovoFornecedor.Location = new System.Drawing.Point(221, 11);
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
            this.BtnProcurarFornecedor.Location = new System.Drawing.Point(794, 12);
            this.BtnProcurarFornecedor.Name = "BtnProcurarFornecedor";
            this.BtnProcurarFornecedor.Size = new System.Drawing.Size(125, 29);
            this.BtnProcurarFornecedor.TabIndex = 20;
            this.BtnProcurarFornecedor.Text = "Procurar Fornecedor";
            this.BtnProcurarFornecedor.UseVisualStyleBackColor = false;
            // 
            // GroupBoxCompra
            // 
            this.GroupBoxCompra.Controls.Add(this.BtnExcluir);
            this.GroupBoxCompra.Controls.Add(this.label2);
            this.GroupBoxCompra.Controls.Add(this.BtnNovoLaboratorio);
            this.GroupBoxCompra.Controls.Add(this.CmbBoxLaboratorio);
            this.GroupBoxCompra.Controls.Add(this.label1);
            this.GroupBoxCompra.Controls.Add(this.DateTime);
            this.GroupBoxCompra.Controls.Add(this.BtnCadastrarCompra);
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
            this.GroupBoxCompra.Location = new System.Drawing.Point(13, 58);
            this.GroupBoxCompra.Name = "GroupBoxCompra";
            this.GroupBoxCompra.Size = new System.Drawing.Size(1181, 730);
            this.GroupBoxCompra.TabIndex = 19;
            this.GroupBoxCompra.TabStop = false;
            this.GroupBoxCompra.Text = "Nova Compra";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(740, 168);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(233, 79);
            this.BtnExcluir.TabIndex = 32;
            this.BtnExcluir.Text = "Excluir Linha";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Inserir Data";
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
            // DateTime
            // 
            this.DateTime.CalendarMonthBackground = System.Drawing.Color.IndianRed;
            this.DateTime.Location = new System.Drawing.Point(173, 168);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(233, 27);
            this.DateTime.TabIndex = 25;
            // 
            // BtnCadastrarCompra
            // 
            this.BtnCadastrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCompra.Location = new System.Drawing.Point(979, 168);
            this.BtnCadastrarCompra.Name = "BtnCadastrarCompra";
            this.BtnCadastrarCompra.Size = new System.Drawing.Size(196, 79);
            this.BtnCadastrarCompra.TabIndex = 24;
            this.BtnCadastrarCompra.Text = "Cadastrar Venda";
            this.BtnCadastrarCompra.UseVisualStyleBackColor = false;
            this.BtnCadastrarCompra.Click += new System.EventHandler(this.BtnCadastrarCompra_Click);
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
            this.BtnNovoIten.Location = new System.Drawing.Point(457, 168);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridProduto,
            this.DataGridValorUnitario,
            this.DataGridQuantidade,
            this.DatagridValorTotal,
            this.DataGridFormaPAgamento,
            this.DataGridFuncionario,
            this.DataGridFornecedor,
            this.DatagridLaboratorio,
            this.DatagridData});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid.Location = new System.Drawing.Point(6, 257);
            this.DataGrid.Name = "DataGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 29;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1169, 461);
            this.DataGrid.TabIndex = 20;
            // 
            // DataGridProduto
            // 
            this.DataGridProduto.HeaderText = "Produto";
            this.DataGridProduto.MinimumWidth = 6;
            this.DataGridProduto.Name = "DataGridProduto";
            this.DataGridProduto.Width = 75;
            // 
            // DataGridValorUnitario
            // 
            this.DataGridValorUnitario.HeaderText = "Valor Unitario";
            this.DataGridValorUnitario.MinimumWidth = 6;
            this.DataGridValorUnitario.Name = "DataGridValorUnitario";
            this.DataGridValorUnitario.ReadOnly = true;
            this.DataGridValorUnitario.Width = 145;
            // 
            // DataGridQuantidade
            // 
            this.DataGridQuantidade.HeaderText = "Quantidade";
            this.DataGridQuantidade.MinimumWidth = 6;
            this.DataGridQuantidade.Name = "DataGridQuantidade";
            this.DataGridQuantidade.ReadOnly = true;
            this.DataGridQuantidade.Width = 125;
            // 
            // DatagridValorTotal
            // 
            this.DatagridValorTotal.HeaderText = "Valor Total";
            this.DatagridValorTotal.MinimumWidth = 6;
            this.DatagridValorTotal.Name = "DatagridValorTotal";
            this.DatagridValorTotal.ReadOnly = true;
            this.DatagridValorTotal.Width = 125;
            // 
            // DataGridFormaPAgamento
            // 
            this.DataGridFormaPAgamento.HeaderText = "Forma Pagamento";
            this.DataGridFormaPAgamento.MinimumWidth = 6;
            this.DataGridFormaPAgamento.Name = "DataGridFormaPAgamento";
            this.DataGridFormaPAgamento.ReadOnly = true;
            this.DataGridFormaPAgamento.Width = 180;
            // 
            // DataGridFuncionario
            // 
            this.DataGridFuncionario.HeaderText = "Funcionario";
            this.DataGridFuncionario.MinimumWidth = 6;
            this.DataGridFuncionario.Name = "DataGridFuncionario";
            this.DataGridFuncionario.ReadOnly = true;
            this.DataGridFuncionario.Width = 125;
            // 
            // DataGridFornecedor
            // 
            this.DataGridFornecedor.HeaderText = "Fornecedor";
            this.DataGridFornecedor.MinimumWidth = 6;
            this.DataGridFornecedor.Name = "DataGridFornecedor";
            this.DataGridFornecedor.ReadOnly = true;
            this.DataGridFornecedor.Width = 125;
            // 
            // DatagridLaboratorio
            // 
            this.DatagridLaboratorio.HeaderText = "Laboratorio";
            this.DatagridLaboratorio.MinimumWidth = 6;
            this.DatagridLaboratorio.Name = "DatagridLaboratorio";
            this.DatagridLaboratorio.ReadOnly = true;
            this.DatagridLaboratorio.Width = 110;
            // 
            // DatagridData
            // 
            this.DatagridData.HeaderText = "Data";
            this.DatagridData.MinimumWidth = 6;
            this.DatagridData.Name = "DatagridData";
            this.DatagridData.ReadOnly = true;
            this.DatagridData.Width = 75;
            // 
            // TxtBoxValorUnitario
            // 
            this.TxtBoxValorUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxValorUnitario.Location = new System.Drawing.Point(759, 26);
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
            this.LabelValorUnitario.Location = new System.Drawing.Point(638, 29);
            this.LabelValorUnitario.Name = "LabelValorUnitario";
            this.LabelValorUnitario.Size = new System.Drawing.Size(115, 23);
            this.LabelValorUnitario.TabIndex = 18;
            this.LabelValorUnitario.Text = "Valor Unitario";
            // 
            // TxtBoxQuantidade
            // 
            this.TxtBoxQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxQuantidade.Location = new System.Drawing.Point(759, 72);
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
            this.LabelQuantidade.Location = new System.Drawing.Point(638, 73);
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
            this.LabelNomeCLiente.Location = new System.Drawing.Point(399, 17);
            this.LabelNomeCLiente.Name = "LabelNomeCLiente";
            this.LabelNomeCLiente.Size = new System.Drawing.Size(149, 23);
            this.LabelNomeCLiente.TabIndex = 18;
            this.LabelNomeCLiente.Text = "Nome Fornecedor";
            // 
            // TxtBoxSelecionarFornecedor
            // 
            this.TxtBoxSelecionarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxSelecionarFornecedor.Location = new System.Drawing.Point(563, 13);
            this.TxtBoxSelecionarFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxSelecionarFornecedor.Name = "TxtBoxSelecionarFornecedor";
            this.TxtBoxSelecionarFornecedor.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxSelecionarFornecedor.TabIndex = 17;
            // 
            // FormNovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1206, 783);
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
        private Button BtnCadastrarCompra;
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
        private DataGridViewTextBoxColumn DataGridProduto;
        private DataGridViewTextBoxColumn DataGridValorUnitario;
        private DataGridViewTextBoxColumn DataGridQuantidade;
        private DataGridViewTextBoxColumn DatagridValorTotal;
        private DataGridViewTextBoxColumn DataGridFormaPAgamento;
        private DataGridViewTextBoxColumn DataGridFuncionario;
        private DataGridViewTextBoxColumn DataGridFornecedor;
        private DataGridViewTextBoxColumn DatagridLaboratorio;
        private DataGridViewTextBoxColumn DatagridData;
        private Button BtnExcluir;
    }
}