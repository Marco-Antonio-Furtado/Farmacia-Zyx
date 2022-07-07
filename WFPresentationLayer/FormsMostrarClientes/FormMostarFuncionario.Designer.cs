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
            this.BtnDesabilitados = new System.Windows.Forms.Button();
            this.BtnDeletarFuncionario = new System.Windows.Forms.Button();
            this.BtnAlterarFuncionario = new System.Windows.Forms.Button();
            this.BtnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.pnlFunc = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PctRefresh = new System.Windows.Forms.PictureBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).BeginInit();
            this.pnlFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // GridFuncionario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridFuncionario.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.GridFuncionario.Location = new System.Drawing.Point(0, 3);
            this.GridFuncionario.Name = "GridFuncionario";
            this.GridFuncionario.ReadOnly = true;
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
            this.GridFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFuncionario.Size = new System.Drawing.Size(1297, 682);
            this.GridFuncionario.TabIndex = 36;
            // 
            // GridID
            // 
            this.GridID.HeaderText = "ID";
            this.GridID.MinimumWidth = 6;
            this.GridID.Name = "GridID";
            this.GridID.ReadOnly = true;
            this.GridID.Width = 50;
            // 
            // GridNome
            // 
            this.GridNome.HeaderText = "Nome";
            this.GridNome.MinimumWidth = 6;
            this.GridNome.Name = "GridNome";
            this.GridNome.ReadOnly = true;
            this.GridNome.Width = 125;
            // 
            // GridRg
            // 
            this.GridRg.HeaderText = "RG";
            this.GridRg.MinimumWidth = 6;
            this.GridRg.Name = "GridRg";
            this.GridRg.ReadOnly = true;
            this.GridRg.Width = 95;
            // 
            // GridNomeResponsavel
            // 
            this.GridNomeResponsavel.HeaderText = "CPF";
            this.GridNomeResponsavel.MinimumWidth = 6;
            this.GridNomeResponsavel.Name = "GridNomeResponsavel";
            this.GridNomeResponsavel.ReadOnly = true;
            this.GridNomeResponsavel.Width = 125;
            // 
            // GridTelefone
            // 
            this.GridTelefone.HeaderText = "Telefone";
            this.GridTelefone.MinimumWidth = 6;
            this.GridTelefone.Name = "GridTelefone";
            this.GridTelefone.ReadOnly = true;
            this.GridTelefone.Width = 125;
            // 
            // GridEmail
            // 
            this.GridEmail.HeaderText = "Email";
            this.GridEmail.MinimumWidth = 6;
            this.GridEmail.Name = "GridEmail";
            this.GridEmail.ReadOnly = true;
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
            this.GridCargo.ReadOnly = true;
            this.GridCargo.Width = 125;
            // 
            // BtnDesabilitados
            // 
            this.BtnDesabilitados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDesabilitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDesabilitados.ForeColor = System.Drawing.Color.White;
            this.BtnDesabilitados.Location = new System.Drawing.Point(597, 703);
            this.BtnDesabilitados.Name = "BtnDesabilitados";
            this.BtnDesabilitados.Size = new System.Drawing.Size(277, 79);
            this.BtnDesabilitados.TabIndex = 35;
            this.BtnDesabilitados.Text = "         Mostrar Funcionarios Desabilitados";
            this.BtnDesabilitados.UseVisualStyleBackColor = false;
            this.BtnDesabilitados.Click += new System.EventHandler(this.BtnDesabilitados_Click);
            // 
            // BtnDeletarFuncionario
            // 
            this.BtnDeletarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarFuncionario.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarFuncionario.Location = new System.Drawing.Point(894, 703);
            this.BtnDeletarFuncionario.Name = "BtnDeletarFuncionario";
            this.BtnDeletarFuncionario.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarFuncionario.TabIndex = 34;
            this.BtnDeletarFuncionario.Text = "        Deletar/Desabilitar Funcionario";
            this.BtnDeletarFuncionario.UseVisualStyleBackColor = false;
            this.BtnDeletarFuncionario.Click += new System.EventHandler(this.BtnDeletarFuncionario_Click);
            // 
            // BtnAlterarFuncionario
            // 
            this.BtnAlterarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarFuncionario.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarFuncionario.Location = new System.Drawing.Point(307, 703);
            this.BtnAlterarFuncionario.Name = "BtnAlterarFuncionario";
            this.BtnAlterarFuncionario.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarFuncionario.TabIndex = 33;
            this.BtnAlterarFuncionario.Text = "        Alterar / Habilitar   Funcionario";
            this.BtnAlterarFuncionario.UseVisualStyleBackColor = false;
            this.BtnAlterarFuncionario.Click += new System.EventHandler(this.BtnAlterarFuncionario_Click);
            // 
            // BtnCadastrarFuncionario
            // 
            this.BtnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarFuncionario.Location = new System.Drawing.Point(14, 703);
            this.BtnCadastrarFuncionario.Name = "BtnCadastrarFuncionario";
            this.BtnCadastrarFuncionario.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarFuncionario.TabIndex = 32;
            this.BtnCadastrarFuncionario.Text = "          Cadastrar Funcionario";
            this.BtnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.BtnCadastrarFuncionario.Click += new System.EventHandler(this.BtnCadastrarFuncionario_Click);
            // 
            // pnlFunc
            // 
            this.pnlFunc.BackColor = System.Drawing.Color.DarkGray;
            this.pnlFunc.Controls.Add(this.GridFuncionario);
            this.pnlFunc.Location = new System.Drawing.Point(6, 12);
            this.pnlFunc.Name = "pnlFunc";
            this.pnlFunc.Size = new System.Drawing.Size(1300, 685);
            this.pnlFunc.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources.delete__v1;
            this.pictureBox1.Location = new System.Drawing.Point(905, 713);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BtnDeletarFuncionario_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox2.Image = global::WfPresentationLayer.Properties.Resources.icons8_funcionário_homem_80;
            this.pictureBox2.Location = new System.Drawing.Point(24, 713);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.BtnCadastrarFuncionario_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox3.Image = global::WfPresentationLayer.Properties.Resources.remove_administrator;
            this.pictureBox3.Location = new System.Drawing.Point(606, 713);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.BtnDesabilitados_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox4.Image = global::WfPresentationLayer.Properties.Resources.icons8_funcionário_homem_80__1_;
            this.pictureBox4.Location = new System.Drawing.Point(319, 713);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.BtnAlterarFuncionario_Click);
            // 
            // PctRefresh
            // 
            this.PctRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PctRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.PctRefresh.Image = global::WfPresentationLayer.Properties.Resources.icons8_actualizar_40;
            this.PctRefresh.Location = new System.Drawing.Point(1197, 713);
            this.PctRefresh.Name = "PctRefresh";
            this.PctRefresh.Size = new System.Drawing.Size(97, 59);
            this.PctRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctRefresh.TabIndex = 54;
            this.PctRefresh.TabStop = false;
            this.PctRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRefresh.ForeColor = System.Drawing.Color.White;
            this.BtnRefresh.Location = new System.Drawing.Point(1185, 704);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(118, 79);
            this.BtnRefresh.TabIndex = 53;
            this.BtnRefresh.Text = "         ";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Alteracao_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1318, 794);
            this.Controls.Add(this.PctRefresh);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnDesabilitados);
            this.Controls.Add(this.BtnDeletarFuncionario);
            this.Controls.Add(this.BtnAlterarFuncionario);
            this.Controls.Add(this.BtnCadastrarFuncionario);
            this.Controls.Add(this.pnlFunc);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Alteracao_Funcionario";
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Alteracao_Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridFuncionario)).EndInit();
            this.pnlFunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctRefresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridFuncionario;
        private Button BtnDesabilitados;
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox PctRefresh;
        private Button BtnRefresh;
    }
}