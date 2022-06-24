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
            Item_Compra compra = new Item_Compra(produto: CmbBoxProduto.Text,
                                                 formaPagamento: CmbFormaPagamento.Text,
                                                 precoUnitario: double.Parse(TxtBoxUnitario.Text),
                                                 fornecedor: TxtBoxSelecionarFornecedor.Text,
                                                 quantidade: int.Parse(TxtBoxQuantidade.Text),
                                                 valorTotal: int.Parse(TxtBoxQuantidade.Text) * double.Parse(TxtBoxUnitario.Text),
                                                 nomeFuncionario: "admin",
                                                 data: DateTime.Value);
            compras.Add(compra);
            SincronizarListaGrid(compra);
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            CmbBoxProduto.SelectedIndex = -1;
            CmbFormaPagamento.SelectedIndex = -1;
            TxtBoxUnitario.Clear();
            TxtBoxQuantidade.Clear();
        }
        private void SincronizarListaGrid(Item_Compra item)
        {
            DataGrid.Rows.Add(item.Produto, item.PrecoUnitario, item.Quantidade, item.ValorTotal,item.FormaPagamento, item.NomeFuncionario,item.Fornecedor, item.Laboratorio, item.Data);
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DataGrid.SelectedRows[0];
            compras.RemoveAt(row.Index);
            DataGrid.Rows.RemoveAt(row.Index);
        }
        private void BtnCadastrarCompra_Click(object sender, EventArgs e)
        {
            
        }
        private void TxtBoxQuantidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (TxtBoxQuantidade.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void TxtBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (TxtBoxUnitario.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
