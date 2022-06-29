using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.enums;
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer.Trancaçoes
{
    public partial class FormNovaCompra : Form
    {
        public FormNovaCompra()
        {
            InitializeComponent();
        }
        FornecedorBll fornecedorBLL = new FornecedorBll();
        ProdutoBll produtoBLL = new ProdutoBll();
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
            Item_Compra compra = new Item_Compra(produto: CmbBoxProduto.ValueMember,
                                                 formaPagamento: CmbFormaPagamento.Text,
                                                 precoUnitario: double.Parse(TxtBoxUnitario.Text),
                                                 fornecedor: CmbBoxFornecedores.ValueMember,
                                                 quantidade: int.Parse(TxtBoxQuantidade.Text),
                                                 valorTotal: int.Parse(TxtBoxQuantidade.Text) * double.Parse(TxtBoxUnitario.Text),
                                                 nomeFuncionario: SystemParameters.GetNome(),
                                                 data: DateTime.Value) ;
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
            DataGrid.Rows.Add(item.IDProduto, item.PrecoUnitario, item.Quantidade, item.ValorTotal,item.FormaPagamento, item.IDNomeFuncionario,item.IDFornecedor, item.IDLaboratorio, item.Data);
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
            //aceita apenas números, tecla backspace.
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
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

        private void FormNovaCompra_Load(object sender, EventArgs e)
        {
            List<Fornecedor> fornecedors = fornecedorBLL.GetAll().Dados;
            foreach (Fornecedor fornecedor in fornecedors)
            {
                if (fornecedor.Ativo == true)
                {
                    CmbBoxFornecedores.Items.Add(fornecedor);
                } 
            }
            CmbBoxFornecedores.DisplayMember = "Razao_Social";
            CmbBoxFornecedores.ValueMember = "ID";

            List<Produto> produtos = produtoBLL.GetAll().Dados;
            foreach (Produto Produto in produtos)
            {
                if (Produto.Ativo == true)
                {
                    CmbBoxProduto.Items.Add(Produto);
                }
            }
            CmbBoxProduto.DisplayMember = "Nome";
            CmbBoxProduto.ValueMember = "ID";

            CmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamento));
        }
    }
}
