namespace WfPresentationLayer
{
    partial class FormCadastroFuncionario
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
            this.TabGeral = new System.Windows.Forms.TabControl();
            this.TabFuncionario = new System.Windows.Forms.TabPage();
            this.LblIDfunci = new System.Windows.Forms.Label();
            this.TxtBoxIDfunci = new System.Windows.Forms.MaskedTextBox();
            this.CmbBoxCargos = new System.Windows.Forms.ComboBox();
            this.BtnCadastroEndereco = new System.Windows.Forms.Button();
            this.TxtBoxSenhaFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxRgFuncionario = new System.Windows.Forms.TextBox();
            this.TxtBoxTelefone1Funcionario = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEmailFuncionario = new System.Windows.Forms.TextBox();
            this.TxtBoxCpfFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNomeFuncionario = new System.Windows.Forms.TextBox();
            this.TabEndereco = new System.Windows.Forms.TabPage();
            this.CmbBoxEstado = new System.Windows.Forms.ComboBox();
            this.CmbBoxCidade = new System.Windows.Forms.ComboBox();
            this.TxtBoxNumero = new System.Windows.Forms.TextBox();
            this.BtnCadastroFuncionario = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBoxRua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.ImageBtnFechar = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnCadastrarCargo = new System.Windows.Forms.Button();
            this.TabGeral.SuspendLayout();
            this.TabFuncionario.SuspendLayout();
            this.TabEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeral
            // 
            this.TabGeral.AccessibleName = "";
            this.TabGeral.Controls.Add(this.TabFuncionario);
            this.TabGeral.Controls.Add(this.TabEndereco);
            this.TabGeral.Location = new System.Drawing.Point(2, 32);
            this.TabGeral.Name = "TabGeral";
            this.TabGeral.SelectedIndex = 0;
            this.TabGeral.Size = new System.Drawing.Size(485, 505);
            this.TabGeral.TabIndex = 70;
            // 
            // TabFuncionario
            // 
            this.TabFuncionario.BackColor = System.Drawing.Color.IndianRed;
            this.TabFuncionario.Controls.Add(this.BtnCadastrarCargo);
            this.TabFuncionario.Controls.Add(this.LblIDfunci);
            this.TabFuncionario.Controls.Add(this.TxtBoxIDfunci);
            this.TabFuncionario.Controls.Add(this.CmbBoxCargos);
            this.TabFuncionario.Controls.Add(this.BtnCadastroEndereco);
            this.TabFuncionario.Controls.Add(this.TxtBoxSenhaFuncionario);
            this.TabFuncionario.Controls.Add(this.label3);
            this.TabFuncionario.Controls.Add(this.label6);
            this.TabFuncionario.Controls.Add(this.TxtBoxRgFuncionario);
            this.TabFuncionario.Controls.Add(this.TxtBoxTelefone1Funcionario);
            this.TabFuncionario.Controls.Add(this.label5);
            this.TabFuncionario.Controls.Add(this.label4);
            this.TabFuncionario.Controls.Add(this.txtBoxEmailFuncionario);
            this.TabFuncionario.Controls.Add(this.TxtBoxCpfFuncionario);
            this.TabFuncionario.Controls.Add(this.label2);
            this.TabFuncionario.Controls.Add(this.label1);
            this.TabFuncionario.Controls.Add(this.txtBoxNomeFuncionario);
            this.TabFuncionario.ForeColor = System.Drawing.Color.White;
            this.TabFuncionario.Location = new System.Drawing.Point(4, 29);
            this.TabFuncionario.Name = "TabFuncionario";
            this.TabFuncionario.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabFuncionario.Size = new System.Drawing.Size(477, 472);
            this.TabFuncionario.TabIndex = 0;
            this.TabFuncionario.Text = "Funcionario";
            // 
            // LblIDfunci
            // 
            this.LblIDfunci.AutoSize = true;
            this.LblIDfunci.Enabled = false;
            this.LblIDfunci.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIDfunci.ForeColor = System.Drawing.Color.White;
            this.LblIDfunci.Location = new System.Drawing.Point(15, 369);
            this.LblIDfunci.Name = "LblIDfunci";
            this.LblIDfunci.Size = new System.Drawing.Size(104, 23);
            this.LblIDfunci.TabIndex = 94;
            this.LblIDfunci.Text = "ID Alteracao";
            // 
            // TxtBoxIDfunci
            // 
            this.TxtBoxIDfunci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxIDfunci.Enabled = false;
            this.TxtBoxIDfunci.ForeColor = System.Drawing.Color.White;
            this.TxtBoxIDfunci.Location = new System.Drawing.Point(16, 396);
            this.TxtBoxIDfunci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxIDfunci.Name = "TxtBoxIDfunci";
            this.TxtBoxIDfunci.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxIDfunci.TabIndex = 93;
            // 
            // CmbBoxCargos
            // 
            this.CmbBoxCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmbBoxCargos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxCargos.FormattingEnabled = true;
            this.CmbBoxCargos.Location = new System.Drawing.Point(230, 256);
            this.CmbBoxCargos.Name = "CmbBoxCargos";
            this.CmbBoxCargos.Size = new System.Drawing.Size(223, 28);
            this.CmbBoxCargos.TabIndex = 84;
            // 
            // BtnCadastroEndereco
            // 
            this.BtnCadastroEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastroEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastroEndereco.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroEndereco.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroEndereco.Location = new System.Drawing.Point(229, 41);
            this.BtnCadastroEndereco.Name = "BtnCadastroEndereco";
            this.BtnCadastroEndereco.Size = new System.Drawing.Size(224, 199);
            this.BtnCadastroEndereco.TabIndex = 83;
            this.BtnCadastroEndereco.Text = "Cadastrar Endereço";
            this.BtnCadastroEndereco.UseVisualStyleBackColor = false;
            this.BtnCadastroEndereco.Click += new System.EventHandler(this.BtnCadastroEndereco_Click_1);
            // 
            // TxtBoxSenhaFuncionario
            // 
            this.TxtBoxSenhaFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxSenhaFuncionario.ForeColor = System.Drawing.Color.White;
            this.TxtBoxSenhaFuncionario.Location = new System.Drawing.Point(15, 157);
            this.TxtBoxSenhaFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxSenhaFuncionario.Name = "TxtBoxSenhaFuncionario";
            this.TxtBoxSenhaFuncionario.PasswordChar = '*';
            this.TxtBoxSenhaFuncionario.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxSenhaFuncionario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 79;
            this.label3.Text = "Insira sua senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 78;
            this.label6.Text = "RG";
            // 
            // TxtBoxRgFuncionario
            // 
            this.TxtBoxRgFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxRgFuncionario.ForeColor = System.Drawing.Color.White;
            this.TxtBoxRgFuncionario.Location = new System.Drawing.Point(15, 331);
            this.TxtBoxRgFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxRgFuncionario.Name = "TxtBoxRgFuncionario";
            this.TxtBoxRgFuncionario.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxRgFuncionario.TabIndex = 6;
            this.TxtBoxRgFuncionario.Text = "Digite o Rg";
            this.TxtBoxRgFuncionario.Enter += new System.EventHandler(this.TxtBoxRgFuncionario_Enter);
            this.TxtBoxRgFuncionario.Leave += new System.EventHandler(this.TxtBoxRgFuncionario_Enter);
            // 
            // TxtBoxTelefone1Funcionario
            // 
            this.TxtBoxTelefone1Funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxTelefone1Funcionario.ForeColor = System.Drawing.Color.White;
            this.TxtBoxTelefone1Funcionario.Location = new System.Drawing.Point(15, 273);
            this.TxtBoxTelefone1Funcionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxTelefone1Funcionario.Mask = "+55 (99) 90000-0000";
            this.TxtBoxTelefone1Funcionario.Name = "TxtBoxTelefone1Funcionario";
            this.TxtBoxTelefone1Funcionario.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxTelefone1Funcionario.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 75;
            this.label5.Text = "Telefone 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 74;
            this.label4.Text = "Email";
            // 
            // txtBoxEmailFuncionario
            // 
            this.txtBoxEmailFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBoxEmailFuncionario.ForeColor = System.Drawing.Color.White;
            this.txtBoxEmailFuncionario.Location = new System.Drawing.Point(15, 99);
            this.txtBoxEmailFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmailFuncionario.Name = "txtBoxEmailFuncionario";
            this.txtBoxEmailFuncionario.Size = new System.Drawing.Size(203, 27);
            this.txtBoxEmailFuncionario.TabIndex = 2;
            this.txtBoxEmailFuncionario.Text = "Digite o Email";
            this.txtBoxEmailFuncionario.Enter += new System.EventHandler(this.txtBoxEmailFuncionario_Enter);
            this.txtBoxEmailFuncionario.Leave += new System.EventHandler(this.txtBoxEmailFuncionario_Enter);
            // 
            // TxtBoxCpfFuncionario
            // 
            this.TxtBoxCpfFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxCpfFuncionario.ForeColor = System.Drawing.Color.White;
            this.TxtBoxCpfFuncionario.Location = new System.Drawing.Point(15, 215);
            this.TxtBoxCpfFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxCpfFuncionario.Mask = "000,000,000-00";
            this.TxtBoxCpfFuncionario.Name = "TxtBoxCpfFuncionario";
            this.TxtBoxCpfFuncionario.Size = new System.Drawing.Size(203, 27);
            this.TxtBoxCpfFuncionario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 71;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nome";
            // 
            // txtBoxNomeFuncionario
            // 
            this.txtBoxNomeFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtBoxNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.txtBoxNomeFuncionario.Location = new System.Drawing.Point(15, 41);
            this.txtBoxNomeFuncionario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNomeFuncionario.Name = "txtBoxNomeFuncionario";
            this.txtBoxNomeFuncionario.Size = new System.Drawing.Size(203, 27);
            this.txtBoxNomeFuncionario.TabIndex = 1;
            this.txtBoxNomeFuncionario.Text = "Digite o Nome";
            this.txtBoxNomeFuncionario.Enter += new System.EventHandler(this.txtBoxNomeFuncionario_Enter);
            // 
            // TabEndereco
            // 
            this.TabEndereco.BackColor = System.Drawing.Color.IndianRed;
            this.TabEndereco.Controls.Add(this.CmbBoxEstado);
            this.TabEndereco.Controls.Add(this.CmbBoxCidade);
            this.TabEndereco.Controls.Add(this.TxtBoxNumero);
            this.TabEndereco.Controls.Add(this.BtnCadastroFuncionario);
            this.TabEndereco.Controls.Add(this.label15);
            this.TabEndereco.Controls.Add(this.label14);
            this.TabEndereco.Controls.Add(this.label13);
            this.TabEndereco.Controls.Add(this.label9);
            this.TabEndereco.Controls.Add(this.TxtBoxRua);
            this.TabEndereco.Controls.Add(this.label8);
            this.TabEndereco.Controls.Add(this.TxtBoxCep);
            this.TabEndereco.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TabEndereco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TabEndereco.Location = new System.Drawing.Point(4, 29);
            this.TabEndereco.Name = "TabEndereco";
            this.TabEndereco.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabEndereco.Size = new System.Drawing.Size(477, 472);
            this.TabEndereco.TabIndex = 1;
            this.TabEndereco.Text = "Endereco";
            // 
            // CmbBoxEstado
            // 
            this.CmbBoxEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmbBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxEstado.FormattingEnabled = true;
            this.CmbBoxEstado.Location = new System.Drawing.Point(251, 55);
            this.CmbBoxEstado.Name = "CmbBoxEstado";
            this.CmbBoxEstado.Size = new System.Drawing.Size(201, 31);
            this.CmbBoxEstado.Sorted = true;
            this.CmbBoxEstado.TabIndex = 87;
            this.CmbBoxEstado.SelectedIndexChanged += new System.EventHandler(this.CmbBoxEstado_SelectedIndexChanged_1);
            // 
            // CmbBoxCidade
            // 
            this.CmbBoxCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbBoxCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CmbBoxCidade.Enabled = false;
            this.CmbBoxCidade.FormattingEnabled = true;
            this.CmbBoxCidade.Location = new System.Drawing.Point(251, 145);
            this.CmbBoxCidade.Name = "CmbBoxCidade";
            this.CmbBoxCidade.Size = new System.Drawing.Size(201, 31);
            this.CmbBoxCidade.TabIndex = 85;
            this.CmbBoxCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbBoxCidade_KeyPress);
            // 
            // TxtBoxNumero
            // 
            this.TxtBoxNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxNumero.ForeColor = System.Drawing.Color.White;
            this.TxtBoxNumero.Location = new System.Drawing.Point(18, 227);
            this.TxtBoxNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxNumero.Name = "TxtBoxNumero";
            this.TxtBoxNumero.Size = new System.Drawing.Size(203, 30);
            this.TxtBoxNumero.TabIndex = 86;
            // 
            // BtnCadastroFuncionario
            // 
            this.BtnCadastroFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastroFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastroFuncionario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastroFuncionario.ForeColor = System.Drawing.Color.White;
            this.BtnCadastroFuncionario.Location = new System.Drawing.Point(17, 273);
            this.BtnCadastroFuncionario.Name = "BtnCadastroFuncionario";
            this.BtnCadastroFuncionario.Size = new System.Drawing.Size(434, 101);
            this.BtnCadastroFuncionario.TabIndex = 85;
            this.BtnCadastroFuncionario.Text = "Cadastrar Funcionario";
            this.BtnCadastroFuncionario.UseVisualStyleBackColor = false;
            this.BtnCadastroFuncionario.Click += new System.EventHandler(this.BtnCadastroFuncionario_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(17, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 23);
            this.label15.TabIndex = 64;
            this.label15.Text = "Número";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(251, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 23);
            this.label14.TabIndex = 62;
            this.label14.Text = "Estado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(251, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 23);
            this.label13.TabIndex = 60;
            this.label13.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 23);
            this.label9.TabIndex = 52;
            this.label9.Text = "Rua";
            // 
            // TxtBoxRua
            // 
            this.TxtBoxRua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxRua.ForeColor = System.Drawing.Color.White;
            this.TxtBoxRua.Location = new System.Drawing.Point(18, 145);
            this.TxtBoxRua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxRua.Name = "TxtBoxRua";
            this.TxtBoxRua.Size = new System.Drawing.Size(203, 30);
            this.TxtBoxRua.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 50;
            this.label8.Text = "CEP";
            // 
            // TxtBoxCep
            // 
            this.TxtBoxCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxCep.ForeColor = System.Drawing.Color.White;
            this.TxtBoxCep.Location = new System.Drawing.Point(18, 55);
            this.TxtBoxCep.Mask = "00000-000";
            this.TxtBoxCep.Name = "TxtBoxCep";
            this.TxtBoxCep.Size = new System.Drawing.Size(125, 30);
            this.TxtBoxCep.TabIndex = 10;
            // 
            // ImageBtnFechar
            // 
            this.ImageBtnFechar.Image = global::WfPresentationLayer.Properties.Resources.delete_sign;
            this.ImageBtnFechar.Location = new System.Drawing.Point(419, 3);
            this.ImageBtnFechar.Name = "ImageBtnFechar";
            this.ImageBtnFechar.Size = new System.Drawing.Size(69, 28);
            this.ImageBtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBtnFechar.TabIndex = 93;
            this.ImageBtnFechar.TabStop = false;
            this.ImageBtnFechar.Click += new System.EventHandler(this.ImageBtnFechar_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(127, 5);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(173, 23);
            this.LblTitulo.TabIndex = 94;
            this.LblTitulo.Text = "Cadastro Funcionario";
            // 
            // BtnCadastrarCargo
            // 
            this.BtnCadastrarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastrarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrarCargo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCargo.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCargo.Location = new System.Drawing.Point(229, 304);
            this.BtnCadastrarCargo.Name = "BtnCadastrarCargo";
            this.BtnCadastrarCargo.Size = new System.Drawing.Size(144, 119);
            this.BtnCadastrarCargo.TabIndex = 95;
            this.BtnCadastrarCargo.Text = "Cadastrar Cargo";
            this.BtnCadastrarCargo.UseVisualStyleBackColor = false;
            this.BtnCadastrarCargo.Click += new System.EventHandler(this.BtnCadastrarCargo_Click_1);
            // 
            // FormCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(489, 539);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.ImageBtnFechar);
            this.Controls.Add(this.TabGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroFuncionario";
            this.TabGeral.ResumeLayout(false);
            this.TabFuncionario.ResumeLayout(false);
            this.TabFuncionario.PerformLayout();
            this.TabEndereco.ResumeLayout(false);
            this.TabEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBtnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl TabGeral;
        private TabPage TabFuncionario;
        private MaskedTextBox TxtBoxSenhaFuncionario;
        private Label label3;
        private Label label6;
        private TextBox TxtBoxRgFuncionario;
        private MaskedTextBox TxtBoxTelefone1Funcionario;
        private Label label5;
        private Label label4;
        private TextBox txtBoxEmailFuncionario;
        private MaskedTextBox TxtBoxCpfFuncionario;
        private Label label2;
        private Label label1;
        private TextBox txtBoxNomeFuncionario;
        private TabPage TabEndereco;
        private Label label15;
        private Label label14;
        private TextBox TxtBoxEstado;
        private Label label13;
        private TextBox TxtBoxCidade;
        private Label label9;
        private TextBox TxtBoxRua;
        private Label label8;
        private MaskedTextBox TxtBoxCep;
        private Button BtnCadastroEndereco;
        private Button BtnCadastroFuncionario;
        private ComboBox CmbBoxCargos;
        private TextBox TxtBoxNumero;
        private ComboBox CmbBoxEstado;
        private ComboBox CmbBoxCidade;
        private PictureBox ImageBtnFechar;
        private Label LblTitulo;
        private Label LblIdEndereco;
        private TextBox TxtBoxIDEndereco;
        private Label LblIDfunci;
        public MaskedTextBox TxtBoxIDfunci;
        private Button BtnCadastrarCargo;
    }
}