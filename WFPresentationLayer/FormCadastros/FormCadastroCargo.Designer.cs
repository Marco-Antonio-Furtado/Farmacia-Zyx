﻿namespace WfPresentationLayer.FormCadastros
{
    partial class FormCadastroCargo
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
            this.LblIdAlteracao = new System.Windows.Forms.Label();
            this.TxtBoxNomeCargo = new System.Windows.Forms.TextBox();
            this.BtnCadastrarCargo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblIdAlteracao
            // 
            this.LblIdAlteracao.AutoSize = true;
            this.LblIdAlteracao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblIdAlteracao.ForeColor = System.Drawing.Color.White;
            this.LblIdAlteracao.Location = new System.Drawing.Point(90, 29);
            this.LblIdAlteracao.Name = "LblIdAlteracao";
            this.LblIdAlteracao.Size = new System.Drawing.Size(108, 23);
            this.LblIdAlteracao.TabIndex = 93;
            this.LblIdAlteracao.Text = "Nome Cargo";
            // 
            // TxtBoxNomeCargo
            // 
            this.TxtBoxNomeCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtBoxNomeCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtBoxNomeCargo.ForeColor = System.Drawing.Color.White;
            this.TxtBoxNomeCargo.Location = new System.Drawing.Point(35, 80);
            this.TxtBoxNomeCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtBoxNomeCargo.Name = "TxtBoxNomeCargo";
            this.TxtBoxNomeCargo.Size = new System.Drawing.Size(224, 30);
            this.TxtBoxNomeCargo.TabIndex = 92;
            // 
            // BtnCadastrarCargo
            // 
            this.BtnCadastrarCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCadastrarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCadastrarCargo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCadastrarCargo.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrarCargo.Location = new System.Drawing.Point(35, 145);
            this.BtnCadastrarCargo.Name = "BtnCadastrarCargo";
            this.BtnCadastrarCargo.Size = new System.Drawing.Size(224, 60);
            this.BtnCadastrarCargo.TabIndex = 94;
            this.BtnCadastrarCargo.Text = "Cadastrar Cargo";
            this.BtnCadastrarCargo.UseVisualStyleBackColor = false;
            this.BtnCadastrarCargo.Click += new System.EventHandler(this.BtnCadastrarCargo_Click);
            // 
            // FormCadastroCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(292, 239);
            this.Controls.Add(this.BtnCadastrarCargo);
            this.Controls.Add(this.LblIdAlteracao);
            this.Controls.Add(this.TxtBoxNomeCargo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormCadastroCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroCargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblIdAlteracao;
        private TextBox TxtBoxNomeCargo;
        private Button BtnCadastrarCargo;
    }
}