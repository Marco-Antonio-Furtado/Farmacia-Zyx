using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfPresentationLayer
{
    public partial class MenuGeral : Form
    {
        public MenuGeral()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente();
            
            formCadastroCliente.ShowDialog();


        }

        private void TabProdutoCadstro_Click(object sender, EventArgs e)
        {
          CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.ShowDialog();

        }
}
}
