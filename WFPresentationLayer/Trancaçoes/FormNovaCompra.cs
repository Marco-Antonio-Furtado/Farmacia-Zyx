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
            CmbBoxProduto.DisplayMember = "Nome";
            CmbBoxProduto.ValueMember = "ID";
            CmbBoxFornecedores.DisplayMember = "Razao_Social";
            CmbBoxFornecedores.ValueMember = "ID";
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
            
            string nome = "kkkkkk";
            
            int IdProduto = (int)CmbBoxProduto.SelectedValue;
            int IdFornecedor = (int)CmbBoxFornecedores.SelectedValue;
            
            Produto proCompra = produtoBLL.GetByID(IdProduto).Item;
            Fornecedor forneCompra = fornecedorBLL.GetByID(IdFornecedor).Item;

            Item_Compra compraTela = new Item_Compra();
            compraTela.NomeProduto = Convert.ToString(proCompra.Nome);
            compraTela.PrecoUnitario = proCompra.Valor_Venda;
            compraTela.Quantidade = int.Parse(TxtBoxQuantidade.Text);
            compraTela.IDFornecedor = forneCompra.Razao_Social;
            compraTela.FormaPagamento = CmbFormaPagamento.Text;
            compraTela.IDNomeFuncionario = SystemParameters.GetNome();
            compraTela.IDLaboratorio = proCompra.ID_Laboratorio.Razao_Social.ToString();    
            compraTela.Data = DateTime.Value;
            compraTela.ValorTotal = int.Parse(TxtBoxQuantidade.Text) * proCompra.Valor_Venda;
            compraTela.FormaPagamento = CmbFormaPagamento.Text;

            //Item_Compra compraBanco = new Item_Compra();
            //compraBanco.IDProduto = proCompra.ID;
            //compraBanco.IDFornecedor = forneCompra.Razao_Social;
            //compraBanco.PrecoUnitario = proCompra.Valor_Venda;
            //compraBanco.FormaPagamento = CmbFormaPagamento.Text;
            //compraBanco.Quantidade = int.Parse(TxtBoxQuantidade.Text);
            //compraBanco.IDNomeFuncionario = SystemParameters.GetNome();
            //compraBanco.IDLaboratorio = proCompra.ID_Laboratorio.Razao_Social.ToString();
            //compraBanco.Data = DateTime.Value;
            //compraBanco.ValorTotal = int.Parse(TxtBoxQuantidade.Text) * proCompra.Valor_Venda;
            //compraBanco.FormaPagamento = CmbFormaPagamento.Text;

            compras.Add(compraTela);
            SincronizarListaGrid(compraTela);
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            CmbBoxProduto.SelectedIndex = -1;
            CmbFormaPagamento.SelectedIndex = -1;
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
            

            CmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamento));
        }
    }
}
