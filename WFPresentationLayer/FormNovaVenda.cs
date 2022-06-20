using Entities.enums;
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
    public partial class FormNovaVenda : Form
    {
        public FormNovaVenda()
        {
            InitializeComponent();
            CmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamento));
        }

        private void BtnNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente();
            formCadastroCliente.ShowDialog();
            
        }

        private void BtnNovoProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();
            formCadastroProduto.ShowDialog();
        }
    }
}
