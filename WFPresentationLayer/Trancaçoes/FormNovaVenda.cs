using Entities;
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


        List<Item_Venda> Vendas = new List<Item_Venda>();
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

        private void BtnNovoIten_Click(object sender, EventArgs e)
        {
            Item_Venda venda = new Item_Venda(produto: TxtBoxCodigoProdutoVenda.Text,
                                              formaPagamento: CmbFormaPagamento.Text,
                                              precoUnitario: double.Parse(TxtBoxValorUnitario.Text),
                                              quantidade: int.Parse(TxtBoxQuantidade.Text),
                                              valorTotal: int.Parse(TxtBoxQuantidade.Text) * double.Parse(TxtBoxValorUnitario.Text),
                                              nomeFuncionario: "admin",
                                              nomeCliente: TxtBoxSelecionarCliente.Text,
                                              data: DateTime.Value);
            Vendas.Add(venda);
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
            DataGrid.DataSource = Vendas;
        }



    }
}
