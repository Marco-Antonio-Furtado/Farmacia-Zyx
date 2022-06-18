namespace WfPresentationLayer
{
    partial class FormCadastroCliente
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
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxRgCliente = new System.Windows.Forms.TextBox();
            this.BtnCadastrarCliente = new System.Windows.Forms.Button();
            this.TxtBoxTelefone1Cliente = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmailCliente = new System.Windows.Forms.TextBox();
            this.TxtBoxCpfCLiente = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.TxtBoxTelefone2Cliente = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "RG";
            // 
            // TxtBoxRgCliente
            // 
            this.TxtBoxRgCliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxRgCliente.Location = new System.Drawing.Point(27, 337);
            this.TxtBoxRgCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxRgCliente.Name = "TxtBoxRgCliente";
            this.TxtBoxRgCliente.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxRgCliente.TabIndex = 50;
            this.TxtBoxRgCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCadastrarCliente
            // 
            this.BtnCadastrarCliente.Location = new System.Drawing.Point(255, 24);
            this.BtnCadastrarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCadastrarCliente.Name = "BtnCadastrarCliente";
            this.BtnCadastrarCliente.Size = new System.Drawing.Size(222, 135);
            this.BtnCadastrarCliente.TabIndex = 47;
            this.BtnCadastrarCliente.Text = "Cadastrar Cliente";
            this.BtnCadastrarCliente.UseVisualStyleBackColor = true;
            this.BtnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrarCliente_Click);
            // 
            // TxtBoxTelefone1Cliente
            // 
            this.TxtBoxTelefone1Cliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxTelefone1Cliente.Location = new System.Drawing.Point(27, 211);
            this.TxtBoxTelefone1Cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxTelefone1Cliente.Mask = "+55 (99) 90000-0000";
            this.TxtBoxTelefone1Cliente.Name = "TxtBoxTelefone1Cliente";
            this.TxtBoxTelefone1Cliente.Size = new System.Drawing.Size(193, 27);
            this.TxtBoxTelefone1Cliente.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Telefone 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Email";
            // 
            // txtBoxEmailCliente
            // 
            this.txtBoxEmailCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxEmailCliente.Location = new System.Drawing.Point(27, 103);
            this.txtBoxEmailCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmailCliente.Name = "txtBoxEmailCliente";
            this.txtBoxEmailCliente.Size = new System.Drawing.Size(203, 27);
            this.txtBoxEmailCliente.TabIndex = 43;
            // 
            // TxtBoxCpfCLiente
            // 
            this.TxtBoxCpfCLiente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxCpfCLiente.Location = new System.Drawing.Point(27, 156);
            this.TxtBoxCpfCLiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxCpfCLiente.Mask = "000,000,000-00";
            this.TxtBoxCpfCLiente.Name = "TxtBoxCpfCLiente";
            this.TxtBoxCpfCLiente.Size = new System.Drawing.Size(193, 27);
            this.TxtBoxCpfCLiente.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nome";
            // 
            // txtBoxNomeCliente
            // 
            this.txtBoxNomeCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxNomeCliente.Location = new System.Drawing.Point(27, 48);
            this.txtBoxNomeCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNomeCliente.Name = "txtBoxNomeCliente";
            this.txtBoxNomeCliente.Size = new System.Drawing.Size(203, 27);
            this.txtBoxNomeCliente.TabIndex = 39;
            // 
            // TxtBoxTelefone2Cliente
            // 
            this.TxtBoxTelefone2Cliente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxTelefone2Cliente.Location = new System.Drawing.Point(27, 282);
            this.TxtBoxTelefone2Cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxTelefone2Cliente.Mask = "+55 (99) 90000-0000";
            this.TxtBoxTelefone2Cliente.Name = "TxtBoxTelefone2Cliente";
            this.TxtBoxTelefone2Cliente.Size = new System.Drawing.Size(193, 27);
            this.TxtBoxTelefone2Cliente.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Telefone 2";
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 389);
            this.Controls.Add(this.TxtBoxTelefone2Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBoxRgCliente);
            this.Controls.Add(this.BtnCadastrarCliente);
            this.Controls.Add(this.TxtBoxTelefone1Cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxEmailCliente);
            this.Controls.Add(this.TxtBoxCpfCLiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNomeCliente);
            this.Name = "FormCadastroCliente";
            this.Text = "FormCadastroCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private TextBox TxtBoxRgCliente;
        private Button BtnCadastrarCliente;
        private MaskedTextBox TxtBoxTelefone1Cliente;
        private Label label5;
        private Label label4;
        private TextBox txtBoxEmailCliente;
        private MaskedTextBox TxtBoxCpfCLiente;
        private Label label2;
        private Label label1;
        private TextBox txtBoxNomeCliente;
        private MaskedTextBox TxtBoxTelefone2Cliente;
        private Label label3;
    }
}