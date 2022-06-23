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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelNomeCLiente = new System.Windows.Forms.Label();
            this.TxtBoxSelecionarCliente = new System.Windows.Forms.TextBox();
            this.GroupBoxVenda = new System.Windows.Forms.GroupBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.CmbBoxLaboratorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.BtnCadastrarNovaVenda = new System.Windows.Forms.Button();
            this.CmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.LabelFormaPagemento = new System.Windows.Forms.Label();
            this.BtnNovoIten = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.DataGridProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.LabelValorUnitario = new System.Windows.Forms.Label();
            this.TxtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.TxtBoxCodigoProdutoVenda = new System.Windows.Forms.TextBox();
            this.LabelCodigoProduto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnNovoCliente = new System.Windows.Forms.Button();
            this.GroupBoxVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNomeCLiente
            // 
            this.LabelNomeCLiente.AutoSize = true;
            this.LabelNomeCLiente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNomeCLiente.ForeColor = System.Drawing.Color.White;
            this.LabelNomeCLiente.Location = new System.Drawing.Point(381, 15);
            this.LabelNomeCLiente.Name = "LabelNomeCLiente";
            this.LabelNomeCLiente.Size = new System.Drawing.Size(115, 23);
            this.LabelNomeCLiente.TabIndex = 13;
            this.LabelNomeCLiente.Text = "Nome Cliente";
            // 
            // TxtBoxSelecionarCliente
            // 
            this.TxtBoxSelecionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxSelecionarCliente.Location = new System.Drawing.Point(502, 13);
            this.TxtBoxSelecionarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxSelecionarCliente.Name = "TxtBoxSelecionarCliente";
            this.TxtBoxSelecionarCliente.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxSelecionarCliente.TabIndex = 12;
            // 
            // GroupBoxVenda
            // 
            this.GroupBoxVenda.Controls.Add(this.BtnExcluir);
            this.GroupBoxVenda.Controls.Add(this.CmbBoxLaboratorio);
            this.GroupBoxVenda.Controls.Add(this.label1);
            this.GroupBoxVenda.Controls.Add(this.DateTime);
            this.GroupBoxVenda.Controls.Add(this.BtnCadastrarNovaVenda);
            this.GroupBoxVenda.Controls.Add(this.CmbFormaPagamento);
            this.GroupBoxVenda.Controls.Add(this.LabelFormaPagemento);
            this.GroupBoxVenda.Controls.Add(this.BtnNovoIten);
            this.GroupBoxVenda.Controls.Add(this.DataGrid);
            this.GroupBoxVenda.Controls.Add(this.TxtBoxValorUnitario);
            this.GroupBoxVenda.Controls.Add(this.LabelValorUnitario);
            this.GroupBoxVenda.Controls.Add(this.TxtBoxQuantidade);
            this.GroupBoxVenda.Controls.Add(this.LabelQuantidade);
            this.GroupBoxVenda.Controls.Add(this.TxtBoxCodigoProdutoVenda);
            this.GroupBoxVenda.Controls.Add(this.LabelCodigoProduto);
            this.GroupBoxVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxVenda.ForeColor = System.Drawing.Color.White;
            this.GroupBoxVenda.Location = new System.Drawing.Point(12, 54);
            this.GroupBoxVenda.Name = "GroupBoxVenda";
            this.GroupBoxVenda.Size = new System.Drawing.Size(1180, 713);
            this.GroupBoxVenda.TabIndex = 14;
            this.GroupBoxVenda.TabStop = false;
            this.GroupBoxVenda.Text = "Nova venda";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(711, 126);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(200, 79);
            this.BtnExcluir.TabIndex = 28;
            this.BtnExcluir.Text = "Excluir Linha";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // CmbBoxLaboratorio
            // 
            this.CmbBoxLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmbBoxLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxLaboratorio.FormattingEnabled = true;
            this.CmbBoxLaboratorio.Location = new System.Drawing.Point(167, 123);
            this.CmbBoxLaboratorio.Name = "CmbBoxLaboratorio";
            this.CmbBoxLaboratorio.Size = new System.Drawing.Size(233, 31);
            this.CmbBoxLaboratorio.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Laboratorio";
            // 
            // DateTime
            // 
            this.DateTime.CalendarMonthBackground = System.Drawing.Color.IndianRed;
            this.DateTime.Location = new System.Drawing.Point(76, 175);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(324, 30);
            this.DateTime.TabIndex = 25;
            // 
            // BtnCadastrarNovaVenda
            // 
            this.BtnCadastrarNovaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarNovaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarNovaVenda.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarNovaVenda.Location = new System.Drawing.Point(930, 126);
            this.BtnCadastrarNovaVenda.Name = "BtnCadastrarNovaVenda";
            this.BtnCadastrarNovaVenda.Size = new System.Drawing.Size(240, 79);
            this.BtnCadastrarNovaVenda.TabIndex = 24;
            this.BtnCadastrarNovaVenda.Text = "Cadastrar Venda";
            this.BtnCadastrarNovaVenda.UseVisualStyleBackColor = false;
            this.BtnCadastrarNovaVenda.Click += new System.EventHandler(this.BtnCadastrarNovaVenda_Click);
            // 
            // CmbFormaPagamento
            // 
            this.CmbFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormaPagamento.FormattingEnabled = true;
            this.CmbFormaPagamento.Location = new System.Drawing.Point(167, 69);
            this.CmbFormaPagamento.Name = "CmbFormaPagamento";
            this.CmbFormaPagamento.Size = new System.Drawing.Size(233, 31);
            this.CmbFormaPagamento.TabIndex = 23;
            // 
            // LabelFormaPagemento
            // 
            this.LabelFormaPagemento.AutoSize = true;
            this.LabelFormaPagemento.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelFormaPagemento.ForeColor = System.Drawing.Color.White;
            this.LabelFormaPagemento.Location = new System.Drawing.Point(9, 81);
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
            this.BtnNovoIten.Location = new System.Drawing.Point(416, 126);
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
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridProduto,
            this.DataGridValorUnitario,
            this.DatagridQuantidade,
            this.DataGridValorTotal,
            this.DataGridLaboratorio,
            this.DataGridNomeCliente,
            this.DataGridFuncionario,
            this.DataGridData});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.Location = new System.Drawing.Point(18, 221);
            this.DataGrid.Name = "DataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 29;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1152, 476);
            this.DataGrid.TabIndex = 20;
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
            this.DataGridValorUnitario.HeaderText = "Valor Unitario";
            this.DataGridValorUnitario.MinimumWidth = 50;
            this.DataGridValorUnitario.Name = "DataGridValorUnitario";
            this.DataGridValorUnitario.ReadOnly = true;
            this.DataGridValorUnitario.Width = 150;
            // 
            // DatagridQuantidade
            // 
            this.DatagridQuantidade.HeaderText = "Quantidade";
            this.DatagridQuantidade.MinimumWidth = 6;
            this.DatagridQuantidade.Name = "DatagridQuantidade";
            this.DatagridQuantidade.ReadOnly = true;
            this.DatagridQuantidade.Width = 120;
            // 
            // DataGridValorTotal
            // 
            this.DataGridValorTotal.HeaderText = "Valor Total";
            this.DataGridValorTotal.MinimumWidth = 6;
            this.DataGridValorTotal.Name = "DataGridValorTotal";
            this.DataGridValorTotal.ReadOnly = true;
            this.DataGridValorTotal.Width = 125;
            // 
            // DataGridLaboratorio
            // 
            this.DataGridLaboratorio.HeaderText = "Laboratorio";
            this.DataGridLaboratorio.MinimumWidth = 6;
            this.DataGridLaboratorio.Name = "DataGridLaboratorio";
            this.DataGridLaboratorio.ReadOnly = true;
            this.DataGridLaboratorio.Width = 125;
            // 
            // DataGridNomeCliente
            // 
            this.DataGridNomeCliente.HeaderText = "Nome Cliente";
            this.DataGridNomeCliente.MinimumWidth = 6;
            this.DataGridNomeCliente.Name = "DataGridNomeCliente";
            this.DataGridNomeCliente.ReadOnly = true;
            this.DataGridNomeCliente.Width = 145;
            // 
            // DataGridFuncionario
            // 
            this.DataGridFuncionario.HeaderText = "Funcionario";
            this.DataGridFuncionario.MinimumWidth = 6;
            this.DataGridFuncionario.Name = "DataGridFuncionario";
            this.DataGridFuncionario.ReadOnly = true;
            this.DataGridFuncionario.Width = 125;
            // 
            // DataGridData
            // 
            this.DataGridData.HeaderText = "DIa";
            this.DataGridData.MinimumWidth = 6;
            this.DataGridData.Name = "DataGridData";
            this.DataGridData.ReadOnly = true;
            this.DataGridData.Width = 125;
            // 
            // TxtBoxValorUnitario
            // 
            this.TxtBoxValorUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxValorUnitario.Location = new System.Drawing.Point(785, 76);
            this.TxtBoxValorUnitario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxValorUnitario.Name = "TxtBoxValorUnitario";
            this.TxtBoxValorUnitario.Size = new System.Drawing.Size(203, 30);
            this.TxtBoxValorUnitario.TabIndex = 19;
            // 
            // LabelValorUnitario
            // 
            this.LabelValorUnitario.AutoSize = true;
            this.LabelValorUnitario.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelValorUnitario.ForeColor = System.Drawing.Color.White;
            this.LabelValorUnitario.Location = new System.Drawing.Point(654, 79);
            this.LabelValorUnitario.Name = "LabelValorUnitario";
            this.LabelValorUnitario.Size = new System.Drawing.Size(115, 23);
            this.LabelValorUnitario.TabIndex = 18;
            this.LabelValorUnitario.Text = "Valor Unitario";
            // 
            // TxtBoxQuantidade
            // 
            this.TxtBoxQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxQuantidade.Location = new System.Drawing.Point(785, 20);
            this.TxtBoxQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxQuantidade.Name = "TxtBoxQuantidade";
            this.TxtBoxQuantidade.Size = new System.Drawing.Size(203, 30);
            this.TxtBoxQuantidade.TabIndex = 17;
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelQuantidade.ForeColor = System.Drawing.Color.White;
            this.LabelQuantidade.Location = new System.Drawing.Point(669, 26);
            this.LabelQuantidade.Name = "LabelQuantidade";
            this.LabelQuantidade.Size = new System.Drawing.Size(100, 23);
            this.LabelQuantidade.TabIndex = 16;
            this.LabelQuantidade.Text = "Quantidade";
            // 
            // TxtBoxCodigoProdutoVenda
            // 
            this.TxtBoxCodigoProdutoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxCodigoProdutoVenda.Location = new System.Drawing.Point(167, 21);
            this.TxtBoxCodigoProdutoVenda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxCodigoProdutoVenda.Name = "TxtBoxCodigoProdutoVenda";
            this.TxtBoxCodigoProdutoVenda.Size = new System.Drawing.Size(233, 30);
            this.TxtBoxCodigoProdutoVenda.TabIndex = 15;
            // 
            // LabelCodigoProduto
            // 
            this.LabelCodigoProduto.AutoSize = true;
            this.LabelCodigoProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelCodigoProduto.ForeColor = System.Drawing.Color.White;
            this.LabelCodigoProduto.Location = new System.Drawing.Point(18, 23);
            this.LabelCodigoProduto.Name = "LabelCodigoProduto";
            this.LabelCodigoProduto.Size = new System.Drawing.Size(132, 23);
            this.LabelCodigoProduto.TabIndex = 14;
            this.LabelCodigoProduto.Text = "Codigo Produto";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(723, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Procurar Cliente";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnNovoCliente
            // 
            this.BtnNovoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNovoCliente.ForeColor = System.Drawing.Color.White;
            this.BtnNovoCliente.Location = new System.Drawing.Point(245, 13);
            this.BtnNovoCliente.Name = "BtnNovoCliente";
            this.BtnNovoCliente.Size = new System.Drawing.Size(130, 29);
            this.BtnNovoCliente.TabIndex = 16;
            this.BtnNovoCliente.Text = "Novo Cliente";
            this.BtnNovoCliente.UseVisualStyleBackColor = false;
            this.BtnNovoCliente.Click += new System.EventHandler(this.BtnNovoCliente_Click);
            // 
            // FormNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1204, 779);
            this.Controls.Add(this.BtnNovoCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GroupBoxVenda);
            this.Controls.Add(this.LabelNomeCLiente);
            this.Controls.Add(this.TxtBoxSelecionarCliente);
            this.Name = "FormNovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNovaVenda";
            this.GroupBoxVenda.ResumeLayout(false);
            this.GroupBoxVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNomeCLiente;
        private TextBox TxtBoxSelecionarCliente;
        private GroupBox GroupBoxVenda;
        private DataGridView DataGrid;
        private TextBox TxtBoxValorUnitario;
        private Label LabelValorUnitario;
        private TextBox TxtBoxQuantidade;
        private Label LabelQuantidade;
        private TextBox TxtBoxCodigoProdutoVenda;
        private Label LabelCodigoProduto;
        private Label LabelFormaPagemento;
        private Button BtnNovoIten;
        private ComboBox CmbFormaPagamento;
        private Button button2;
        private Button BtnNovoCliente;
        private Button BtnCadastrarNovaVenda;
        private DateTimePicker DateTime;
        private ComboBox CmbBoxLaboratorio;
        private Label label1;
        private Button BtnExcluir;
        private DataGridViewTextBoxColumn DataGridProduto;
        private DataGridViewTextBoxColumn DataGridValorUnitario;
        private DataGridViewTextBoxColumn DatagridQuantidade;
        private DataGridViewTextBoxColumn DataGridValorTotal;
        private DataGridViewTextBoxColumn DataGridLaboratorio;
        private DataGridViewTextBoxColumn DataGridNomeCliente;
        private DataGridViewTextBoxColumn DataGridFuncionario;
        private DataGridViewTextBoxColumn DataGridData;
    }
}