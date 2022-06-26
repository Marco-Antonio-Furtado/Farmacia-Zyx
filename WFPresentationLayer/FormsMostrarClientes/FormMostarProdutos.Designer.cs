﻿namespace WfPresentationLayer.Alteraçoes
{
    partial class FormMostrarProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnProcurarProdutos = new System.Windows.Forms.Button();
            this.BtnDeletarProdutos = new System.Windows.Forms.Button();
            this.BtnAlterarProdutos = new System.Windows.Forms.Button();
            this.BtnCadastrarProduto = new System.Windows.Forms.Button();
            this.Gridprodutos = new System.Windows.Forms.DataGridView();
            this.pnlProduto = new System.Windows.Forms.Panel();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridDescrisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Gridprodutos)).BeginInit();
            this.pnlProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnProcurarProdutos
            // 
            this.BtnProcurarProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarProdutos.Location = new System.Drawing.Point(687, 647);
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
            this.BtnDeletarProdutos.Location = new System.Drawing.Point(1021, 647);
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
            this.BtnAlterarProdutos.Location = new System.Drawing.Point(357, 647);
            this.BtnAlterarProdutos.Name = "BtnAlterarProdutos";
            this.BtnAlterarProdutos.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarProdutos.TabIndex = 38;
            this.BtnAlterarProdutos.Text = "Alterar Produtos";
            this.BtnAlterarProdutos.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrarProduto
            // 
            this.BtnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarProduto.Location = new System.Drawing.Point(38, 647);
            this.BtnCadastrarProduto.Name = "BtnCadastrarProduto";
            this.BtnCadastrarProduto.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarProduto.TabIndex = 42;
            this.BtnCadastrarProduto.Text = "Cadastrar Produtos";
            this.BtnCadastrarProduto.UseVisualStyleBackColor = false;
            this.BtnCadastrarProduto.Click += new System.EventHandler(this.BtnCadastrarProduto_Click);
            // 
            // Gridprodutos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Gridprodutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Gridprodutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridprodutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Gridprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridprodutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.GridNome,
            this.GridLaboratorio,
            this.GridDescrisao,
            this.GridValorCompra,
            this.GridValorVenda});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Gridprodutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Gridprodutos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Gridprodutos.Location = new System.Drawing.Point(0, 0);
            this.Gridprodutos.Name = "Gridprodutos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Gridprodutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Gridprodutos.RowHeadersWidth = 51;
            this.Gridprodutos.RowTemplate.Height = 29;
            this.Gridprodutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Gridprodutos.Size = new System.Drawing.Size(1286, 629);
            this.Gridprodutos.TabIndex = 43;
            // 
            // pnlProduto
            // 
            this.pnlProduto.Controls.Add(this.Gridprodutos);
            this.pnlProduto.Location = new System.Drawing.Point(12, 12);
            this.pnlProduto.Name = "pnlProduto";
            this.pnlProduto.Size = new System.Drawing.Size(1295, 629);
            this.pnlProduto.TabIndex = 44;
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
            this.GridNome.Width = 200;
            // 
            // GridLaboratorio
            // 
            this.GridLaboratorio.HeaderText = "Laboratorio";
            this.GridLaboratorio.MinimumWidth = 6;
            this.GridLaboratorio.Name = "GridLaboratorio";
            this.GridLaboratorio.Width = 200;
            // 
            // GridDescrisao
            // 
            this.GridDescrisao.HeaderText = "Descrisao";
            this.GridDescrisao.MinimumWidth = 6;
            this.GridDescrisao.Name = "GridDescrisao";
            this.GridDescrisao.Width = 200;
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
            // FormMostrarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1319, 765);
            this.Controls.Add(this.BtnCadastrarProduto);
            this.Controls.Add(this.BtnProcurarProdutos);
            this.Controls.Add(this.BtnDeletarProdutos);
            this.Controls.Add(this.BtnAlterarProdutos);
            this.Controls.Add(this.pnlProduto);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "FormMostrarProdutos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.Gridprodutos)).EndInit();
            this.pnlProduto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnProcurarProdutos;
        private Button BtnDeletarProdutos;
        private Button BtnAlterarProdutos;
        private Button BtnCadastrarProduto;
        private DataGridView Gridprodutos;
        private Panel pnlProduto;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridNome;
        private DataGridViewTextBoxColumn GridLaboratorio;
        private DataGridViewTextBoxColumn GridDescrisao;
        private DataGridViewTextBoxColumn GridValorCompra;
        private DataGridViewTextBoxColumn GridValorVenda;
    }
}