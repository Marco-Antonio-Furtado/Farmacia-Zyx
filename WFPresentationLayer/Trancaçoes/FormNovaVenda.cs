using Entities;
using Entities.enums;

namespace WfPresentationLayer
{
    public partial class FormNovaVenda : Form
    {
        public FormNovaVenda()
        {
            InitializeComponent();
            CmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamento));
            DataGrid.DataBindings.Add(nameof(DataGrid.BackgroundColor), this, nameof(Control.BackColor));
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
            Item_Venda venda = new Item_Venda(produto: CmbBoxProduto.Text,
                                              formaPagamento: CmbFormaPagamento.Text,
                                              precoUnitario: double.Parse(TxtBoxUnitario.Text),
                                              quantidade: int.Parse(TxtBoxQuantidade.Text),
                                              valorTotal: int.Parse(TxtBoxQuantidade.Text) * double.Parse(TxtBoxUnitario.Text),
                                              nomeFuncionario: "admin",
                                              nomeCliente: TxtBoxSelecionarCliente.Text,
                                              data: DateTime.Value);
            Vendas.Add(venda);
            SincronizarListaGrid(venda);
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            CmbBoxProduto.SelectedIndex = -1;
            CmbFormaPagamento.SelectedIndex = -1;
            TxtBoxQuantidade.Clear();
            TxtBoxUnitario.Clear();
        }
        private void SincronizarListaGrid(Item_Venda item)
        {
            DataGrid.Rows.Add(item.IDProduto, item.PrecoUnitario, item.Quantidade, item.ValorTotal, item.IDLaboratorio, item.IDNomeCliente, item.IDNomeFuncionario, item.Data);
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DataGrid.SelectedRows[0];
            Vendas.RemoveAt(row.Index);
            DataGrid.Rows.RemoveAt(row.Index);

        }
        private void BtnCadastrarNovaVenda_Click(object sender, EventArgs e)
        {
            
        }
        private void TxtBoxUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (TxtBoxUnitario.Text.Contains(','))
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
        private void TxtBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
