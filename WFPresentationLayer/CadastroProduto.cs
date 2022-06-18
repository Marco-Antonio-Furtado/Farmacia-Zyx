using BusinessLogicalLayer.BusinessLL;
using Entities;
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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void BtnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto(TxtBoxNomeProduto.Text, TxtBoxDescrisaoProduto.Text
                                                  , TxtBoxLaboratorio.Text);
            ProdutoBll produtoBll = new ProdutoBll();
            string resposta = produtoBll.Insert(produto).Message;
            MessageBox.Show(resposta);
            if (resposta == "iria pro banco")
            {
                this.Close();
            }


        }
    }
}
