namespace WfPresentationLayer
{
    partial class FormNovaVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelNomeCLiente = new System.Windows.Forms.Label();
            this.TxtBoxSelecionarCliente = new System.Windows.Forms.TextBox();
            this.GroupBoxVenda = new System.Windows.Forms.GroupBox();
            this.BtnNovaVenda = new System.Windows.Forms.Button();
            this.BtnNovoProduto = new System.Windows.Forms.Button();
            this.CmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.LabelFormaPagemento = new System.Windows.Forms.Label();
            this.BtnNovoIten = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodigoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.LabelValorUnitario = new System.Windows.Forms.Label();
            this.TxtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.TxtBoxCodigoProdutoVenda = new System.Windows.Forms.TextBox();
            this.LabelCodigoProduto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnNovoCliente = new System.Windows.Forms.Button();
            this.GroupBoxVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNomeCLiente
            // 
            this.LabelNomeCLiente.AutoSize = true;
            this.LabelNomeCLiente.Location = new System.Drawing.Point(258, 9);
            this.LabelNomeCLiente.Name = "LabelNomeCLiente";
            this.LabelNomeCLiente.Size = new System.Drawing.Size(100, 20);
            this.LabelNomeCLiente.TabIndex = 13;
            this.LabelNomeCLiente.Text = "Nome Cliente";
            // 
            // TxtBoxSelecionarCliente
            // 
            this.TxtBoxSelecionarCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxSelecionarCliente.Location = new System.Drawing.Point(364, 6);
            this.TxtBoxSelecionarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxSelecionarCliente.Name = "TxtBoxSelecionarCliente";
            this.TxtBoxSelecionarCliente.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxSelecionarCliente.TabIndex = 12;
            // 
            // GroupBoxVenda
            // 
            this.GroupBoxVenda.Controls.Add(this.BtnNovaVenda);
            this.GroupBoxVenda.Controls.Add(this.BtnNovoProduto);
            this.GroupBoxVenda.Controls.Add(this.CmbFormaPagamento);
            this.GroupBoxVenda.Controls.Add(this.LabelFormaPagemento);
            this.GroupBoxVenda.Controls.Add(this.BtnNovoIten);
            this.GroupBoxVenda.Controls.Add(this.dataGridView1);
            this.GroupBoxVenda.Controls.Add(this.TxtBoxValorUnitario);
            this.GroupBoxVenda.Controls.Add(this.LabelValorUnitario);
            this.GroupBoxVenda.Controls.Add(this.TxtBoxQuantidade);
            this.GroupBoxVenda.Controls.Add(this.LabelQuantidade);
            this.GroupBoxVenda.Controls.Add(this.TxtBoxCodigoProdutoVenda);
            this.GroupBoxVenda.Controls.Add(this.LabelCodigoProduto);
            this.GroupBoxVenda.Location = new System.Drawing.Point(1, 47);
            this.GroupBoxVenda.Name = "GroupBoxVenda";
            this.GroupBoxVenda.Size = new System.Drawing.Size(990, 614);
            this.GroupBoxVenda.TabIndex = 14;
            this.GroupBoxVenda.TabStop = false;
            this.GroupBoxVenda.Text = "Nova venda";
            // 
            // BtnNovaVenda
            // 
            this.BtnNovaVenda.Location = new System.Drawing.Point(668, 80);
            this.BtnNovaVenda.Name = "BtnNovaVenda";
            this.BtnNovaVenda.Size = new System.Drawing.Size(277, 79);
            this.BtnNovaVenda.TabIndex = 24;
            this.BtnNovaVenda.Text = "Cadastrar Venda";
            this.BtnNovaVenda.UseVisualStyleBackColor = true;
            // 
            // BtnNovoProduto
            // 
            this.BtnNovoProduto.Location = new System.Drawing.Point(351, 23);
            this.BtnNovoProduto.Name = "BtnNovoProduto";
            this.BtnNovoProduto.Size = new System.Drawing.Size(158, 29);
            this.BtnNovoProduto.TabIndex = 17;
            this.BtnNovoProduto.Text = "Novo Produto";
            this.BtnNovoProduto.UseVisualStyleBackColor = true;
            this.BtnNovoProduto.Click += new System.EventHandler(this.BtnNovoProduto_Click);
            // 
            // CmbFormaPagamento
            // 
            this.CmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormaPagamento.FormattingEnabled = true;
            this.CmbFormaPagamento.Location = new System.Drawing.Point(692, 27);
            this.CmbFormaPagamento.Name = "CmbFormaPagamento";
            this.CmbFormaPagamento.Size = new System.Drawing.Size(233, 28);
            this.CmbFormaPagamento.TabIndex = 23;
            // 
            // LabelFormaPagemento
            // 
            this.LabelFormaPagemento.AutoSize = true;
            this.LabelFormaPagemento.Location = new System.Drawing.Point(556, 30);
            this.LabelFormaPagemento.Name = "LabelFormaPagemento";
            this.LabelFormaPagemento.Size = new System.Drawing.Size(130, 20);
            this.LabelFormaPagemento.TabIndex = 22;
            this.LabelFormaPagemento.Text = "Forma Pagamento";
            // 
            // BtnNovoIten
            // 
            this.BtnNovoIten.Location = new System.Drawing.Point(363, 80);
            this.BtnNovoIten.Name = "BtnNovoIten";
            this.BtnNovoIten.Size = new System.Drawing.Size(277, 79);
            this.BtnNovoIten.TabIndex = 21;
            this.BtnNovoIten.Text = "Novo Item";
            this.BtnNovoIten.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoProduto,
            this.Quantidade,
            this.ValorUnitario,
            this.ValorTotal,
            this.FormaPagamento});
            this.dataGridView1.Location = new System.Drawing.Point(11, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(960, 426);
            this.dataGridView1.TabIndex = 20;
            // 
            // CodigoProduto
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CodigoProduto.DefaultCellStyle = dataGridViewCellStyle6;
            this.CodigoProduto.HeaderText = "Codigo Produto";
            this.CodigoProduto.MinimumWidth = 6;
            this.CodigoProduto.Name = "CodigoProduto";
            this.CodigoProduto.Width = 150;
            // 
            // Quantidade
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantidade.DefaultCellStyle = dataGridViewCellStyle7;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.MinimumWidth = 6;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 115;
            // 
            // ValorUnitario
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ValorUnitario.DefaultCellStyle = dataGridViewCellStyle8;
            this.ValorUnitario.HeaderText = "Valor Unitario";
            this.ValorUnitario.MinimumWidth = 6;
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.Width = 130;
            // 
            // ValorTotal
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ValorTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.ValorTotal.HeaderText = "Forma Pagamento";
            this.ValorTotal.MinimumWidth = 6;
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 180;
            // 
            // FormaPagamento
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FormaPagamento.DefaultCellStyle = dataGridViewCellStyle10;
            this.FormaPagamento.HeaderText = "Valor Total";
            this.FormaPagamento.MinimumWidth = 6;
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.Width = 150;
            // 
            // TxtBoxValorUnitario
            // 
            this.TxtBoxValorUnitario.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxValorUnitario.Location = new System.Drawing.Point(132, 132);
            this.TxtBoxValorUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxValorUnitario.Name = "TxtBoxValorUnitario";
            this.TxtBoxValorUnitario.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxValorUnitario.TabIndex = 19;
            // 
            // LabelValorUnitario
            // 
            this.LabelValorUnitario.AutoSize = true;
            this.LabelValorUnitario.Location = new System.Drawing.Point(11, 135);
            this.LabelValorUnitario.Name = "LabelValorUnitario";
            this.LabelValorUnitario.Size = new System.Drawing.Size(100, 20);
            this.LabelValorUnitario.TabIndex = 18;
            this.LabelValorUnitario.Text = "Valor Unitario";
            // 
            // TxtBoxQuantidade
            // 
            this.TxtBoxQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxQuantidade.Location = new System.Drawing.Point(132, 80);
            this.TxtBoxQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxQuantidade.Name = "TxtBoxQuantidade";
            this.TxtBoxQuantidade.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxQuantidade.TabIndex = 17;
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.Location = new System.Drawing.Point(6, 80);
            this.LabelQuantidade.Name = "LabelQuantidade";
            this.LabelQuantidade.Size = new System.Drawing.Size(87, 20);
            this.LabelQuantidade.TabIndex = 16;
            this.LabelQuantidade.Text = "Quantidade";
            // 
            // TxtBoxCodigoProdutoVenda
            // 
            this.TxtBoxCodigoProdutoVenda.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxCodigoProdutoVenda.Location = new System.Drawing.Point(132, 27);
            this.TxtBoxCodigoProdutoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxCodigoProdutoVenda.Name = "TxtBoxCodigoProdutoVenda";
            this.TxtBoxCodigoProdutoVenda.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxCodigoProdutoVenda.TabIndex = 15;
            // 
            // LabelCodigoProduto
            // 
            this.LabelCodigoProduto.AutoSize = true;
            this.LabelCodigoProduto.Location = new System.Drawing.Point(6, 27);
            this.LabelCodigoProduto.Name = "LabelCodigoProduto";
            this.LabelCodigoProduto.Size = new System.Drawing.Size(115, 20);
            this.LabelCodigoProduto.TabIndex = 14;
            this.LabelCodigoProduto.Text = "Codigo Produto";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Procurar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnNovoCliente
            // 
            this.BtnNovoCliente.Location = new System.Drawing.Point(122, 6);
            this.BtnNovoCliente.Name = "BtnNovoCliente";
            this.BtnNovoCliente.Size = new System.Drawing.Size(130, 29);
            this.BtnNovoCliente.TabIndex = 16;
            this.BtnNovoCliente.Text = "Novo Cliente";
            this.BtnNovoCliente.UseVisualStyleBackColor = true;
            this.BtnNovoCliente.Click += new System.EventHandler(this.BtnNovoCliente_Click);
            // 
            // FormNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 673);
            this.Controls.Add(this.BtnNovoCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GroupBoxVenda);
            this.Controls.Add(this.LabelNomeCLiente);
            this.Controls.Add(this.TxtBoxSelecionarCliente);
            this.Name = "FormNovaVenda";
            this.Text = "FormNovaVenda";
            this.GroupBoxVenda.ResumeLayout(false);
            this.GroupBoxVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNomeCLiente;
        private TextBox TxtBoxSelecionarCliente;
        private GroupBox GroupBoxVenda;
        private DataGridView dataGridView1;
        private TextBox TxtBoxValorUnitario;
        private Label LabelValorUnitario;
        private TextBox TxtBoxQuantidade;
        private Label LabelQuantidade;
        private TextBox TxtBoxCodigoProdutoVenda;
        private Label LabelCodigoProduto;
        private Label LabelFormaPagemento;
        private Button BtnNovoIten;
        private ComboBox CmbFormaPagamento;
        private DataGridViewTextBoxColumn CodigoProduto;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn ValorUnitario;
        private DataGridViewTextBoxColumn ValorTotal;
        private DataGridViewTextBoxColumn FormaPagamento;
        private Button button2;
        private Button BtnNovoCliente;
        private Button BtnNovoProduto;
        private Button BtnNovaVenda;
    }
}