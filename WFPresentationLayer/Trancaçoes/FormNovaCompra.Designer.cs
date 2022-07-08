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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnNovoFornecedor = new System.Windows.Forms.Button();
            this.BtnProcurarFornecedor = new System.Windows.Forms.Button();
            this.GroupBoxCompra = new System.Windows.Forms.GroupBox();
            this.TxtBoxSelecionarProduto = new System.Windows.Forms.TextBox();
            this.BtnProcurarProduto = new System.Windows.Forms.Button();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1TxtBoxPrecoAlterado = new System.Windows.Forms.TextBox();
            this.CheckPreco = new System.Windows.Forms.CheckBox();
            this.TxtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.BtnCadastrarCompra = new System.Windows.Forms.Button();
            this.CmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.LabelFormaPagemento = new System.Windows.Forms.Label();
            this.BtnNovoIten = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.LabelCodigoProduto = new System.Windows.Forms.Label();
            this.BtnNovoProduto = new System.Windows.Forms.Button();
            this.LabelNomeCLiente = new System.Windows.Forms.Label();
            this.ImageBtnFechar = new System.Windows.Forms.PictureBox();
            this.LblText = new System.Windows.Forms.Label();
            this.TxtBoxSelecionarFornecedor = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DataGridProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridFormaPAgamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovoFornecedor
            // 
            this.BtnNovoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnNovoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnNovoFornecedor.Location = new System.Drawing.Point(263, 45);
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
            this.BtnProcurarFornecedor.Location = new System.Drawing.Point(888, 47);
            this.BtnProcurarFornecedor.Name = "BtnProcurarFornecedor";
            this.BtnProcurarFornecedor.Size = new System.Drawing.Size(125, 29);
            this.BtnProcurarFornecedor.TabIndex = 20;
            this.BtnProcurarFornecedor.Text = "Procurar Fornecedor";
            this.BtnProcurarFornecedor.UseVisualStyleBackColor = false;
            this.BtnProcurarFornecedor.Click += new System.EventHandler(this.BtnProcurarFornecedor_Click);
            // 
            // GroupBoxCompra
            // 
            this.GroupBoxCompra.Controls.Add(this.pictureBox4);
            this.GroupBoxCompra.Controls.Add(this.pictureBox3);
            this.GroupBoxCompra.Controls.Add(this.pictureBox2);
            this.GroupBoxCompra.Controls.Add(this.TxtBoxSelecionarProduto);
            this.GroupBoxCompra.Controls.Add(this.BtnProcurarProduto);
            this.GroupBoxCompra.Controls.Add(this.LblValorTotal);
            this.GroupBoxCompra.Controls.Add(this.label1);
            this.GroupBoxCompra.Controls.Add(this.textBox1TxtBoxPrecoAlterado);
            this.GroupBoxCompra.Controls.Add(this.CheckPreco);
            this.GroupBoxCompra.Controls.Add(this.TxtBoxQuantidade);
            this.GroupBoxCompra.Controls.Add(this.BtnExcluir);
            this.GroupBoxCompra.Controls.Add(this.label2);
            this.GroupBoxCompra.Controls.Add(this.DateTime);
            this.GroupBoxCompra.Controls.Add(this.BtnCadastrarCompra);
            this.GroupBoxCompra.Controls.Add(this.CmbFormaPagamento);
            this.GroupBoxCompra.Controls.Add(this.LabelFormaPagemento);
            this.GroupBoxCompra.Controls.Add(this.BtnNovoIten);
            this.GroupBoxCompra.Controls.Add(this.DataGrid);
            this.GroupBoxCompra.Controls.Add(this.LabelQuantidade);
            this.GroupBoxCompra.Controls.Add(this.LabelCodigoProduto);
            this.GroupBoxCompra.ForeColor = System.Drawing.Color.White;
            this.GroupBoxCompra.Location = new System.Drawing.Point(12, 82);
            this.GroupBoxCompra.Name = "GroupBoxCompra";
            this.GroupBoxCompra.Size = new System.Drawing.Size(1277, 708);
            this.GroupBoxCompra.TabIndex = 19;
            this.GroupBoxCompra.TabStop = false;
            this.GroupBoxCompra.Text = "Nova Compra";
            // 
            // TxtBoxSelecionarProduto
            // 
            this.TxtBoxSelecionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxSelecionarProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxSelecionarProduto.ForeColor = System.Drawing.Color.White;
            this.TxtBoxSelecionarProduto.Location = new System.Drawing.Point(168, 25);
            this.TxtBoxSelecionarProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxSelecionarProduto.Name = "TxtBoxSelecionarProduto";
            this.TxtBoxSelecionarProduto.Size = new System.Drawing.Size(238, 31);
            this.TxtBoxSelecionarProduto.TabIndex = 39;
            this.TxtBoxSelecionarProduto.Text = "Selecione o Produto";
            this.TxtBoxSelecionarProduto.Click += new System.EventHandler(this.BtnProcurarProduto_Click);
            // 
            // BtnProcurarProduto
            // 
            this.BtnProcurarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarProduto.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarProduto.Location = new System.Drawing.Point(412, 24);
            this.BtnProcurarProduto.Name = "BtnProcurarProduto";
            this.BtnProcurarProduto.Size = new System.Drawing.Size(125, 29);
            this.BtnProcurarProduto.TabIndex = 38;
            this.BtnProcurarProduto.Text = "Procurar Fornecedor";
            this.BtnProcurarProduto.UseVisualStyleBackColor = false;
            this.BtnProcurarProduto.Click += new System.EventHandler(this.BtnProcurarProduto_Click);
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Location = new System.Drawing.Point(1215, 37);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(17, 20);
            this.LblValorTotal.TabIndex = 37;
            this.LblValorTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(999, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Valor Total Da Compra =";
            // 
            // textBox1TxtBoxPrecoAlterado
            // 
            this.textBox1TxtBoxPrecoAlterado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox1TxtBoxPrecoAlterado.Location = new System.Drawing.Point(755, 76);
            this.textBox1TxtBoxPrecoAlterado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1TxtBoxPrecoAlterado.Name = "textBox1TxtBoxPrecoAlterado";
            this.textBox1TxtBoxPrecoAlterado.Size = new System.Drawing.Size(238, 27);
            this.textBox1TxtBoxPrecoAlterado.TabIndex = 35;
            this.textBox1TxtBoxPrecoAlterado.Visible = false;
            this.textBox1TxtBoxPrecoAlterado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1TxtBoxPrecoAlterado_KeyPress);
            // 
            // CheckPreco
            // 
            this.CheckPreco.AutoSize = true;
            this.CheckPreco.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckPreco.Location = new System.Drawing.Point(538, 76);
            this.CheckPreco.Name = "CheckPreco";
            this.CheckPreco.Size = new System.Drawing.Size(217, 29);
            this.CheckPreco.TabIndex = 34;
            this.CheckPreco.Text = "Alterar Preco Produto";
            this.CheckPreco.UseVisualStyleBackColor = true;
            this.CheckPreco.CheckedChanged += new System.EventHandler(this.CheckPreco_CheckedChanged);
            // 
            // TxtBoxQuantidade
            // 
            this.TxtBoxQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxQuantidade.Location = new System.Drawing.Point(755, 30);
            this.TxtBoxQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxQuantidade.Name = "TxtBoxQuantidade";
            this.TxtBoxQuantidade.Size = new System.Drawing.Size(238, 27);
            this.TxtBoxQuantidade.TabIndex = 10;
            this.TxtBoxQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxQuantidade_KeyPress_1);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(755, 118);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(233, 79);
            this.BtnExcluir.TabIndex = 32;
            this.BtnExcluir.Text = "          Excluir Linha";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Inserir Data";
            // 
            // DateTime
            // 
            this.DateTime.CalendarMonthBackground = System.Drawing.Color.IndianRed;
            this.DateTime.Location = new System.Drawing.Point(173, 130);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(233, 27);
            this.DateTime.TabIndex = 25;
            // 
            // BtnCadastrarCompra
            // 
            this.BtnCadastrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCompra.Location = new System.Drawing.Point(999, 118);
            this.BtnCadastrarCompra.Name = "BtnCadastrarCompra";
            this.BtnCadastrarCompra.Size = new System.Drawing.Size(243, 79);
            this.BtnCadastrarCompra.TabIndex = 24;
            this.BtnCadastrarCompra.Text = "           Cadastrar Entrada";
            this.BtnCadastrarCompra.UseVisualStyleBackColor = false;
            this.BtnCadastrarCompra.Click += new System.EventHandler(this.BtnCadastrarCompra_Click);
            // 
            // CmbFormaPagamento
            // 
            this.CmbFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormaPagamento.FormattingEnabled = true;
            this.CmbFormaPagamento.Location = new System.Drawing.Point(173, 80);
            this.CmbFormaPagamento.Name = "CmbFormaPagamento";
            this.CmbFormaPagamento.Size = new System.Drawing.Size(233, 28);
            this.CmbFormaPagamento.TabIndex = 23;
            // 
            // LabelFormaPagemento
            // 
            this.LabelFormaPagemento.AutoSize = true;
            this.LabelFormaPagemento.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelFormaPagemento.ForeColor = System.Drawing.Color.White;
            this.LabelFormaPagemento.Location = new System.Drawing.Point(15, 82);
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
            this.BtnNovoIten.Location = new System.Drawing.Point(502, 118);
            this.BtnNovoIten.Name = "BtnNovoIten";
            this.BtnNovoIten.Size = new System.Drawing.Size(238, 79);
            this.BtnNovoIten.TabIndex = 21;
            this.BtnNovoIten.Text = "        Novo Item";
            this.BtnNovoIten.UseVisualStyleBackColor = false;
            this.BtnNovoIten.Click += new System.EventHandler(this.BtnNovoIten_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridProduto,
            this.DataGridValorUnitario,
            this.DataGridQuantidade,
            this.DatagridValorTotal,
            this.DataGridFormaPAgamento,
            this.DataGridFuncionario,
            this.DataGridFornecedor,
            this.DatagridData});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.Location = new System.Drawing.Point(6, 203);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 29;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1250, 487);
            this.DataGrid.TabIndex = 20;
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelQuantidade.ForeColor = System.Drawing.Color.White;
            this.LabelQuantidade.Location = new System.Drawing.Point(612, 31);
            this.LabelQuantidade.Name = "LabelQuantidade";
            this.LabelQuantidade.Size = new System.Drawing.Size(100, 23);
            this.LabelQuantidade.TabIndex = 16;
            this.LabelQuantidade.Text = "Quantidade";
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
            // BtnNovoProduto
            // 
            this.BtnNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnNovoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoProduto.ForeColor = System.Drawing.Color.White;
            this.BtnNovoProduto.Location = new System.Drawing.Point(85, 47);
            this.BtnNovoProduto.Name = "BtnNovoProduto";
            this.BtnNovoProduto.Size = new System.Drawing.Size(158, 29);
            this.BtnNovoProduto.TabIndex = 17;
            this.BtnNovoProduto.Text = "Novo Produto";
            this.BtnNovoProduto.UseVisualStyleBackColor = false;
            this.BtnNovoProduto.Click += new System.EventHandler(this.BtnNovoProduto_Click);
            // 
            // LabelNomeCLiente
            // 
            this.LabelNomeCLiente.AutoSize = true;
            this.LabelNomeCLiente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNomeCLiente.ForeColor = System.Drawing.Color.White;
            this.LabelNomeCLiente.Location = new System.Drawing.Point(452, 47);
            this.LabelNomeCLiente.Name = "LabelNomeCLiente";
            this.LabelNomeCLiente.Size = new System.Drawing.Size(149, 23);
            this.LabelNomeCLiente.TabIndex = 18;
            this.LabelNomeCLiente.Text = "Nome Fornecedor";
            // 
            // ImageBtnFechar
            // 
            this.ImageBtnFechar.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.ImageBtnFechar.Location = new System.Drawing.Point(1210, 3);
            this.ImageBtnFechar.Name = "ImageBtnFechar";
            this.ImageBtnFechar.Size = new System.Drawing.Size(68, 28);
            this.ImageBtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtnFechar.TabIndex = 105;
            this.ImageBtnFechar.TabStop = false;
            this.ImageBtnFechar.Click += new System.EventHandler(this.ImageBtnFechar_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblText.ForeColor = System.Drawing.Color.White;
            this.LblText.Location = new System.Drawing.Point(471, 3);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(147, 23);
            this.LblText.TabIndex = 104;
            this.LblText.Text = "Cadastrar Entrada";
            // 
            // TxtBoxSelecionarFornecedor
            // 
            this.TxtBoxSelecionarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxSelecionarFornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxSelecionarFornecedor.ForeColor = System.Drawing.Color.White;
            this.TxtBoxSelecionarFornecedor.Location = new System.Drawing.Point(617, 43);
            this.TxtBoxSelecionarFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxSelecionarFornecedor.Name = "TxtBoxSelecionarFornecedor";
            this.TxtBoxSelecionarFornecedor.Size = new System.Drawing.Size(238, 31);
            this.TxtBoxSelecionarFornecedor.TabIndex = 106;
            this.TxtBoxSelecionarFornecedor.Text = "Selecione o Fornecedor";
            this.TxtBoxSelecionarFornecedor.Click += new System.EventHandler(this.BtnProcurarFornecedor_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox4.Image = global::WfPresentationLayer.Properties.Resources.icons8_money_80;
            this.pictureBox4.Location = new System.Drawing.Point(1011, 130);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 109;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox3.Image = global::WfPresentationLayer.Properties.Resources.delete_sign1;
            this.pictureBox3.Location = new System.Drawing.Point(766, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 108;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox2.Image = global::WfPresentationLayer.Properties.Resources.icons8_add_shopping_cart_80;
            this.pictureBox2.Location = new System.Drawing.Point(516, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // DataGridProduto
            // 
            this.DataGridProduto.HeaderText = "Produto";
            this.DataGridProduto.MinimumWidth = 6;
            this.DataGridProduto.Name = "DataGridProduto";
            this.DataGridProduto.ReadOnly = true;
            this.DataGridProduto.Width = 125;
            // 
            // DataGridValorUnitario
            // 
            this.DataGridValorUnitario.HeaderText = "Valor ";
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
            this.DataGridQuantidade.Width = 140;
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
            // DatagridData
            // 
            this.DatagridData.HeaderText = "Data";
            this.DatagridData.MinimumWidth = 6;
            this.DatagridData.Name = "DatagridData";
            this.DatagridData.ReadOnly = true;
            this.DatagridData.Width = 125;
            // 
            // FormNovaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1299, 802);
            this.Controls.Add(this.TxtBoxSelecionarFornecedor);
            this.Controls.Add(this.ImageBtnFechar);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.BtnNovoFornecedor);
            this.Controls.Add(this.BtnProcurarFornecedor);
            this.Controls.Add(this.GroupBoxCompra);
            this.Controls.Add(this.LabelNomeCLiente);
            this.Controls.Add(this.BtnNovoProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNovaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNovaCompra";
            this.Load += new System.EventHandler(this.FormNovaCompra_Load);
            this.GroupBoxCompra.ResumeLayout(false);
            this.GroupBoxCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Button BtnNovoIten;
        private DataGridView DataGrid;
        private Label LabelQuantidade;
        private Label LabelCodigoProduto;
        private Label LabelNomeCLiente;
        private Label label2;
        private Button BtnExcluir;
        private TextBox TxtBoxQuantidade;
        private ComboBox CmbFormaPagamento;
        private Label LabelFormaPagemento;
        private CheckBox CheckPreco;
        private TextBox textBox1TxtBoxPrecoAlterado;
        private PictureBox ImageBtnFechar;
        private Label LblText;
        private Label LblValorTotal;
        private Label label1;
        private Button BtnProcurarProduto;
        private TextBox TxtBoxSelecionarProduto;
        private TextBox TxtBoxSelecionarFornecedor;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn DataGridProduto;
        private DataGridViewTextBoxColumn DataGridValorUnitario;
        private DataGridViewTextBoxColumn DataGridQuantidade;
        private DataGridViewTextBoxColumn DatagridValorTotal;
        private DataGridViewTextBoxColumn DataGridFormaPAgamento;
        private DataGridViewTextBoxColumn DataGridFuncionario;
        private DataGridViewTextBoxColumn DataGridFornecedor;
        private DataGridViewTextBoxColumn DatagridData;
    }
}