﻿using BusinessLogicalLayer.BusinessLL;
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

        private void BtnCadastrarProduto_Click(object sender, EventArgs e)
        {
            string preco = TxtBoxPrecoProduto.Text;
            if(TxtBoxPrecoProduto.Text == "   .")
            {
                preco = "0";
            }
            Produto produto = new Produto(TxtBoxNomeProduto.Text, TxtBoxDescrisaoProduto.Text
                                                  , TxtBoxLaboratorio.Text,double.Parse(preco));
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