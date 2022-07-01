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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridFuncionario = new System.Windows.Forms.DataGridView();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gridproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnProcurarCompra = new System.Windows.Forms.Button();
            this.BtnDeletarCompra = new System.Windows.Forms.Button();
            this.BtnAlterarCompra = new System.Windows.Forms.Button();
            this.BtnCadastrarCompra = new System.Windows.Forms.Button();
            this.PnlVendas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).BeginInit();
            this.PnlVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridFuncionario
            // 
            this.GridFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.Gridproduto,
            this.GridValorUnitario,
            this.GridQuantidade,
            this.GridFormaPagamento,
            this.GridCliente,
            this.GridValorTotal,
            this.ValorCompra,
            this.GridData});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFuncionario.DefaultCellStyle = dataGridViewCellStyle6;
            this.GridFuncionario.Location = new System.Drawing.Point(-2, 0);
            this.GridFuncionario.Name = "GridFuncionario";
            this.GridFuncionario.RowHeadersWidth = 51;
            this.GridFuncionario.RowTemplate.Height = 29;
            this.GridFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFuncionario.Size = new System.Drawing.Size(1285, 622);
            this.GridFuncionario.TabIndex = 51;
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
            // ValorCompra
            // 
            this.ValorCompra.HeaderText = "Valor Compra";
            this.ValorCompra.MinimumWidth = 6;
            this.ValorCompra.Name = "ValorCompra";
            this.ValorCompra.Width = 125;
            // 
            // GridData
            // 
            this.GridData.HeaderText = "Data";
            this.GridData.MinimumWidth = 6;
            this.GridData.Name = "GridData";
            this.GridData.Width = 125;
            // 
            // BtnProcurarCompra
            // 
            this.BtnProcurarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarCompra.Location = new System.Drawing.Point(658, 655);
            this.BtnProcurarCompra.Name = "BtnProcurarCompra";
            this.BtnProcurarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarCompra.TabIndex = 50;
            this.BtnProcurarCompra.Text = "Selecionar Compra";
            this.BtnProcurarCompra.UseVisualStyleBackColor = false;
            // 
            // BtnDeletarCompra
            // 
            this.BtnDeletarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarCompra.Location = new System.Drawing.Point(955, 655);
            this.BtnDeletarCompra.Name = "BtnDeletarCompra";
            this.BtnDeletarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarCompra.TabIndex = 49;
            this.BtnDeletarCompra.TabStop = false;
            this.BtnDeletarCompra.Text = "Deletar Compra";
            this.BtnDeletarCompra.UseVisualStyleBackColor = false;
            // 
            // BtnAlterarCompra
            // 
            this.BtnAlterarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarCompra.Location = new System.Drawing.Point(338, 655);
            this.BtnAlterarCompra.Name = "BtnAlterarCompra";
            this.BtnAlterarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarCompra.TabIndex = 48;
            this.BtnAlterarCompra.Text = "Alterar Compra";
            this.BtnAlterarCompra.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrarCompra
            // 
            this.BtnCadastrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCompra.Location = new System.Drawing.Point(13, 651);
            this.BtnCadastrarCompra.Name = "BtnCadastrarCompra";
            this.BtnCadastrarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarCompra.TabIndex = 47;
            this.BtnCadastrarCompra.Text = "Cadastrar Compra";
            this.BtnCadastrarCompra.UseVisualStyleBackColor = false;
            this.BtnCadastrarCompra.Click += new System.EventHandler(this.BtnCadastrarCompra_Click);
            // 
            // PnlVendas
            // 
            this.PnlVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.PnlVendas.Controls.Add(this.GridFuncionario);
            this.PnlVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PnlVendas.Location = new System.Drawing.Point(12, 12);
            this.PnlVendas.Name = "PnlVendas";
            this.PnlVendas.Size = new System.Drawing.Size(1286, 633);
            this.PnlVendas.TabIndex = 52;
            // 
            // FormMostrarSaidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1310, 746);
            this.Controls.Add(this.BtnProcurarCompra);
            this.Controls.Add(this.BtnDeletarCompra);
            this.Controls.Add(this.BtnAlterarCompra);
            this.Controls.Add(this.BtnCadastrarCompra);
            this.Controls.Add(this.PnlVendas);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormMostrarSaidas";
            this.Text = "FormMostrarSaidas";
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).EndInit();
            this.PnlVendas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridFuncionario;
        private Button BtnProcurarCompra;
        private Button BtnDeletarCompra;
        private Button BtnAlterarCompra;
        private Button BtnCadastrarCompra;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn Gridproduto;
        private DataGridViewTextBoxColumn GridValorUnitario;
        private DataGridViewTextBoxColumn GridQuantidade;
        private DataGridViewTextBoxColumn GridFormaPagamento;
        private DataGridViewTextBoxColumn GridCliente;
        private DataGridViewTextBoxColumn GridValorTotal;
        private DataGridViewTextBoxColumn ValorCompra;
        private DataGridViewTextBoxColumn GridData;
        private Panel PnlVendas;
    }
}