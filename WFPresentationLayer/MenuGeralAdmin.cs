using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer
{
    public partial class MenuGeralAdmin : Form
    {
        public MenuGeralAdmin()
        {
            InitializeComponent();
        }
        
       

        private void NovaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovaVenda formNovaVenda = new FormNovaVenda();
            formNovaVenda.ShowDialog();
        }
        private void MenuFornecedorCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor formCadastroFornecedor = new FormCadastroFornecedor();
            formCadastroFornecedor.ShowDialog();
        }

        private void MenuProdutoCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto cadastroProduto = new FormCadastroProduto();
            cadastroProduto.ShowDialog();
        }

        private void MenuClienteCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente();
            formCadastroCliente.ShowDialog();
        }

        private void MenuFuncionarioCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario formCadastroFuncionario = new FormCadastroFuncionario();
            formCadastroFuncionario.ShowDialog();
        }
    }
}
