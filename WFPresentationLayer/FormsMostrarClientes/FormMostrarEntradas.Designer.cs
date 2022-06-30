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
            this.GridFuncionario = new System.Windows.Forms.DataGridView();
            this.BtnProcurarCompra = new System.Windows.Forms.Button();
            this.BtnDeletarCompra = new System.Windows.Forms.Button();
            this.BtnAlterarCompra = new System.Windows.Forms.Button();
            this.BtnCadastrarCompra = new System.Windows.Forms.Button();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDescrisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // GridFuncionario
            // 
            this.GridFuncionario.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.GridProduto,
            this.GridValorCompra,
            this.GridQuantidade,
            this.GridFormaPagamento,
            this.GridFornecedor,
            this.GridData,
            this.GridDescrisao,
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridFuncionario.Location = new System.Drawing.Point(12, 12);
            this.GridFuncionario.Name = "GridFuncionario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridFuncionario.RowHeadersWidth = 51;
            this.GridFuncionario.RowTemplate.Height = 29;
            this.GridFuncionario.Size = new System.Drawing.Size(1315, 645);
            this.GridFuncionario.TabIndex = 46;
            // 
            // BtnProcurarCompra
            // 
            this.BtnProcurarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarCompra.Location = new System.Drawing.Point(667, 676);
            this.BtnProcurarCompra.Name = "BtnProcurarCompra";
            this.BtnProcurarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarCompra.TabIndex = 45;
            this.BtnProcurarCompra.Text = "Selecionar Compra";
            this.BtnProcurarCompra.UseVisualStyleBackColor = false;
            // 
            // BtnDeletarCompra
            // 
            this.BtnDeletarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarCompra.Location = new System.Drawing.Point(964, 676);
            this.BtnDeletarCompra.Name = "BtnDeletarCompra";
            this.BtnDeletarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarCompra.TabIndex = 44;
            this.BtnDeletarCompra.TabStop = false;
            this.BtnDeletarCompra.Text = "Deletar Compra";
            this.BtnDeletarCompra.UseVisualStyleBackColor = false;
            // 
            // BtnAlterarCompra
            // 
            this.BtnAlterarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarCompra.Location = new System.Drawing.Point(373, 676);
            this.BtnAlterarCompra.Name = "BtnAlterarCompra";
            this.BtnAlterarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarCompra.TabIndex = 43;
            this.BtnAlterarCompra.Text = "Alterar Compra";
            this.BtnAlterarCompra.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrarCompra
            // 
            this.BtnCadastrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCompra.Location = new System.Drawing.Point(72, 676);
            this.BtnCadastrarCompra.Name = "BtnCadastrarCompra";
            this.BtnCadastrarCompra.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarCompra.TabIndex = 42;
            this.BtnCadastrarCompra.Text = "Cadastrar Compra";
            this.BtnCadastrarCompra.UseVisualStyleBackColor = false;
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
            // GridValorCompra
            // 
            this.GridValorCompra.HeaderText = "Valor Total";
            this.GridValorCompra.MinimumWidth = 6;
            this.GridValorCompra.Name = "GridValorCompra";
            this.GridValorCompra.Width = 125;
            // 
            // GridQuantidade
            // 
            this.GridQuantidade.HeaderText = "Quantidade";
            this.GridQuantidade.MinimumWidth = 6;
            this.GridQuantidade.Name = "GridQuantidade";
            this.GridQuantidade.Width = 120;
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
            // GridDescrisao
            // 
            this.GridDescrisao.HeaderText = "Descrisao";
            this.GridDescrisao.MinimumWidth = 6;
            this.GridDescrisao.Name = "GridDescrisao";
            this.GridDescrisao.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Funcionario";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // FormMostrarEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1339, 767);
            this.Controls.Add(this.GridFuncionario);
            this.Controls.Add(this.BtnProcurarCompra);
            this.Controls.Add(this.BtnDeletarCompra);
            this.Controls.Add(this.BtnAlterarCompra);
            this.Controls.Add(this.BtnCadastrarCompra);
            this.Name = "FormMostrarEntradas";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FormMostrarEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridFuncionario;
        private Button BtnProcurarCompra;
        private Button BtnDeletarCompra;
        private Button BtnAlterarCompra;
        private Button BtnCadastrarCompra;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridProduto;
        private DataGridViewTextBoxColumn GridValorCompra;
        private DataGridViewTextBoxColumn GridQuantidade;
        private DataGridViewTextBoxColumn GridFormaPagamento;
        private DataGridViewTextBoxColumn GridFornecedor;
        private DataGridViewTextBoxColumn GridData;
        private DataGridViewTextBoxColumn GridDescrisao;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}