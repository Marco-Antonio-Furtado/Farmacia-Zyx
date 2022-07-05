namespace WfPresentationLayer.Alteraçoes
{
    partial class FormMostrarSaidas
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
            this.GridSaidas = new System.Windows.Forms.DataGridView();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gridproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnProcurarCompra = new System.Windows.Forms.Button();
            this.BtnCadastrarVendas = new System.Windows.Forms.Button();
            this.PnlVendas = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridSaidas)).BeginInit();
            this.PnlVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridSaidas
            // 
            this.GridSaidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridSaidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridSaidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.Gridproduto,
            this.GridValorUnitario,
            this.GridQuantidade,
            this.GridFormaPagamento,
            this.GridCliente,
            this.GridValorTotal,
            this.GridData,
            this.GridFuncionario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridSaidas.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridSaidas.Location = new System.Drawing.Point(-2, 0);
            this.GridSaidas.Name = "GridSaidas";
            this.GridSaidas.RowHeadersVisible = false;
            this.GridSaidas.RowHeadersWidth = 51;
            this.GridSaidas.RowTemplate.Height = 29;
            this.GridSaidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSaidas.Size = new System.Drawing.Size(1285, 678);
            this.GridSaidas.TabIndex = 51;
            // 
            // GridID
            // 
            this.GridID.HeaderText = "ID";
            this.GridID.MinimumWidth = 6;
            this.GridID.Name = "GridID";
            this.GridID.Width = 50;
            // 
            // Gridproduto
            // 
            this.Gridproduto.HeaderText = "Produto";
            this.Gridproduto.MinimumWidth = 6;
            this.Gridproduto.Name = "Gridproduto";
            this.Gridproduto.Width = 125;
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
            this.GridQuantidade.Width = 125;
            // 
            // GridFormaPagamento
            // 
            this.GridFormaPagamento.HeaderText = "Forma Pagamento";
            this.GridFormaPagamento.MinimumWidth = 6;
            this.GridFormaPagamento.Name = "GridFormaPagamento";
            this.GridFormaPagamento.Width = 125;
            // 
            // GridCliente
            // 
            this.GridCliente.HeaderText = "Nome CLiente";
            this.GridCliente.MinimumWidth = 6;
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.Width = 125;
            // 
            // GridValorTotal
            // 
            this.GridValorTotal.HeaderText = "ValorTotal";
            this.GridValorTotal.MinimumWidth = 6;
            this.GridValorTotal.Name = "GridValorTotal";
            this.GridValorTotal.Width = 125;
            // 
            // GridData
            // 
            this.GridData.HeaderText = "Data";
            this.GridData.MinimumWidth = 6;
            this.GridData.Name = "GridData";
            this.GridData.Width = 125;
            // 
            // GridFuncionario
            // 
            this.GridFuncionario.HeaderText = "Funcionario";
            this.GridFuncionario.MinimumWidth = 6;
            this.GridFuncionario.Name = "GridFuncionario";
            this.GridFuncionario.Width = 125;
            // 
            // BtnProcurarCompra
            // 
            this.BtnProcurarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarCompra.Location = new System.Drawing.Point(343, 699);
            this.BtnProcurarCompra.Name = "BtnProcurarCompra";
            this.BtnProcurarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarCompra.TabIndex = 50;
            this.BtnProcurarCompra.Text = "              Selecionar Todas as vendas";
            this.BtnProcurarCompra.UseVisualStyleBackColor = false;
            this.BtnProcurarCompra.Click += new System.EventHandler(this.BtnProcurarCompra_Click);
            // 
            // BtnCadastrarVendas
            // 
            this.BtnCadastrarVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarVendas.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarVendas.Location = new System.Drawing.Point(12, 699);
            this.BtnCadastrarVendas.Name = "BtnCadastrarVendas";
            this.BtnCadastrarVendas.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarVendas.TabIndex = 47;
            this.BtnCadastrarVendas.Text = "        Cadastrar Venda";
            this.BtnCadastrarVendas.UseVisualStyleBackColor = false;
            this.BtnCadastrarVendas.Click += new System.EventHandler(this.BtnCadastrarVendas_Click);
            // 
            // PnlVendas
            // 
            this.PnlVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.PnlVendas.Controls.Add(this.GridSaidas);
            this.PnlVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PnlVendas.Location = new System.Drawing.Point(12, 12);
            this.PnlVendas.Name = "PnlVendas";
            this.PnlVendas.Size = new System.Drawing.Size(1286, 681);
            this.PnlVendas.TabIndex = 52;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox2.Image = global::WfPresentationLayer.Properties.Resources.icons8_comprar_80;
            this.pictureBox2.Location = new System.Drawing.Point(18, 708);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.BtnCadastrarVendas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources.menu__v11;
            this.pictureBox1.Location = new System.Drawing.Point(352, 708);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BtnProcurarCompra_Click);
            // 
            // FormMostrarSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1312, 790);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnProcurarCompra);
            this.Controls.Add(this.BtnCadastrarVendas);
            this.Controls.Add(this.PnlVendas);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormMostrarSaidas";
            this.Text = "FormMostrarSaidas";
            ((System.ComponentModel.ISupportInitialize)(this.GridSaidas)).EndInit();
            this.PnlVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridSaidas;
        private Button BtnProcurarCompra;
        private Button BtnCadastrarVendas;
        private Panel PnlVendas;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn Gridproduto;
        private DataGridViewTextBoxColumn GridValorUnitario;
        private DataGridViewTextBoxColumn GridQuantidade;
        private DataGridViewTextBoxColumn GridFormaPagamento;
        private DataGridViewTextBoxColumn GridCliente;
        private DataGridViewTextBoxColumn GridValorTotal;
        private DataGridViewTextBoxColumn GridData;
        private DataGridViewTextBoxColumn GridFuncionario;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}