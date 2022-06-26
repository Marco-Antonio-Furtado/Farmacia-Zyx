namespace WfPresentationLayer.Alteraçoes
{
    partial class Alteracao_Fornecedor
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
            this.BtnProcurarFornecedor = new System.Windows.Forms.Button();
            this.BtnDeletarFornecedor = new System.Windows.Forms.Button();
            this.BtnAlterarFornecedor = new System.Windows.Forms.Button();
            this.BtnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.GridFornecedor = new System.Windows.Forms.DataGridView();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridRazaosocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNomeResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlFornecedores = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedor)).BeginInit();
            this.PnlFornecedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnProcurarFornecedor
            // 
            this.BtnProcurarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarFornecedor.Location = new System.Drawing.Point(665, 654);
            this.BtnProcurarFornecedor.Name = "BtnProcurarFornecedor";
            this.BtnProcurarFornecedor.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarFornecedor.TabIndex = 30;
            this.BtnProcurarFornecedor.Text = "Selecionar Fornecedor";
            this.BtnProcurarFornecedor.UseVisualStyleBackColor = false;
            // 
            // BtnDeletarFornecedor
            // 
            this.BtnDeletarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarFornecedor.Location = new System.Drawing.Point(997, 654);
            this.BtnDeletarFornecedor.Name = "BtnDeletarFornecedor";
            this.BtnDeletarFornecedor.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarFornecedor.TabIndex = 29;
            this.BtnDeletarFornecedor.Text = "Deletar Fornecedor";
            this.BtnDeletarFornecedor.UseVisualStyleBackColor = false;
            // 
            // BtnAlterarFornecedor
            // 
            this.BtnAlterarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarFornecedor.Location = new System.Drawing.Point(350, 654);
            this.BtnAlterarFornecedor.Name = "BtnAlterarFornecedor";
            this.BtnAlterarFornecedor.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarFornecedor.TabIndex = 28;
            this.BtnAlterarFornecedor.Text = "Alterar Fornecedor";
            this.BtnAlterarFornecedor.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrarFornecedor
            // 
            this.BtnCadastrarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarFornecedor.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarFornecedor.Location = new System.Drawing.Point(37, 654);
            this.BtnCadastrarFornecedor.Name = "BtnCadastrarFornecedor";
            this.BtnCadastrarFornecedor.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarFornecedor.TabIndex = 27;
            this.BtnCadastrarFornecedor.Text = "Cadastrar Fornecedor";
            this.BtnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.BtnCadastrarFornecedor.Click += new System.EventHandler(this.BtnCadastrarFornecedor_Click);
            // 
            // GridFornecedor
            // 
            this.GridFornecedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.GridRazaosocial,
            this.GridTelefone,
            this.GridNomeResponsavel,
            this.GridEmail,
            this.GridCNPJ});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFornecedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridFornecedor.Location = new System.Drawing.Point(0, 3);
            this.GridFornecedor.Name = "GridFornecedor";
            this.GridFornecedor.RowHeadersWidth = 51;
            this.GridFornecedor.RowTemplate.Height = 29;
            this.GridFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFornecedor.Size = new System.Drawing.Size(1307, 633);
            this.GridFornecedor.TabIndex = 31;
            // 
            // GridID
            // 
            this.GridID.HeaderText = "ID";
            this.GridID.MinimumWidth = 6;
            this.GridID.Name = "GridID";
            this.GridID.Width = 75;
            // 
            // GridRazaosocial
            // 
            this.GridRazaosocial.HeaderText = "Razão Social";
            this.GridRazaosocial.MinimumWidth = 6;
            this.GridRazaosocial.Name = "GridRazaosocial";
            this.GridRazaosocial.Width = 175;
            // 
            // GridTelefone
            // 
            this.GridTelefone.HeaderText = "Telefone";
            this.GridTelefone.MinimumWidth = 6;
            this.GridTelefone.Name = "GridTelefone";
            this.GridTelefone.Width = 125;
            // 
            // GridNomeResponsavel
            // 
            this.GridNomeResponsavel.HeaderText = "Nome Responsavel";
            this.GridNomeResponsavel.MinimumWidth = 6;
            this.GridNomeResponsavel.Name = "GridNomeResponsavel";
            this.GridNomeResponsavel.Width = 200;
            // 
            // GridEmail
            // 
            this.GridEmail.HeaderText = "Email";
            this.GridEmail.MinimumWidth = 6;
            this.GridEmail.Name = "GridEmail";
            this.GridEmail.Width = 125;
            // 
            // GridCNPJ
            // 
            this.GridCNPJ.HeaderText = "CNPJ";
            this.GridCNPJ.MinimumWidth = 6;
            this.GridCNPJ.Name = "GridCNPJ";
            this.GridCNPJ.ReadOnly = true;
            this.GridCNPJ.Width = 125;
            // 
            // PnlFornecedores
            // 
            this.PnlFornecedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.PnlFornecedores.Controls.Add(this.GridFornecedor);
            this.PnlFornecedores.ForeColor = System.Drawing.Color.White;
            this.PnlFornecedores.Location = new System.Drawing.Point(12, 12);
            this.PnlFornecedores.Name = "PnlFornecedores";
            this.PnlFornecedores.Size = new System.Drawing.Size(1310, 627);
            this.PnlFornecedores.TabIndex = 32;
            // 
            // Alteracao_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1334, 754);
            this.Controls.Add(this.BtnProcurarFornecedor);
            this.Controls.Add(this.BtnDeletarFornecedor);
            this.Controls.Add(this.BtnAlterarFornecedor);
            this.Controls.Add(this.BtnCadastrarFornecedor);
            this.Controls.Add(this.PnlFornecedores);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Alteracao_Fornecedor";
            this.Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.GridFornecedor)).EndInit();
            this.PnlFornecedores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnProcurarFornecedor;
        private Button BtnDeletarFornecedor;
        private Button BtnAlterarFornecedor;
        private Button BtnCadastrarFornecedor;
        private DataGridView GridFornecedor;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridRazaosocial;
        private DataGridViewTextBoxColumn GridTelefone;
        private DataGridViewTextBoxColumn GridNomeResponsavel;
        private DataGridViewTextBoxColumn GridEmail;
        private DataGridViewTextBoxColumn GridCNPJ;
        private Panel PnlFornecedores;
    }
}