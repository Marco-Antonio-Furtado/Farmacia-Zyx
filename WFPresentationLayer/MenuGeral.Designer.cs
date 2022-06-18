namespace WfPresentationLayer
{
    partial class MenuGeral
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabClienteCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.TabProdutoCadstro = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeVendasToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDeVendasToolStripMenuItem
            // 
            this.menuDeVendasToolStripMenuItem.Name = "menuDeVendasToolStripMenuItem";
            this.menuDeVendasToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.menuDeVendasToolStripMenuItem.Text = "Menu De Vendas";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TabClienteCadastro,
            this.TabProdutoCadstro,
            this.fornecedoresToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // TabClienteCadastro
            // 
            this.TabClienteCadastro.Name = "TabClienteCadastro";
            this.TabClienteCadastro.Size = new System.Drawing.Size(224, 26);
            this.TabClienteCadastro.Text = "Cliente";
            this.TabClienteCadastro.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // TabProdutoCadstro
            // 
            this.TabProdutoCadstro.Name = "TabProdutoCadstro";
            this.TabProdutoCadstro.Size = new System.Drawing.Size(224, 26);
            this.TabProdutoCadstro.Text = "Produto";
            this.TabProdutoCadstro.Click += new System.EventHandler(this.TabProdutoCadstro_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // MenuGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuGeral";
            this.Text = "CadastroCliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDeVendasToolStripMenuItem;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem TabClienteCadastro;
        private ToolStripMenuItem TabProdutoCadstro;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
    }
}