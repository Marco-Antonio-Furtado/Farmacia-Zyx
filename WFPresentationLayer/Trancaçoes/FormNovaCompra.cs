using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.enums;
using Entities.Propriedades;
using Shared;
using WfPresentationLayer.Alteraçoes;
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer.Trancaçoes
{
    /// <summary>
    /// Form padrao de Nova compra 
    /// onde o mesmo faz a busca dos itens pelo botao de procurar fornecedor ou pela textbox que abre o form de mostrar fornecedor e tras
    /// a informacao direto pra textbox
    /// 
    /// onde o produto faz o mesmo tanto a busca como onde achar
    /// 
    /// o form tambem tem os botões de cadastro tanto de produto como de fornecedor 
    /// 
    /// o total da compra é feito no proprio label para melhor visualizacao 
    /// </summary>
    public partial class FormNovaCompra : Form
    {
        public FormNovaCompra()
        {
            InitializeComponent();
        }
        ProdutoBll produtoBLL = new();
        EntradaBll entradaBLL = new();
        List<Item> ItemsEntrada = new();
        int ForneID = 0;
        string forneRazao = "";
        int prodID = 0;
        string prodNome = "";

        private void BtnNovoIten_Click(object sender, EventArgs e)
        {
            if (TxtBoxSelecionarProduto.Text == "Selecione o Produto" || CmbFormaPagamento.Text == "" || TxtBoxQuantidade.Text == "" || TxtBoxSelecionarFornecedor.Text == "Selecione o Fornecedor")
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
            Item item = new();
            Produto produto = new();

            produto.ID = prodID;
            
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
            AtualizarLblTotal();
                LimparFormulario();
        }
        private void LimparFormulario()
        {
            TxtBoxSelecionarFornecedor.Enabled = false;
            BtnProcurarFornecedor.Enabled = false;
            CmbFormaPagamento.Enabled = false;
            DateTime.Enabled = false;
            TxtBoxSelecionarProduto.Text = "Selecione o Produto";
            TxtBoxQuantidade.Clear();
            CheckPreco.Checked = false;
            textBox1TxtBoxPrecoAlterado.Visible = false;
            textBox1TxtBoxPrecoAlterado.Text = "";
        }
        private void SincronizarListaGrid(Item item)
        {
            DataGrid.Rows.Add(prodNome, item.Preco, item.Qtd,(item.Preco * item.Qtd), CmbFormaPagamento.Text, SystemParameters.GetNome(),forneRazao,DateTime.Value);
        }
        private void BtnCadastrarCompra_Click(object sender, EventArgs e)
        {

            Entrada entrada = new();
            Fornecedor fornecedor = new();
            Funcionario funcionario = new();

            fornecedor.ID = ForneID;
            entrada.Forma_Pagamento = CmbFormaPagamento.Text;
            entrada.ValorTotal = double.Parse(LblValorTotal.Text);
            entrada.IDFornecedor = fornecedor;
            entrada.Items = ItemsEntrada;
            entrada.Data = DateTime.Value;
            funcionario.ID = (int)SystemParameters.GetID();
            entrada.IDFuncionario = funcionario;

            DialogResult ResponseMsg = MeuMessageBox.Show("A Entrada de Produtos deu o valor de " + entrada.ValorTotal + " Deseja Continuar a entrada dos produtos", "Escolha", "SIM", "Nao");
            if (ResponseMsg == DialogResult.Yes)
            {
                Response resposta = entradaBLL.Insert(entrada);

                MeuMessageBox.Show(resposta.Message);
            }
            else
            {
                return;
            }

            BtnProcurarFornecedor.Enabled = true;
            TxtBoxSelecionarFornecedor.Enabled = true;
            LblValorTotal.Text = 0.ToString();
            CmbFormaPagamento.Enabled = true;
            TxtBoxSelecionarFornecedor.Text = "Selecione o Fornecedor";
            CmbFormaPagamento.SelectedIndex = 0;
            DateTime.Enabled = true;
            TxtBoxSelecionarProduto.Text = "Selecione o Produto";
            TxtBoxQuantidade.Clear();
            CheckPreco.Checked = false;
            textBox1TxtBoxPrecoAlterado.Visible = false;
            textBox1TxtBoxPrecoAlterado.Text = "";
            DataGrid.Rows.Clear();
            DataGrid.Refresh();
        }
        private void FormNovaCompra_Load(object sender, EventArgs e)
        {
            CmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamento));
        }
        private void AtualizarLblTotal()
        {
            double novoValor = 0;
            foreach (Item item in ItemsEntrada)
            {
                novoValor += (item.Qtd * item.Preco);
            }
            LblValorTotal.Text = novoValor.ToString();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DataGrid.SelectedRows[0];
            ItemsEntrada.RemoveAt(row.Index);
            DataGrid.Rows.RemoveAt(row.Index);
            AtualizarLblTotal();
        }

        //Botoes de cadastro
        private void BtnNovoFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor form = new();
            form.ShowDialog();
        }
        private void BtnNovoProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto formCadastroProduto = new();    
            formCadastroProduto.ShowDialog();
        }

        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
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
        private void TxtBoxQuantidade_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //aceita apenas números, tecla backspace.
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnProcurarFornecedor_Click(object sender, EventArgs e)
        {
            Alteracao_Fornecedor form = new(true);
           form.ShowDialog();


            if(form.fornecedorSelecionado != null)
            {
                this.ForneID = form.fornecedorSelecionado.ID;
                this.forneRazao = form.fornecedorSelecionado.Razao_Social;
                TxtBoxSelecionarFornecedor.Text = form.fornecedorSelecionado.ID + " - " + form.fornecedorSelecionado.Razao_Social + " - " + form.fornecedorSelecionado.Email;
            }
        }
        private void BtnProcurarProduto_Click(object sender, EventArgs e)
        {
            FormMostrarProdutos form = new(true);
            form.ShowDialog();

            if(form.ProdutoSelecionado123 != null)
            {
                this.prodID = form.ProdutoSelecionado123.ID;
                this.prodNome = form.ProdutoSelecionado123.Nome;
                TxtBoxSelecionarProduto.Text = form.ProdutoSelecionado123.ID + " - " + form.ProdutoSelecionado123.Nome + " - " + form.ProdutoSelecionado123.Valor_Unitario;
            }
        }
    }
}
