namespace WfPresentationLayer.Alteraçoes
{
    partial class FormMostarClientes
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
            this.BtnCadastrarCliente = new System.Windows.Forms.Button();
            this.BtnAlterarCliente = new System.Windows.Forms.Button();
            this.BtnDeletarClientes = new System.Windows.Forms.Button();
            this.BtnClienteDesabilitado = new System.Windows.Forms.Button();
            this.PnlCl = new System.Windows.Forms.Panel();
            this.GridClientes = new System.Windows.Forms.DataGridView();
            this.GRIDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTelefone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTelefone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlCl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCadastrarCliente
            // 
            this.BtnCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCliente.Location = new System.Drawing.Point(12, 648);
            this.BtnCadastrarCliente.Name = "BtnCadastrarCliente";
            this.BtnCadastrarCliente.Size = new System.Drawing.Size(312, 79);
            this.BtnCadastrarCliente.TabIndex = 22;
            this.BtnCadastrarCliente.Text = "Cadastrar Cliente";
            this.BtnCadastrarCliente.UseVisualStyleBackColor = false;
            this.BtnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnAlterarCliente
            // 
            this.BtnAlterarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarCliente.Location = new System.Drawing.Point(341, 648);
            this.BtnAlterarCliente.Name = "BtnAlterarCliente";
            this.BtnAlterarCliente.Size = new System.Drawing.Size(312, 79);
            this.BtnAlterarCliente.TabIndex = 23;
            this.BtnAlterarCliente.Text = "Alterar / Habilitar   Cliente";
            this.BtnAlterarCliente.UseVisualStyleBackColor = false;
            this.BtnAlterarCliente.Click += new System.EventHandler(this.BtnAlterarCliente_Click);
            // 
            // BtnDeletarClientes
            // 
            this.BtnDeletarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarClientes.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarClientes.Location = new System.Drawing.Point(1000, 648);
            this.BtnDeletarClientes.Name = "BtnDeletarClientes";
            this.BtnDeletarClientes.Size = new System.Drawing.Size(312, 79);
            this.BtnDeletarClientes.TabIndex = 24;
            this.BtnDeletarClientes.Text = "Deletar / Desabilitar  Cliente";
            this.BtnDeletarClientes.UseVisualStyleBackColor = false;
            this.BtnDeletarClientes.Click += new System.EventHandler(this.BtnDeletarClientes_Click);
            // 
            // BtnClienteDesabilitado
            // 
            this.BtnClienteDesabilitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnClienteDesabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClienteDesabilitado.ForeColor = System.Drawing.Color.White;
            this.BtnClienteDesabilitado.Location = new System.Drawing.Point(668, 648);
            this.BtnClienteDesabilitado.Name = "BtnClienteDesabilitado";
            this.BtnClienteDesabilitado.Size = new System.Drawing.Size(312, 79);
            this.BtnClienteDesabilitado.TabIndex = 25;
            this.BtnClienteDesabilitado.Text = "Mostrar Clientes       Desabilitados";
            this.BtnClienteDesabilitado.UseVisualStyleBackColor = false;
            this.BtnClienteDesabilitado.Click += new System.EventHandler(this.BtnClienteDesabilitado_Click);
            // 
            // PnlCl
            // 
            this.PnlCl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.PnlCl.Controls.Add(this.GridClientes);
            this.PnlCl.Location = new System.Drawing.Point(12, 12);
            this.PnlCl.Name = "PnlCl";
            this.PnlCl.Size = new System.Drawing.Size(1300, 617);
            this.PnlCl.TabIndex = 26;
            // 
            // GridClientes
            // 
            this.GridClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRIDID,
            this.Grid,
            this.GridEmail,
            this.GridRg,
            this.dataGridViewTextBoxColumn1,
            this.GridTelefone1,
            this.GridTelefone2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridClientes.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.GridClientes.Location = new System.Drawing.Point(3, 3);
            this.GridClientes.Name = "GridClientes";
            this.GridClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridClientes.RowHeadersWidth = 51;
            this.GridClientes.RowTemplate.Height = 29;
            this.GridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridClientes.Size = new System.Drawing.Size(1294, 618);
            this.GridClientes.TabIndex = 33;
            // 
            // GRIDID
            // 
            this.GRIDID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GRIDID.HeaderText = "ID";
            this.GRIDID.MinimumWidth = 6;
            this.GRIDID.Name = "GRIDID";
            this.GRIDID.ReadOnly = true;
            this.GRIDID.Width = 56;
            // 
            // Grid
            // 
            this.Grid.HeaderText = "Nome";
            this.Grid.MinimumWidth = 6;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Width = 125;
            // 
            // GridEmail
            // 
            this.GridEmail.HeaderText = "Email";
            this.GridEmail.MinimumWidth = 6;
            this.GridEmail.Name = "GridEmail";
            this.GridEmail.ReadOnly = true;
            this.GridEmail.Width = 200;
            // 
            // GridRg
            // 
            this.GridRg.HeaderText = "RG";
            this.GridRg.MinimumWidth = 6;
            this.GridRg.Name = "GridRg";
            this.GridRg.ReadOnly = true;
            this.GridRg.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // GridTelefone1
            // 
            this.GridTelefone1.HeaderText = "Telefone1";
            this.GridTelefone1.MinimumWidth = 6;
            this.GridTelefone1.Name = "GridTelefone1";
            this.GridTelefone1.ReadOnly = true;
            this.GridTelefone1.Width = 200;
            // 
            // GridTelefone2
            // 
            this.GridTelefone2.HeaderText = "Telefone2";
            this.GridTelefone2.MinimumWidth = 6;
            this.GridTelefone2.Name = "GridTelefone2";
            this.GridTelefone2.ReadOnly = true;
            this.GridTelefone2.Width = 200;
            // 
            // FormMostarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1324, 750);
            this.Controls.Add(this.PnlCl);
            this.Controls.Add(this.BtnClienteDesabilitado);
            this.Controls.Add(this.BtnDeletarClientes);
            this.Controls.Add(this.BtnAlterarCliente);
            this.Controls.Add(this.BtnCadastrarCliente);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormMostarClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormMostarClientes_Load);
            this.PnlCl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnCadastrarCliente;
        private Button BtnAlterarCliente;
        private Button BtnDeletarClientes;
        private Button BtnClienteDesabilitado;
        private Panel PnlCl;
        private DataGridView GridClientes;
        private DataGridViewTextBoxColumn GRIDID;
        private DataGridViewTextBoxColumn Grid;
        private DataGridViewTextBoxColumn GridEmail;
        private DataGridViewTextBoxColumn GridRg;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn GridTelefone1;
        private DataGridViewTextBoxColumn GridTelefone2;
    }
}