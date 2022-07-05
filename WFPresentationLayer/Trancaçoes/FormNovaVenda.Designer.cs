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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabelNomeCLiente = new System.Windows.Forms.Label();
            this.GroupBoxVenda = new System.Windows.Forms.GroupBox();
            this.CmbBoxProduto = new System.Windows.Forms.ComboBox();
            this.TxtBoxQuantidade = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.BtnCadastrarNovaVenda = new System.Windows.Forms.Button();
            this.CmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.LabelFormaPagemento = new System.Windows.Forms.Label();
            this.BtnNovoIten = new System.Windows.Forms.Button();
            this.LabelQuantidade = new System.Windows.Forms.Label();
            this.LabelCodigoProduto = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.DataGridProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatagridQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnNovoCliente = new System.Windows.Forms.Button();
            this.CmbBoxClientes = new System.Windows.Forms.ComboBox();
            this.ImageBtnFechar = new System.Windows.Forms.PictureBox();
            this.LblText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.GroupBoxVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNomeCLiente
            // 
            this.LabelNomeCLiente.AutoSize = true;
            this.LabelNomeCLiente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNomeCLiente.ForeColor = System.Drawing.Color.White;
            this.LabelNomeCLiente.Location = new System.Drawing.Point(445, 73);
            this.LabelNomeCLiente.Name = "LabelNomeCLiente";
            this.LabelNomeCLiente.Size = new System.Drawing.Size(115, 23);
            this.LabelNomeCLiente.TabIndex = 13;
            this.LabelNomeCLiente.Text = "Nome Cliente";
            // 
            // GroupBoxVenda
            // 
            this.GroupBoxVenda.Controls.Add(this.LblValorTotal);
            this.GroupBoxVenda.Controls.Add(this.label1);
            this.GroupBoxVenda.Controls.Add(this.CmbBoxProduto);
            this.GroupBoxVenda.Controls.Add(this.TxtBoxQuantidade);
            this.GroupBoxVenda.Controls.Add(this.BtnExcluir);
            this.GroupBoxVenda.Controls.Add(this.DateTime);
            this.GroupBoxVenda.Controls.Add(this.BtnCadastrarNovaVenda);
            this.GroupBoxVenda.Controls.Add(this.CmbFormaPagamento);
            this.GroupBoxVenda.Controls.Add(this.LabelFormaPagemento);
            this.GroupBoxVenda.Controls.Add(this.BtnNovoIten);
            this.GroupBoxVenda.Controls.Add(this.LabelQuantidade);
            this.GroupBoxVenda.Controls.Add(this.LabelCodigoProduto);
            this.GroupBoxVenda.Controls.Add(this.DataGrid);
            this.GroupBoxVenda.Controls.Add(this.pictureBox1);
            this.GroupBoxVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxVenda.ForeColor = System.Drawing.Color.White;
            this.GroupBoxVenda.Location = new System.Drawing.Point(9, 105);
            this.GroupBoxVenda.Name = "GroupBoxVenda";
            this.GroupBoxVenda.Size = new System.Drawing.Size(1274, 707);
            this.GroupBoxVenda.TabIndex = 14;
            this.GroupBoxVenda.TabStop = false;
            this.GroupBoxVenda.Text = "Nova venda";
            // 
            // CmbBoxProduto
            // 
            this.CmbBoxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxProduto.FormattingEnabled = true;
            this.CmbBoxProduto.Location = new System.Drawing.Point(167, 29);
            this.CmbBoxProduto.Name = "CmbBoxProduto";
            this.CmbBoxProduto.Size = new System.Drawing.Size(233, 31);
            this.CmbBoxProduto.TabIndex = 32;
            // 
            // TxtBoxQuantidade
            // 
            this.TxtBoxQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxQuantidade.Location = new System.Drawing.Point(561, 30);
            this.TxtBoxQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxQuantidade.Name = "TxtBoxQuantidade";
            this.TxtBoxQuantidade.Size = new System.Drawing.Size(238, 30);
            this.TxtBoxQuantidade.TabIndex = 29;
            this.TxtBoxQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBoxQuantidade_KeyPress);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(775, 126);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(200, 79);
            this.BtnExcluir.TabIndex = 28;
            this.BtnExcluir.Text = "Excluir Linha";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
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
            this.BtnCadastrarNovaVenda.Location = new System.Drawing.Point(994, 126);
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
            this.CmbFormaPagamento.Location = new System.Drawing.Point(167, 79);
            this.CmbFormaPagamento.Name = "CmbFormaPagamento";
            this.CmbFormaPagamento.Size = new System.Drawing.Size(233, 31);
            this.CmbFormaPagamento.TabIndex = 4;
            // 
            // LabelFormaPagemento
            // 
            this.LabelFormaPagemento.AutoSize = true;
            this.LabelFormaPagemento.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelFormaPagemento.ForeColor = System.Drawing.Color.White;
            this.LabelFormaPagemento.Location = new System.Drawing.Point(9, 87);
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
            this.BtnNovoIten.Location = new System.Drawing.Point(480, 126);
            this.BtnNovoIten.Name = "BtnNovoIten";
            this.BtnNovoIten.Size = new System.Drawing.Size(277, 79);
            this.BtnNovoIten.TabIndex = 21;
            this.BtnNovoIten.Text = "Novo Item";
            this.BtnNovoIten.UseVisualStyleBackColor = false;
            this.BtnNovoIten.Click += new System.EventHandler(this.BtnNovoIten_Click);
            // 
            // LabelQuantidade
            // 
            this.LabelQuantidade.AutoSize = true;
            this.LabelQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelQuantidade.ForeColor = System.Drawing.Color.White;
            this.LabelQuantidade.Location = new System.Drawing.Point(436, 35);
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
            this.LabelCodigoProduto.Location = new System.Drawing.Point(18, 29);
            this.LabelCodigoProduto.Name = "LabelCodigoProduto";
            this.LabelCodigoProduto.Size = new System.Drawing.Size(132, 23);
            this.LabelCodigoProduto.TabIndex = 14;
            this.LabelCodigoProduto.Text = "Codigo Produto";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridProduto,
            this.DataGridValorUnitario,
            this.DatagridQuantidade,
            this.DataGridValorTotal,
            this.DataGridNomeCliente,
            this.DataGridFuncionario,
            this.DataGridData});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.Location = new System.Drawing.Point(18, 222);
            this.DataGrid.Name = "DataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 29;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1232, 469);
            this.DataGrid.TabIndex = 20;
            // 
            // DataGridProduto
            // 
            this.DataGridProduto.HeaderText = "Produto";
            this.DataGridProduto.MinimumWidth = 6;
            this.DataGridProduto.Name = "DataGridProduto";
            this.DataGridProduto.Width = 125;
            // 
            // DataGridValorUnitario
            // 
            this.DataGridValorUnitario.HeaderText = "Valor Unitario";
            this.DataGridValorUnitario.MinimumWidth = 50;
            this.DataGridValorUnitario.Name = "DataGridValorUnitario";
            this.DataGridValorUnitario.Width = 150;
            // 
            // DatagridQuantidade
            // 
            this.DatagridQuantidade.HeaderText = "Quantidade";
            this.DatagridQuantidade.MinimumWidth = 6;
            this.DatagridQuantidade.Name = "DatagridQuantidade";
            this.DatagridQuantidade.Width = 130;
            // 
            // DataGridValorTotal
            // 
            this.DataGridValorTotal.HeaderText = "Valor Total";
            this.DataGridValorTotal.MinimumWidth = 6;
            this.DataGridValorTotal.Name = "DataGridValorTotal";
            this.DataGridValorTotal.Width = 125;
            // 
            // DataGridNomeCliente
            // 
            this.DataGridNomeCliente.HeaderText = "Nome Cliente";
            this.DataGridNomeCliente.MinimumWidth = 6;
            this.DataGridNomeCliente.Name = "DataGridNomeCliente";
            this.DataGridNomeCliente.Width = 160;
            // 
            // DataGridFuncionario
            // 
            this.DataGridFuncionario.HeaderText = "Funcionario";
            this.DataGridFuncionario.MinimumWidth = 6;
            this.DataGridFuncionario.Name = "DataGridFuncionario";
            this.DataGridFuncionario.Width = 125;
            // 
            // DataGridData
            // 
            this.DataGridData.HeaderText = "DIa";
            this.DataGridData.MinimumWidth = 6;
            this.DataGridData.Name = "DataGridData";
            this.DataGridData.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources._7483870576_6ab43f2e_d6eb_46e1_a824_b7a61aaf6a32;
            this.pictureBox1.Location = new System.Drawing.Point(953, 580);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(810, 70);
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
            this.BtnNovoCliente.Location = new System.Drawing.Point(288, 67);
            this.BtnNovoCliente.Name = "BtnNovoCliente";
            this.BtnNovoCliente.Size = new System.Drawing.Size(130, 29);
            this.BtnNovoCliente.TabIndex = 16;
            this.BtnNovoCliente.Text = "Novo Cliente";
            this.BtnNovoCliente.UseVisualStyleBackColor = false;
            this.BtnNovoCliente.Click += new System.EventHandler(this.BtnNovoCliente_Click);
            // 
            // CmbBoxClientes
            // 
            this.CmbBoxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxClientes.FormattingEnabled = true;
            this.CmbBoxClientes.Location = new System.Drawing.Point(570, 68);
            this.CmbBoxClientes.Name = "CmbBoxClientes";
            this.CmbBoxClientes.Size = new System.Drawing.Size(215, 28);
            this.CmbBoxClientes.TabIndex = 33;
            // 
            // ImageBtnFechar
            // 
            this.ImageBtnFechar.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.ImageBtnFechar.Location = new System.Drawing.Point(1228, 6);
            this.ImageBtnFechar.Name = "ImageBtnFechar";
            this.ImageBtnFechar.Size = new System.Drawing.Size(68, 28);
            this.ImageBtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtnFechar.TabIndex = 103;
            this.ImageBtnFechar.TabStop = false;
            this.ImageBtnFechar.Click += new System.EventHandler(this.ImageBtnFechar_Click);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblText.ForeColor = System.Drawing.Color.White;
            this.LblText.Location = new System.Drawing.Point(489, 6);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(136, 23);
            this.LblText.TabIndex = 102;
            this.LblText.Text = "Cadastrar Venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(893, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Valor Total Da Compra =";
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Location = new System.Drawing.Point(1109, 64);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(19, 23);
            this.LblValorTotal.TabIndex = 34;
            this.LblValorTotal.Text = "0";
            // 
            // FormNovaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1298, 823);
            this.Controls.Add(this.ImageBtnFechar);
            this.Controls.Add(this.LblText);
            this.Controls.Add(this.CmbBoxClientes);
            this.Controls.Add(this.BtnNovoCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GroupBoxVenda);
            this.Controls.Add(this.LabelNomeCLiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNovaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNovaVenda";
            this.Load += new System.EventHandler(this.FormNovaVenda_Load);
            this.GroupBoxVenda.ResumeLayout(false);
            this.GroupBoxVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelNomeCLiente;
        private GroupBox GroupBoxVenda;
        private DataGridView DataGrid;
        private Label LabelQuantidade;
        private Label LabelCodigoProduto;
        private Label LabelFormaPagemento;
        private Button BtnNovoIten;
        private ComboBox CmbFormaPagamento;
        private Button button2;
        private Button BtnNovoCliente;
        private Button BtnCadastrarNovaVenda;
        private DateTimePicker DateTime;
        private Button BtnExcluir;
        private TextBox TxtBoxQuantidade;
        private PictureBox pictureBox1;
        private ComboBox CmbBoxProduto;
        private DataGridViewTextBoxColumn DataGridProduto;
        private DataGridViewTextBoxColumn DataGridValorUnitario;
        private DataGridViewTextBoxColumn DatagridQuantidade;
        private DataGridViewTextBoxColumn DataGridValorTotal;
        private DataGridViewTextBoxColumn DataGridNomeCliente;
        private DataGridViewTextBoxColumn DataGridFuncionario;
        private DataGridViewTextBoxColumn DataGridData;
        private ComboBox CmbBoxClientes;
        private PictureBox ImageBtnFechar;
        private Label LblText;
        private Label LblValorTotal;
        private Label label1;
    }
}