using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;
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
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }
        private void BtnCadastrarProduto_Click_1(object sender, EventArgs e)
        {
            string preco = TxtBoxPrecoProduto.Text;
            if (TxtBoxPrecoProduto.Text == "   .")
            {
                preco = "0";
            }

            //EU CRIEI UM LABORATORIO ALEAQTORIO SO PRA TESTAR, ESTÁ ERRADO, ARRUMA AI FRONT-END!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            Laboratorio lab = new Laboratorio(1, "Nome do lab", "123456");
            Produto produto = new Produto(TxtBoxNomeProduto.Text,TxtBoxDescrisaoProduto.Text,
                                         lab, double.Parse(preco));
            ProdutoBll produtoBll = new ProdutoBll();
            Response resposta = produtoBll.Insert(produto);
            MessageBox.Show(resposta.Message);
            if (resposta.HasSuccess)
            {
                this.Close();
            }
        }
    }
}
