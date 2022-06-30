using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.enums;
using Entities.Propriedades;
using Shared;
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
        EntradaBll entradaBLL = new EntradaBll();
        
        List<Item> ItemsEntrada = new List<Item>();
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
            if (CmbBoxProduto.Text == "")
            {
                MeuMessageBox.Show("Voce nao selecionou Produto");
            }
            else if (CmbFormaPagamento.Text == "")
            {
                MeuMessageBox.Show("voce nao colocou a opcao de forma de pagamento");
            }
            else if (TxtBoxQuantidade.Text == "") { MeuMessageBox.Show("voce nao colocou a Quantidade");  }
            else if(CmbBoxFornecedores.Text == "") { MeuMessageBox.Show("voce nao colocou o fornecedor"); }
            else
            {
                
                Item item = new Item();

                item.IDProduto = (int)CmbBoxProduto.SelectedValue;
                Produto proselcionado = produtoBLL.GetByID(item.IDProduto).Item;
                item.Preco = proselcionado.Valor_Venda;
                item.Qtd = int.Parse(TxtBoxQuantidade.Text);

                ItemsEntrada.Add(item);
                SincronizarListaGrid(item);
                LimparFormulario();
            }
        }
        private void LimparFormulario()
        {
            CmbBoxFornecedores.Enabled = false;
            CmbFormaPagamento.Enabled = false;
            DateTime.Enabled = false;
            CmbBoxProduto.SelectedIndex = -1;
            TxtBoxQuantidade.Clear();
        }
        private void SincronizarListaGrid(Item item)
        {
            DataGrid.Rows.Add(CmbBoxProduto.Text, item.Preco, item.Qtd,(item.Preco * item.Qtd), CmbFormaPagamento.Text, SystemParameters.GetNome(), CmbBoxFornecedores.Text,DateTime.Value);
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DataGrid.SelectedRows[0];
            ItemsEntrada.RemoveAt(row.Index);
            DataGrid.Rows.RemoveAt(row.Index);
        }
        private void BtnCadastrarCompra_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            double soma = 0;
            foreach (Item item in ItemsEntrada)
            {
                 soma += (item.Preco * item.Qtd);
            }
            entrada.ValorTotal = soma; 
            entrada.IDFornecedor = (int)CmbBoxFornecedores.SelectedValue;
            entrada.Items = ItemsEntrada;
            entrada.Data = DateTime.Value;
            entrada.IDFuncionario = (int)SystemParameters.GetID();
            
            Response resposta = entradaBLL.Insert(entrada);
            if (resposta.HasSuccess)
            {
                MeuMessageBox.Show("Venda Cadastrada");
            }
            else
            {
                MeuMessageBox.Show(resposta.Message);
            }




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
            List<Fornecedor> ForneAtivo = new();
            List<Fornecedor> fornecedors = fornecedorBLL.GetAll().Dados;
            foreach (Fornecedor fornecedor in fornecedors)
            {
                if (fornecedor.Ativo == true)
                {
                    ForneAtivo.Add(fornecedor);
                } 
            }
            CmbBoxFornecedores.DisplayMember = "Razao_Social";
            CmbBoxFornecedores.ValueMember = "ID";
            CmbBoxFornecedores.DataSource = ForneAtivo;

            List<Produto> produtosAtivos = new();
            List<Produto> produtos = produtoBLL.GetAll().Dados;
            foreach (Produto Produto in produtos)
            {
                if (Produto.Ativo == true)
                {
                    produtosAtivos.Add(Produto);
                    
                }
            }
            CmbBoxProduto.DisplayMember = "Nome";
            CmbBoxProduto.ValueMember = "ID";
            CmbBoxProduto.DataSource = produtosAtivos;

            CmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamento));
        }
    }
}
