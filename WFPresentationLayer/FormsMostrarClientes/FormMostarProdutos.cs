using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfPresentationLayer.Alteraçoes
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void BtnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroProduto Form = new FormCadastroProduto();   
            Form.ShowDialog();
        }
    }
}
