namespace WfPresentationLayer.Alteraçoes
{
    partial class Alteracao_Funcionario
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
            this.GridFuncionario = new System.Windows.Forms.DataGridView();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNomeResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnProcurarFuncionario = new System.Windows.Forms.Button();
            this.BtnDeletarFuncionario = new System.Windows.Forms.Button();
            this.BtnAlterarFuncionario = new System.Windows.Forms.Button();
            this.BtnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.pnlFunc = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).BeginInit();
            this.pnlFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridFuncionario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.GridFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridID,
            this.GridNome,
            this.GridRg,
            this.GridNomeResponsavel,
            this.GridTelefone,
            this.GridEmail,
            this.GridCNPJ,
            this.GridCargo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridFuncionario.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.GridFuncionario.Location = new System.Drawing.Point(0, 3);
            this.GridFuncionario.Name = "GridFuncionario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridFuncionario.RowHeadersWidth = 51;
            this.GridFuncionario.RowTemplate.Height = 29;
            this.GridFuncionario.Size = new System.Drawing.Size(1277, 622);
            this.GridFuncionario.TabIndex = 36;
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
            // GridRg
            // 
            this.GridRg.HeaderText = "RG";
            this.GridRg.MinimumWidth = 6;
            this.GridRg.Name = "GridRg";
            this.GridRg.Width = 95;
            // 
            // GridNomeResponsavel
            // 
            this.GridNomeResponsavel.HeaderText = "CPF";
            this.GridNomeResponsavel.MinimumWidth = 6;
            this.GridNomeResponsavel.Name = "GridNomeResponsavel";
            this.GridNomeResponsavel.Width = 125;
            // 
            // GridTelefone
            // 
            this.GridTelefone.HeaderText = "Telefone";
            this.GridTelefone.MinimumWidth = 6;
            this.GridTelefone.Name = "GridTelefone";
            this.GridTelefone.Width = 125;
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
            this.GridCNPJ.HeaderText = "Endereco";
            this.GridCNPJ.MinimumWidth = 6;
            this.GridCNPJ.Name = "GridCNPJ";
            this.GridCNPJ.ReadOnly = true;
            this.GridCNPJ.Width = 125;
            // 
            // GridCargo
            // 
            this.GridCargo.HeaderText = "Cargo";
            this.GridCargo.MinimumWidth = 6;
            this.GridCargo.Name = "GridCargo";
            this.GridCargo.Width = 125;
            // 
            // BtnProcurarFuncionario
            // 
            this.BtnProcurarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarFuncionario.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarFuncionario.Location = new System.Drawing.Point(682, 659);
            this.BtnProcurarFuncionario.Name = "BtnProcurarFuncionario";
            this.BtnProcurarFuncionario.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarFuncionario.TabIndex = 35;
            this.BtnProcurarFuncionario.Text = "Selecionar Funcionario";
            this.BtnProcurarFuncionario.UseVisualStyleBackColor = false;
            // 
            // BtnDeletarFuncionario
            // 
            this.BtnDeletarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarFuncionario.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarFuncionario.Location = new System.Drawing.Point(990, 659);
            this.BtnDeletarFuncionario.Name = "BtnDeletarFuncionario";
            this.BtnDeletarFuncionario.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarFuncionario.TabIndex = 34;
            this.BtnDeletarFuncionario.Text = "Deletar Funcionario";
            this.BtnDeletarFuncionario.UseVisualStyleBackColor = false;
            // 
            // BtnAlterarFuncionario
            // 
            this.BtnAlterarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarFuncionario.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarFuncionario.Location = new System.Drawing.Point(360, 659);
            this.BtnAlterarFuncionario.Name = "BtnAlterarFuncionario";
            this.BtnAlterarFuncionario.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarFuncionario.TabIndex = 33;
            this.BtnAlterarFuncionario.Text = "Alterar Funcionario";
            this.BtnAlterarFuncionario.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrarFuncionario
            // 
            this.BtnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarFuncionario.Location = new System.Drawing.Point(41, 659);
            this.BtnCadastrarFuncionario.Name = "BtnCadastrarFuncionario";
            this.BtnCadastrarFuncionario.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarFuncionario.TabIndex = 32;
            this.BtnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.BtnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.BtnCadastrarFuncionario.Click += new System.EventHandler(this.BtnCadastrarFornecedor_Click);
            // 
            // pnlFunc
            // 
            this.pnlFunc.BackColor = System.Drawing.Color.DarkGray;
            this.pnlFunc.Controls.Add(this.GridFuncionario);
            this.pnlFunc.Location = new System.Drawing.Point(6, 12);
            this.pnlFunc.Name = "pnlFunc";
            this.pnlFunc.Size = new System.Drawing.Size(1261, 613);
            this.pnlFunc.TabIndex = 37;
            // 
            // Alteracao_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1305, 760);
            this.Controls.Add(this.BtnProcurarFuncionario);
            this.Controls.Add(this.BtnDeletarFuncionario);
            this.Controls.Add(this.BtnAlterarFuncionario);
            this.Controls.Add(this.BtnCadastrarFuncionario);
            this.Controls.Add(this.pnlFunc);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "Alteracao_Funcionario";
            this.Text = "Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).EndInit();
            this.pnlFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridFuncionario;
        private Button BtnProcurarFuncionario;
        private Button BtnDeletarFuncionario;
        private Button BtnAlterarFuncionario;
        private Button BtnCadastrarFuncionario;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridNome;
        private DataGridViewTextBoxColumn GridRg;
        private DataGridViewTextBoxColumn GridNomeResponsavel;
        private DataGridViewTextBoxColumn GridTelefone;
        private DataGridViewTextBoxColumn GridEmail;
        private DataGridViewTextBoxColumn GridCNPJ;
        private DataGridViewTextBoxColumn GridCargo;
        private Panel pnlFunc;
    }
}