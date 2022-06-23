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
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer.Trancaçoes
{
    public partial class FormNovaCompra : Form
    {
        public FormNovaCompra()
        {
            InitializeComponent();
        }   

        List<Item_Compra> compras = new List<Item_Compra>();

        private void BtnNovoFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor form = new FormCadastroFornecedor();
            form.ShowDialog();
        }

        private void BtnNovoProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new FormCadastroProduto();    
            formCadastroProduto.ShowDialog();
        }

        private void BtnNovoIten_Click(object sender, EventArgs e)
        {
            Item_Compra compra = new Item_Compra(produto: TxtBoxCodigoProdutoVenda.Text,
                                                 formaPagamento: CmbFormaPagamento.Text,
                                                 precoUnitario: double.Parse(TxtBoxValorUnitario.Text),
                                                 fornecedor: TxtBoxSelecionarFornecedor.Text,
                                                 quantidade: int.Parse(TxtBoxQuantidade.Text),
                                                 valorTotal: int.Parse(TxtBoxQuantidade.Text) * double.Parse(TxtBoxValorUnitario.Text),
                                                 nomeFuncionario: "admin",
                                                 data: DateTime.Value);
            compras.Add(compra);
            SincronizarListaGrid();
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            TxtBoxCodigoProdutoVenda.Clear();
            CmbFormaPagamento.SelectedIndex = -1;
            TxtBoxQuantidade.Clear();
            TxtBoxValorUnitario.Clear();
        }

        private void SincronizarListaGrid()
        {
            DataGrid.DataSource = null;
            DataGrid.DataSource = compras;
        }

    }
}
