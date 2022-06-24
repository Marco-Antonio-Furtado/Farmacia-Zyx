namespace WfPresentationLayer.Alteraçoes
{
    partial class Produtos
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
            this.GridFuncionario = new System.Windows.Forms.DataGridView();
            this.BtnProcurarFornecedor = new System.Windows.Forms.Button();
            this.BtnDeletarFornecedor = new System.Windows.Forms.Button();
            this.BtnAlterarFornecedor = new System.Windows.Forms.Button();
            this.BtnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDescrisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.GridNome,
            this.GridLaboratorio,
            this.GridDescrisao,
            this.GridValorCompra,
            this.GridValorVenda});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridFuncionario.Location = new System.Drawing.Point(12, 12);
            this.GridFuncionario.Name = "GridFuncionario";
            this.GridFuncionario.RowHeadersWidth = 51;
            this.GridFuncionario.RowTemplate.Height = 29;
            this.GridFuncionario.Size = new System.Drawing.Size(1169, 521);
            this.GridFuncionario.TabIndex = 41;
            // 
            // BtnProcurarFornecedor
            // 
            this.BtnProcurarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarFornecedor.Location = new System.Drawing.Point(607, 576);
            this.BtnProcurarFornecedor.Name = "BtnProcurarFornecedor";
            this.BtnProcurarFornecedor.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarFornecedor.TabIndex = 40;
            this.BtnProcurarFornecedor.Text = "Selecionar Fornecedor";
            this.BtnProcurarFornecedor.UseVisualStyleBackColor = false;
            // 
            // BtnDeletarFornecedor
            // 
            this.BtnDeletarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarFornecedor.Location = new System.Drawing.Point(904, 576);
            this.BtnDeletarFornecedor.Name = "BtnDeletarFornecedor";
            this.BtnDeletarFornecedor.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarFornecedor.TabIndex = 39;
            this.BtnDeletarFornecedor.Text = "Deletar Fornecedor";
            this.BtnDeletarFornecedor.UseVisualStyleBackColor = false;
            // 
            // BtnAlterarFornecedor
            // 
            this.BtnAlterarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarFornecedor.Location = new System.Drawing.Point(313, 576);
            this.BtnAlterarFornecedor.Name = "BtnAlterarFornecedor";
            this.BtnAlterarFornecedor.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarFornecedor.TabIndex = 38;
            this.BtnAlterarFornecedor.Text = "Alterar Fornecedor";
            this.BtnAlterarFornecedor.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrarFornecedor
            // 
            this.BtnCadastrarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarFornecedor.Location = new System.Drawing.Point(12, 576);
            this.BtnCadastrarFornecedor.Name = "BtnCadastrarFornecedor";
            this.BtnCadastrarFornecedor.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarFornecedor.TabIndex = 37;
            this.BtnCadastrarFornecedor.Text = "Cadastrar Fornecedor";
            this.BtnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.BtnCadastrarFornecedor.Click += new System.EventHandler(this.BtnCadastrarFornecedor_Click);
            // 
            // GridID
            // 
            this.GridID.HeaderText = "ID";
            this.GridID.MinimumWidth = 6;
            this.GridID.Name = "GridID";
            this.GridID.Width = 50;
            // 
            // GridNome
            // 
            this.GridNome.HeaderText = "Nome";
            this.GridNome.MinimumWidth = 6;
            this.GridNome.Name = "GridNome";
            this.GridNome.Width = 125;
            // 
            // GridLaboratorio
            // 
            this.GridLaboratorio.HeaderText = "Laboratorio";
            this.GridLaboratorio.MinimumWidth = 6;
            this.GridLaboratorio.Name = "GridLaboratorio";
            this.GridLaboratorio.Width = 125;
            // 
            // GridDescrisao
            // 
            this.GridDescrisao.HeaderText = "Descrisao";
            this.GridDescrisao.MinimumWidth = 6;
            this.GridDescrisao.Name = "GridDescrisao";
            this.GridDescrisao.Width = 125;
            // 
            // GridValorCompra
            // 
            this.GridValorCompra.HeaderText = "Valor Compra";
            this.GridValorCompra.MinimumWidth = 6;
            this.GridValorCompra.Name = "GridValorCompra";
            this.GridValorCompra.Width = 175;
            // 
            // GridValorVenda
            // 
            this.GridValorVenda.HeaderText = "Valor Venda";
            this.GridValorVenda.MinimumWidth = 6;
            this.GridValorVenda.Name = "GridValorVenda";
            this.GridValorVenda.Width = 175;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1205, 748);
            this.Controls.Add(this.GridFuncionario);
            this.Controls.Add(this.BtnProcurarFornecedor);
            this.Controls.Add(this.BtnDeletarFornecedor);
            this.Controls.Add(this.BtnAlterarFornecedor);
            this.Controls.Add(this.BtnCadastrarFornecedor);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "Produtos";
            this.Text = "Alteracao_Produto";
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridFuncionario;
        private Button BtnProcurarFornecedor;
        private Button BtnDeletarFornecedor;
        private Button BtnAlterarFornecedor;
        private Button BtnCadastrarFornecedor;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridNome;
        private DataGridViewTextBoxColumn GridLaboratorio;
        private DataGridViewTextBoxColumn GridDescrisao;
        private DataGridViewTextBoxColumn GridValorCompra;
        private DataGridViewTextBoxColumn GridValorVenda;
    }
}