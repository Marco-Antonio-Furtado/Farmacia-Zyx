namespace WfPresentationLayer.FormsMostrarClientes
{
    partial class FormMostarLaboratorio
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
            this.PNLLaboratorio = new System.Windows.Forms.Panel();
            this.GridLaboratorio = new System.Windows.Forms.DataGridView();
            this.GridID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridRazaosocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridNomeResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDesabilitados = new System.Windows.Forms.Button();
            this.BtnDeletarLaboratorio = new System.Windows.Forms.Button();
            this.BtnAlterarLaboratorio = new System.Windows.Forms.Button();
            this.BtnCadastrarlaboratorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PNLLaboratorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLaboratorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PNLLaboratorio
            // 
            this.PNLLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.PNLLaboratorio.Controls.Add(this.GridLaboratorio);
            this.PNLLaboratorio.Location = new System.Drawing.Point(18, 12);
            this.PNLLaboratorio.Name = "PNLLaboratorio";
            this.PNLLaboratorio.Size = new System.Drawing.Size(1308, 693);
            this.PNLLaboratorio.TabIndex = 31;
            // 
            // GridLaboratorio
            // 
            this.GridLaboratorio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridLaboratorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridLaboratorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLaboratorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.GridLaboratorio.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridLaboratorio.Location = new System.Drawing.Point(-6, 0);
            this.GridLaboratorio.Name = "GridLaboratorio";
            this.GridLaboratorio.ReadOnly = true;
            this.GridLaboratorio.RowHeadersWidth = 51;
            this.GridLaboratorio.RowTemplate.Height = 29;
            this.GridLaboratorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridLaboratorio.Size = new System.Drawing.Size(1307, 690);
            this.GridLaboratorio.TabIndex = 32;
            // 
            // GridID
            // 
            this.GridID.HeaderText = "ID";
            this.GridID.MinimumWidth = 6;
            this.GridID.Name = "GridID";
            this.GridID.ReadOnly = true;
            this.GridID.Width = 75;
            // 
            // GridRazaosocial
            // 
            this.GridRazaosocial.HeaderText = "Razão Social";
            this.GridRazaosocial.MinimumWidth = 6;
            this.GridRazaosocial.Name = "GridRazaosocial";
            this.GridRazaosocial.ReadOnly = true;
            this.GridRazaosocial.Width = 175;
            // 
            // GridTelefone
            // 
            this.GridTelefone.HeaderText = "Telefone";
            this.GridTelefone.MinimumWidth = 6;
            this.GridTelefone.Name = "GridTelefone";
            this.GridTelefone.ReadOnly = true;
            this.GridTelefone.Width = 125;
            // 
            // GridNomeResponsavel
            // 
            this.GridNomeResponsavel.HeaderText = "Nome Responsavel";
            this.GridNomeResponsavel.MinimumWidth = 6;
            this.GridNomeResponsavel.Name = "GridNomeResponsavel";
            this.GridNomeResponsavel.ReadOnly = true;
            this.GridNomeResponsavel.Width = 200;
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
            this.GridCNPJ.HeaderText = "CNPJ";
            this.GridCNPJ.MinimumWidth = 6;
            this.GridCNPJ.Name = "GridCNPJ";
            this.GridCNPJ.ReadOnly = true;
            this.GridCNPJ.Width = 125;
            // 
            // BtnDesabilitados
            // 
            this.BtnDesabilitados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDesabilitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDesabilitados.ForeColor = System.Drawing.Color.White;
            this.BtnDesabilitados.Location = new System.Drawing.Point(702, 711);
            this.BtnDesabilitados.Name = "BtnDesabilitados";
            this.BtnDesabilitados.Size = new System.Drawing.Size(277, 79);
            this.BtnDesabilitados.TabIndex = 30;
            this.BtnDesabilitados.Text = "Mostrar Laboratorios Desabilitados";
            this.BtnDesabilitados.UseVisualStyleBackColor = false;
            this.BtnDesabilitados.Click += new System.EventHandler(this.BtnDesabilitados_Click);
            // 
            // BtnDeletarLaboratorio
            // 
            this.BtnDeletarLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarLaboratorio.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarLaboratorio.Location = new System.Drawing.Point(1011, 711);
            this.BtnDeletarLaboratorio.Name = "BtnDeletarLaboratorio";
            this.BtnDeletarLaboratorio.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarLaboratorio.TabIndex = 29;
            this.BtnDeletarLaboratorio.Text = "       Deletar/Desabilitar Laboratorio";
            this.BtnDeletarLaboratorio.UseVisualStyleBackColor = false;
            this.BtnDeletarLaboratorio.Click += new System.EventHandler(this.BtnDeletarLaboratorio_Click);
            // 
            // BtnAlterarLaboratorio
            // 
            this.BtnAlterarLaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarLaboratorio.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarLaboratorio.Location = new System.Drawing.Point(379, 711);
            this.BtnAlterarLaboratorio.Name = "BtnAlterarLaboratorio";
            this.BtnAlterarLaboratorio.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarLaboratorio.TabIndex = 28;
            this.BtnAlterarLaboratorio.Text = "Alterar / Habilitar   Laboratorio";
            this.BtnAlterarLaboratorio.UseVisualStyleBackColor = false;
            this.BtnAlterarLaboratorio.Click += new System.EventHandler(this.BtnAlterarLaboratorio_Click);
            // 
            // BtnCadastrarlaboratorio
            // 
            this.BtnCadastrarlaboratorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrarlaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarlaboratorio.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarlaboratorio.Location = new System.Drawing.Point(54, 711);
            this.BtnCadastrarlaboratorio.Name = "BtnCadastrarlaboratorio";
            this.BtnCadastrarlaboratorio.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrarlaboratorio.TabIndex = 27;
            this.BtnCadastrarlaboratorio.Text = "           Cadastrar Laboratorio";
            this.BtnCadastrarlaboratorio.UseVisualStyleBackColor = false;
            this.BtnCadastrarlaboratorio.Click += new System.EventHandler(this.BtnCadastrarlaboratorio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox1.Image = global::WfPresentationLayer.Properties.Resources.delete__v1;
            this.pictureBox1.Location = new System.Drawing.Point(1023, 720);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.BtnDeletarLaboratorio_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.pictureBox2.Image = global::WfPresentationLayer.Properties.Resources.thin_test_tube;
            this.pictureBox2.Location = new System.Drawing.Point(68, 720);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.BtnCadastrarlaboratorio_Click);
            // 
            // FormMostarLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1343, 802);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PNLLaboratorio);
            this.Controls.Add(this.BtnDesabilitados);
            this.Controls.Add(this.BtnDeletarLaboratorio);
            this.Controls.Add(this.BtnAlterarLaboratorio);
            this.Controls.Add(this.BtnCadastrarlaboratorio);
            this.Name = "FormMostarLaboratorio";
            this.Text = "FormMostarLaboratorio";
            this.Load += new System.EventHandler(this.FormMostarLaboratorio_Load);
            this.PNLLaboratorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLaboratorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PNLLaboratorio;
        private Button BtnDesabilitados;
        private Button BtnDeletarLaboratorio;
        private Button BtnAlterarLaboratorio;
        private Button BtnCadastrarlaboratorio;
        private DataGridView GridLaboratorio;
        private DataGridViewTextBoxColumn GridID;
        private DataGridViewTextBoxColumn GridRazaosocial;
        private DataGridViewTextBoxColumn GridTelefone;
        private DataGridViewTextBoxColumn GridNomeResponsavel;
        private DataGridViewTextBoxColumn GridEmail;
        private DataGridViewTextBoxColumn GridCNPJ;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}