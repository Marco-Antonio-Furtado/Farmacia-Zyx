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
    public partial class FormNovaCompra : Form
    {
        public FormNovaCompra()
        {
            InitializeComponent();
        }
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

            Item item = new Item();
            Produto produto = new();

            string[] prselc = (TxtBoxSelecionarProduto.Text).Split(" - ");
            produto.ID = int.Parse(prselc[0]);
            
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


            double valorAntigo = double.Parse(LblValorTotal.Text);
            double valorNovo = item.Preco * item.Qtd;
            LblValorTotal.Text = (valorAntigo + valorNovo).ToString();



                ItemsEntrada.Add(item);
                SincronizarListaGrid(item);
                LimparFormulario();
            
        }
        private void LimparFormulario()
        {
            TxtBoxSelecionarFornecedor.Enabled = false;
            BtnProcurarFornecedor.Enabled = false;
            CmbFormaPagamento.Enabled = false;
            DateTime.Enabled = false;
            TxtBoxSelecionarProduto.Text = "";
            TxtBoxQuantidade.Clear();
            CheckPreco.Checked = false;
            textBox1TxtBoxPrecoAlterado.Visible = false;
            textBox1TxtBoxPrecoAlterado.Text = "";
        }
        private void SincronizarListaGrid(Item item)
        {
            string[] prselc = (TxtBoxSelecionarProduto.Text).Split(" - ");
            string[] forneselc = (TxtBoxSelecionarFornecedor.Text).Split(" - ");

            DataGrid.Rows.Add(prselc[1], item.Preco, item.Qtd,(item.Preco * item.Qtd), CmbFormaPagamento.Text, SystemParameters.GetNome(), forneselc[1],DateTime.Value);
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DataGrid.SelectedRows[0];

            double valorAntigo = double.Parse(LblValorTotal.Text);
            double valorNovo = valorAntigo - double.Parse(row.Cells[3].ToString());
            LblValorTotal.Text = valorNovo.ToString();

            ItemsEntrada.RemoveAt(row.Index);
            DataGrid.Rows.RemoveAt(row.Index);
        }
        private void BtnCadastrarCompra_Click(object sender, EventArgs e)
        {
            string[] prselc = (TxtBoxSelecionarProduto.Text).Split(" - ");
            string[] forneselc = (TxtBoxSelecionarFornecedor.Text).Split(" - ");

            Entrada entrada = new Entrada();
            Fornecedor fornecedor = new();
            Funcionario funcionario = new();


            fornecedor.ID = int.Parse(forneselc[0]);
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

                TxtBoxSelecionarFornecedor.Enabled = true;
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
            else
            {
                return;
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
        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnProcurarFornecedor_Click(object sender, EventArgs e)
        {
            Alteracao_Fornecedor form = new Alteracao_Fornecedor(true);
           form.ShowDialog();


            if(form.fornecedorSelecionado != null)
            {
                TxtBoxSelecionarFornecedor.Text = form.fornecedorSelecionado.ID + " - " + form.fornecedorSelecionado.Razao_Social + " - " + form.fornecedorSelecionado.Email;
            }
        }
        private void BtnProcurarProduto_Click(object sender, EventArgs e)
        {
            FormMostrarProdutos form = new FormMostrarProdutos(true);
            form.ShowDialog();

            if(form.ProdutoSelecionado123 != null)
            {
                TxtBoxSelecionarProduto.Text = form.ProdutoSelecionado123.ID + " - " + form.ProdutoSelecionado123.Nome + " - " + form.ProdutoSelecionado123.Valor_Unitario;
            }
        }
    }
}
