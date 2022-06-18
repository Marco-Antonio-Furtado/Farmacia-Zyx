namespace WfPresentationLayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxRg = new System.Windows.Forms.TextBox();
            this.mtxtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.mtxtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tabEndereço = new System.Windows.Forms.TabPage();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPontoDeReferencia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabEndereço.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabEndereço);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 511);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCliente
            // 
            this.tabCliente.BackColor = System.Drawing.SystemColors.Window;
            this.tabCliente.Controls.Add(this.label6);
            this.tabCliente.Controls.Add(this.TxtBoxRg);
            this.tabCliente.Controls.Add(this.mtxtTelefone2);
            this.tabCliente.Controls.Add(this.label3);
            this.tabCliente.Controls.Add(this.btnProximo);
            this.tabCliente.Controls.Add(this.mtxtTelefone1);
            this.tabCliente.Controls.Add(this.label5);
            this.tabCliente.Controls.Add(this.label4);
            this.tabCliente.Controls.Add(this.txtEmail);
            this.tabCliente.Controls.Add(this.mtxtCpf);
            this.tabCliente.Controls.Add(this.label2);
            this.tabCliente.Controls.Add(this.label1);
            this.tabCliente.Controls.Add(this.txtNome);
            this.tabCliente.Location = new System.Drawing.Point(4, 29);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(615, 478);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "RG";
            // 
            // TxtBoxRg
            // 
            this.TxtBoxRg.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxRg.Location = new System.Drawing.Point(371, 75);
            this.TxtBoxRg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxRg.Name = "TxtBoxRg";
            this.TxtBoxRg.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxRg.TabIndex = 37;
            this.TxtBoxRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtTelefone2
            // 
            this.mtxtTelefone2.BackColor = System.Drawing.SystemColors.Window;
            this.mtxtTelefone2.Location = new System.Drawing.Point(57, 316);
            this.mtxtTelefone2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtTelefone2.Mask = "+55 (99) 90000-0000";
            this.mtxtTelefone2.Name = "mtxtTelefone2";
            this.mtxtTelefone2.Size = new System.Drawing.Size(193, 27);
            this.mtxtTelefone2.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Telefone2";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(47, 371);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(527, 61);
            this.btnProximo.TabIndex = 34;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // mtxtTelefone1
            // 
            this.mtxtTelefone1.BackColor = System.Drawing.SystemColors.Window;
            this.mtxtTelefone1.Location = new System.Drawing.Point(57, 248);
            this.mtxtTelefone1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtTelefone1.Mask = "+55 (99) 90000-0000";
            this.mtxtTelefone1.Name = "mtxtTelefone1";
            this.mtxtTelefone1.Size = new System.Drawing.Size(193, 27);
            this.mtxtTelefone1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(57, 139);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.BackColor = System.Drawing.SystemColors.Window;
            this.mtxtCpf.Location = new System.Drawing.Point(57, 193);
            this.mtxtCpf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(193, 27);
            this.mtxtCpf.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.Location = new System.Drawing.Point(57, 75);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 27);
            this.txtNome.TabIndex = 1;
            // 
            // tabEndereço
            // 
            this.tabEndereço.BackColor = System.Drawing.SystemColors.Window;
            this.tabEndereço.Controls.Add(this.btnCadastrar);
            this.tabEndereço.Controls.Add(this.label15);
            this.tabEndereço.Controls.Add(this.mtxtNumero);
            this.tabEndereço.Controls.Add(this.label14);
            this.tabEndereço.Controls.Add(this.txtEstado);
            this.tabEndereço.Controls.Add(this.label13);
            this.tabEndereço.Controls.Add(this.txtCidade);
            this.tabEndereço.Controls.Add(this.label12);
            this.tabEndereço.Controls.Add(this.txtPontoDeReferencia);
            this.tabEndereço.Controls.Add(this.label11);
            this.tabEndereço.Controls.Add(this.txtComplemento);
            this.tabEndereço.Controls.Add(this.label10);
            this.tabEndereço.Controls.Add(this.txtBairro);
            this.tabEndereço.Controls.Add(this.label9);
            this.tabEndereço.Controls.Add(this.txtRua);
            this.tabEndereço.Controls.Add(this.label8);
            this.tabEndereço.Controls.Add(this.mtxtCep);
            this.tabEndereço.Location = new System.Drawing.Point(4, 29);
            this.tabEndereço.Name = "tabEndereço";
            this.tabEndereço.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndereço.Size = new System.Drawing.Size(615, 478);
            this.tabEndereço.TabIndex = 1;
            this.tabEndereço.Text = "Endereço";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(57, 386);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(527, 61);
            this.btnCadastrar.TabIndex = 36;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(381, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Número";
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.BackColor = System.Drawing.SystemColors.Window;
            this.mtxtNumero.Location = new System.Drawing.Point(381, 295);
            this.mtxtNumero.Mask = "0999";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(125, 27);
            this.mtxtNumero.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.SystemColors.Window;
            this.txtEstado.Location = new System.Drawing.Point(381, 221);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(203, 27);
            this.txtEstado.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtCidade.Location = new System.Drawing.Point(381, 148);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(203, 27);
            this.txtCidade.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ponto de referência";
            // 
            // txtPontoDeReferencia
            // 
            this.txtPontoDeReferencia.BackColor = System.Drawing.SystemColors.Window;
            this.txtPontoDeReferencia.Location = new System.Drawing.Point(57, 295);
            this.txtPontoDeReferencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPontoDeReferencia.Name = "txtPontoDeReferencia";
            this.txtPontoDeReferencia.Size = new System.Drawing.Size(203, 27);
            this.txtPontoDeReferencia.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Complemento";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.SystemColors.Window;
            this.txtComplemento.Location = new System.Drawing.Point(57, 221);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(203, 27);
            this.txtComplemento.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.SystemColors.Window;
            this.txtBairro.Location = new System.Drawing.Point(381, 75);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(203, 27);
            this.txtBairro.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.SystemColors.Window;
            this.txtRua.Location = new System.Drawing.Point(57, 148);
            this.txtRua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(203, 27);
            this.txtRua.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "CEP";
            // 
            // mtxtCep
            // 
            this.mtxtCep.BackColor = System.Drawing.SystemColors.Window;
            this.mtxtCep.Location = new System.Drawing.Point(57, 75);
            this.mtxtCep.Mask = "00000-000";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(125, 27);
            this.mtxtCep.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.tabEndereço.ResumeLayout(false);
            this.tabEndereço.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCliente;
        private TabPage tabEndereço;
        private Label label1;
        private TextBox txtNome;
        private MaskedTextBox mtxtCep;
        private Label label2;
        private MaskedTextBox mtxtCpf;
        private MaskedTextBox mtxtTelefone1;
        private Label label5;
        private Label label4;
        private TextBox txtEmail;
        private Label label15;
        private MaskedTextBox mtxtNumero;
        private Label label14;
        private TextBox txtEstado;
        private Label label13;
        private TextBox txtCidade;
        private Label label12;
        private TextBox txtPontoDeReferencia;
        private Label label11;
        private TextBox txtComplemento;
        private Label label10;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtRua;
        private Label label8;
        private Button btnProximo;
        private Button btnCadastrar;
        private MaskedTextBox mtxtTelefone2;
        private Label label3;
        private Label label6;
        private TextBox TxtBoxRg;
    }
}