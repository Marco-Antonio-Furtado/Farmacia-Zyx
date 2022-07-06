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
            this.GridPontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.PnlCl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCadastrarCliente
            // 
            this.BtnCadastrarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCliente.Location = new System.Drawing.Point(12, 704);
            this.BtnCadastrarCliente.Name = "BtnCadastrarCliente";
            this.BtnCadastrarCliente.Size = new System.Drawing.Size(312, 79);
            this.BtnCadastrarCliente.TabIndex = 22;
            this.BtnCadastrarCliente.Text = "Cadastrar Cliente";
            this.BtnCadastrarCliente.UseVisualStyleBackColor = false;
            this.BtnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnAlterarCliente
            // 
            this.BtnAlterarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAlterarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarCliente.Location = new System.Drawing.Point(341, 704);
            this.BtnAlterarCliente.Name = "BtnAlterarCliente";
            this.BtnAlterarCliente.Size = new System.Drawing.Size(312, 79);
            this.BtnAlterarCliente.TabIndex = 23;
            this.BtnAlterarCliente.Text = "             Alterar / Habilitar   Cliente";
            this.BtnAlterarCliente.UseVisualStyleBackColor = false;
            this.BtnAlterarCliente.Click += new System.EventHandler(this.BtnAlterarCliente_Click);
            // 
            // BtnDeletarClientes
            // 
            this.BtnDeletarClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeletarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarClientes.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarClientes.Location = new System.Drawing.Point(997, 704);
            this.BtnDeletarClientes.Name = "BtnDeletarClientes";
            this.BtnDeletarClientes.Size = new System.Drawing.Size(312, 79);
            this.BtnDeletarClientes.TabIndex = 24;
            this.BtnDeletarClientes.Text = "          Deletar / Desabilitar  Cliente";
            this.BtnDeletarClientes.UseVisualStyleBackColor = false;
            this.BtnDeletarClientes.Click += new System.EventHandler(this.BtnDeletarClientes_Click);
            // 
            // BtnClienteDesabilitado
            // 
            this.BtnClienteDesabilitado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnClienteDesabilitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnClienteDesabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClienteDesabilitado.ForeColor = System.Drawing.Color.White;
            this.BtnClienteDesabilitado.Location = new System.Drawing.Point(668, 704);
            this.BtnClienteDesabilitado.Name = "BtnClienteDesabilitado";
            this.BtnClienteDesabilitado.Size = new System.Drawing.Size(312, 79);
            this.BtnClienteDesabilitado.TabIndex = 25;
            this.BtnClienteDesabilitado.Text = "     Mostrar Clientes       Desabilitados";
            this.BtnClienteDesabilitado.UseVisualStyleBackColor = false;
            this.BtnClienteDesabilitado.Click += new System.EventHandler(this.BtnClienteDesabilitado_Click);
            // 
            // PnlCl
            // 
            this.PnlCl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlCl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.PnlCl.Controls.Add(this.GridClientes);
            this.PnlCl.Location = new System.Drawing.Point(12, 12);
            this.PnlCl.Name = "PnlCl";
            this.PnlCl.Size = new System.Drawing.Size(1300, 686);
            this.PnlCl.TabIndex = 26;
            // 
            // GridClientes
            // 
            this.GridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.GridTelefone2,
            this.GridPontuacao});
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
            this.GridClientes.Size = new System.Drawing.Size(1294, 680);
            this.GridClientes.TabIndex = 33;
            this.GridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridClientes_CellDoubleClick);
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
            // GridPontuacao
            // 
            this.GridPontuacao.HeaderText = "Pontuacao";
            this.GridPontuacao.MinimumWidth = 6;
            this.GridPontuacao.Name = "GridPontuacao";
            this.GridPontuacao.ReadOnly = true;
            this.GridPontuacao.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources.delete__v1;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 713);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BtnDeletarClientes_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox3.Image = global::WfPresentationLayer.Properties.Resources.remove_administrator;
            this.pictureBox3.Location = new System.Drawing.Point(679, 714);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.BtnClienteDesabilitado_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox4.Image = global::WfPresentationLayer.Properties.Resources.icons8_funcionário_homem_80__1_;
            this.pictureBox4.Location = new System.Drawing.Point(354, 714);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.BtnAlterarCliente_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox5.Image = global::WfPresentationLayer.Properties.Resources.icons8_funcionário_homem_80;
            this.pictureBox5.Location = new System.Drawing.Point(25, 714);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // FormMostarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1324, 795);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button BtnCadastrarCliente;
        private Button BtnAlterarCliente;
        private Button BtnDeletarClientes;
        private Button BtnClienteDesabilitado;
        private Panel PnlCl;
        private DataGridView GridClientes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private DataGridViewTextBoxColumn GRIDID;
        private DataGridViewTextBoxColumn Grid;
        private DataGridViewTextBoxColumn GridEmail;
        private DataGridViewTextBoxColumn GridRg;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn GridTelefone1;
        private DataGridViewTextBoxColumn GridTelefone2;
        private DataGridViewTextBoxColumn GridPontuacao;
    }
}