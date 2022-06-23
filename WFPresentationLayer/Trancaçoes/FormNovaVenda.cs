using BusinessLogicalLayer.BusinessLL;
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
            SincronizarListaGrid(venda);
            LimparFormulario();
            
        }
        private void LimparFormulario()
        {
            TxtBoxCodigoProdutoVenda.Clear();
            CmbFormaPagamento.SelectedIndex = -0;
            TxtBoxQuantidade.Clear();
            TxtBoxValorUnitario.Clear();
        }
        private void SincronizarListaGrid(Item_Venda item)
        {
            DataGrid.Rows.Add(item.Produto, item.PrecoUnitario, item.Quantidade, item.ValorTotal, item.Laboratorio, item.NomeCliente, item.NomeFuncionario, item.Data);

        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DataGrid.SelectedRows[0];
            Vendas.RemoveAt(row.Index);
            DataGrid.Rows.RemoveAt(row.Index);

        }

        private void BtnCadastrarNovaVenda_Click(object sender, EventArgs e)
        {
            Iten_VendaBll novavenda = new Iten_VendaBll();
            /*ovavenda.Insert();*/
        }
    }
}
