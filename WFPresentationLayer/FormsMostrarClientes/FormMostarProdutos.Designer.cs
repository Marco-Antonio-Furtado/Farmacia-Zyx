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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridFuncionario = new System.Windows.Forms.DataGridView();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDescrisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnProcurarProdutos = new System.Windows.Forms.Button();
            this.BtnDeletarProdutos = new System.Windows.Forms.Button();
            this.BtnAlterarProdutos = new System.Windows.Forms.Button();
            this.BtnCadastrarProdutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // GridFuncionario
            // 
            this.GridFuncionario.BackgroundColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.GridNome,
            this.GridLaboratorio,
            this.GridDescrisao,
            this.GridValorCompra,
            this.GridValorVenda});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFuncionario.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridFuncionario.Location = new System.Drawing.Point(12, 12);
            this.GridFuncionario.Name = "GridFuncionario";
            this.GridFuncionario.RowHeadersWidth = 51;
            this.GridFuncionario.RowTemplate.Height = 29;
            this.GridFuncionario.Size = new System.Drawing.Size(1169, 521);
            this.GridFuncionario.TabIndex = 41;
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
            // BtnProcurarProdutos
            // 
            this.BtnProcurarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarProdutos.Location = new System.Drawing.Point(607, 576);
            this.BtnProcurarProdutos.Name = "BtnProcurarProdutos";
            this.BtnProcurarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarProdutos.TabIndex = 40;
            this.BtnProcurarProdutos.Text = "Selecionar Produtos ";
            this.BtnProcurarProdutos.UseVisualStyleBackColor = false;
            // 
            // BtnDeletarProdutos
            // 
            this.BtnDeletarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarProdutos.Location = new System.Drawing.Point(904, 576);
            this.BtnDeletarProdutos.Name = "BtnDeletarProdutos";
            this.BtnDeletarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarProdutos.TabIndex = 39;
            this.BtnDeletarProdutos.Text = "Deletar Produtos";
            this.BtnDeletarProdutos.UseVisualStyleBackColor = false;
            // 
            // BtnAlterarProdutos
            // 
            this.BtnAlterarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarProdutos.Location = new System.Drawing.Point(313, 576);
            this.BtnAlterarProdutos.Name = "BtnAlterarProdutos";
            this.BtnAlterarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarProdutos.TabIndex = 38;
            this.BtnAlterarProdutos.Text = "Alterar Produtos";
            this.BtnAlterarProdutos.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrarProdutos
            // 
            this.BtnCadastrarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarProdutos.Location = new System.Drawing.Point(12, 576);
            this.BtnCadastrarProdutos.Name = "BtnCadastrarProdutos";
            this.BtnCadastrarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarProdutos.TabIndex = 37;
            this.BtnCadastrarProdutos.Text = "Cadastrar Produtos";
            this.BtnCadastrarProdutos.UseVisualStyleBackColor = false;
            this.BtnCadastrarProdutos.Click += new System.EventHandler(this.BtnCadastrarFornecedor_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1205, 748);
            this.Controls.Add(this.GridFuncionario);
            this.Controls.Add(this.BtnProcurarProdutos);
            this.Controls.Add(this.BtnDeletarProdutos);
            this.Controls.Add(this.BtnAlterarProdutos);
            this.Controls.Add(this.BtnCadastrarProdutos);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "Produtos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridFuncionario;
        private Button BtnProcurarProdutos;
        private Button BtnDeletarProdutos;
        private Button BtnAlterarProdutos;
        private Button BtnCadastrarProdutos;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridNome;
        private DataGridViewTextBoxColumn GridLaboratorio;
        private DataGridViewTextBoxColumn GridDescrisao;
        private DataGridViewTextBoxColumn GridValorCompra;
        private DataGridViewTextBoxColumn GridValorVenda;
    }
}