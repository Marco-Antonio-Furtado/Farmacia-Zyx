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
            if (CmbBoxProduto.Text == "" || CmbFormaPagamento.Text == "" || TxtBoxQuantidade.Text == "" || CmbBoxFornecedores.Text == "")
            {
                MeuMessageBox.Show("Voce nao Informou todos os campos");
                if (CheckPreco.Checked == true)
                {
                    if (textBox1TxtBoxPrecoAlterado.Text == "")
                    {
                        MeuMessageBox.Show("Preco novo nao informado");
                        return;
                    }

                }
                return;
            }

            Item item = new Item();
            Produto produto = new();
            produto.ID = (int)CmbBoxProduto.SelectedValue;

            if (CheckPreco.Checked == true)
            {
                item.Preco = double.Parse(textBox1TxtBoxPrecoAlterado.Text);
                produto.IsPrecoAlterado = true;
            }
            else
            {
                item.Preco = produtoBLL.GetByID(produto.ID).Item.Valor_Venda;
            }   
                item.IDProduto = produto;
                item.Qtd = int.Parse(TxtBoxQuantidade.Text);
                ItemsEntrada.Add(item);
                SincronizarListaGrid(item);
                LimparFormulario();
            
        }
        private void LimparFormulario()
        {
            CmbBoxFornecedores.Enabled = false;
            CmbFormaPagamento.Enabled = false;
            DateTime.Enabled = false;
            CmbBoxProduto.SelectedIndex = -1;
            TxtBoxQuantidade.Clear();
            CheckPreco.Checked = false;
            textBox1TxtBoxPrecoAlterado.Visible = false;
            textBox1TxtBoxPrecoAlterado.Text = "";
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
            Fornecedor fornecedor = new();
            Funcionario funcionario = new();
            fornecedor.ID = (int)CmbBoxFornecedores.SelectedValue;
            entrada.Forma_Pagamento = CmbFormaPagamento.Text;
            entrada.ValorTotal = soma;
            entrada.IDFornecedor = fornecedor;
            entrada.Items = ItemsEntrada;
            entrada.Data = DateTime.Value;
            funcionario.ID = (int)SystemParameters.GetID();
            entrada.IDFuncionario = funcionario;
            
            Response resposta = entradaBLL.Insert(entrada);
           
            MeuMessageBox.Show(resposta.Message);
            




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
        private void CheckPreco_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox1TxtBoxPrecoAlterado.Visible == true)
            {
                textBox1TxtBoxPrecoAlterado.Visible = false;
                return;
            }
            if (textBox1TxtBoxPrecoAlterado.Visible == false)
            {
                textBox1TxtBoxPrecoAlterado.Visible = true;
            }

        }
        private void textBox1TxtBoxPrecoAlterado_KeyPress(object sender, KeyPressEventArgs e)
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
