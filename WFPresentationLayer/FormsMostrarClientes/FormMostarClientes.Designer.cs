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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnAlterarCliente = new System.Windows.Forms.Button();
            this.BtnDeletarClientes = new System.Windows.Forms.Button();
            this.BtnProcurarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 521);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(12, 570);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(277, 79);
            this.BtnCadastrar.TabIndex = 22;
            this.BtnCadastrar.Text = "Cadastrar Cliente";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            // 
            // BtnAlterarCliente
            // 
            this.BtnAlterarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnAlterarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAlterarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnAlterarCliente.Location = new System.Drawing.Point(313, 570);
            this.BtnAlterarCliente.Name = "BtnAlterarCliente";
            this.BtnAlterarCliente.Size = new System.Drawing.Size(277, 79);
            this.BtnAlterarCliente.TabIndex = 23;
            this.BtnAlterarCliente.Text = "Alterar Cliente";
            this.BtnAlterarCliente.UseVisualStyleBackColor = false;
            // 
            // BtnDeletarClientes
            // 
            this.BtnDeletarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnDeletarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDeletarClientes.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarClientes.Location = new System.Drawing.Point(904, 570);
            this.BtnDeletarClientes.Name = "BtnDeletarClientes";
            this.BtnDeletarClientes.Size = new System.Drawing.Size(277, 79);
            this.BtnDeletarClientes.TabIndex = 24;
            this.BtnDeletarClientes.Text = "Deletar Cliente";
            this.BtnDeletarClientes.UseVisualStyleBackColor = false;
            // 
            // BtnProcurarCliente
            // 
            this.BtnProcurarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.BtnProcurarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProcurarCliente.ForeColor = System.Drawing.Color.White;
            this.BtnProcurarCliente.Location = new System.Drawing.Point(607, 570);
            this.BtnProcurarCliente.Name = "BtnProcurarCliente";
            this.BtnProcurarCliente.Size = new System.Drawing.Size(277, 79);
            this.BtnProcurarCliente.TabIndex = 25;
            this.BtnProcurarCliente.Text = "Deletar Cliente";
            this.BtnProcurarCliente.UseVisualStyleBackColor = false;
            // 
            // FormMostarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1193, 759);
            this.Controls.Add(this.BtnProcurarCliente);
            this.Controls.Add(this.BtnDeletarClientes);
            this.Controls.Add(this.BtnAlterarCliente);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMostarClientes";
            this.Text = "Mostrar Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnCadastrar;
        private Button BtnAlterarCliente;
        private Button BtnDeletarClientes;
        private Button BtnProcurarCliente;
    }
}