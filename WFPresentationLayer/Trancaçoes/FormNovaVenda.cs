using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using BusinessLogicalLayer.RegraDePreco;
using Entities;
using Entities.enums;
using Entities.Propriedades;
using Shared;
using WfPresentationLayer.Alteraçoes;

namespace WfPresentationLayer
{
    /// <summary>
    /// Form padrao de Nova Venda 
    /// onde o mesmo faz a busca dos itens pelo botao de procurar Clientes ou pela textbox que abre o form de mostrar Clientes e tras
    /// a informacao direto pra textbox
    /// 
    /// onde o produto faz o mesmo tanto a busca como onde achar
    /// 
    /// o form tambem tem os botões de cadastro tanto de produto como de Cliente 
    /// 
    /// o total da compra é feito no proprio label para melhor visualizacao 
    /// </summary>
    public partial class FormNovaVenda : Form
    {
        RegraDescontoCliente Regra = new();
        ProdutoBll produtoBLL = new();
        SaidaBll SaidaBLL = new();
        int clienteID = 0;
        int prodID = 0;
        string prodNome = "";
        string CLiNome = "";
        public FormNovaVenda()
        {
            InitializeComponent();
        }
        List<Item> ItemsSaida = new();
        private void FormNovaVenda_Load(object sender, EventArgs e)
        {
            CmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamento));
        }
        private void BtnNovoIten_Click(object sender, EventArgs e)
        {
            if (TxtBoxProcurarProduto.Text == "Selecione o Produto" || CmbFormaPagamento.Text == "" || TxtProcurarCliente.Text == "Selecione o Cliente")
            {
                MeuMessageBox.Show("Voce nao selecionou os itens");
            }
            else
            { 
                Produto produto = new();
                Item item = new();

                produto.ID = prodID;
                item.IDProduto = produto;
                Produto proselcionado = produtoBLL.GetByID(produto.ID).Item;
                item.Preco = proselcionado.Valor_Venda;
                item.Qtd = int.Parse(TxtBoxQuantidade.Text);

                ItemsSaida.Add(item);
                SincronizarListaGrid(item);
                AtualizarLblTotal();
                LimparFormulario();
            }
        }
        private void LimparFormulario()
        {
            TxtProcurarCliente.Enabled = false;
            BtnProcurarCliente.Enabled = false;
            TxtBoxProcurarProduto.Text = "Selecione o Produto";
            CmbFormaPagamento.Enabled = false;
            DateTime.Enabled = false;
            TxtBoxQuantidade.Clear();
        }
        private void SincronizarListaGrid(Item item)
        {
            DataGrid.Rows.Add(prodNome, item.Preco, item.Qtd, (item.Preco * item.Qtd), CLiNome,SystemParameters.GetNome(), DateTime.Value); ;
        }
        private void BtnCadastrarNovaVenda_Click(object sender, EventArgs e)
        {
            Cliente cliente = new();
            Saida saida = new();
            Funcionario funcionario = new();

            cliente.ID = clienteID;
            saida.ValorTotal = double.Parse(LblValorTotal.Text);
            saida.Forma_Pagamento = CmbFormaPagamento.Text;

            saida.Cliente = cliente;
            saida.Items = ItemsSaida;
            saida.Data = DateTime.Value;
            funcionario.ID = (int)SystemParameters.GetID();
            saida.IDFuncionario = funcionario;

            bool IsDesconto = Regra.ChecarDesconto(saida);
            if (!IsDesconto)
            {
                DialogResult responsemsgbox = MeuMessageBox.Show("A sua Compra deu o valor de " + saida.ValorTotal.ToString() + " Deseja encerrar a compra?", "Escolha", "Sim", "Nao");

                if (responsemsgbox == DialogResult.Yes)
                {
                    Response resposta = SaidaBLL.Insert(saida);
                    if (resposta.HasSuccess)
                    {
                        MeuMessageBox.Show("Venda Cadastrada");
                    }
                    else
                    {
                        MeuMessageBox.Show(resposta.Message);
                    }

                    TxtProcurarCliente.Enabled = true;
                    CmbFormaPagamento.Enabled = true;
                    TxtProcurarCliente.Text = "Selecione o Cliente";
                    CmbFormaPagamento.SelectedIndex = 0;
                    DateTime.Enabled = true;
                    TxtBoxProcurarProduto.Text = "Selecione o Produto";
                    TxtBoxQuantidade.Clear();
                    DataGrid.Rows.Clear();
                    DataGrid.Refresh();
                }
                else
                {
                    return;
                }
            }
            else
            {
                DialogResult responsemsgbox = MeuMessageBox.Show("A sua Compra Com Desconto deu o valor de " + (saida.ValorTotal * 0.9).ToString() + " Deseja encerrar a compra?", "Escolha", "Sim", "Nao");

                if (responsemsgbox == DialogResult.Yes)
                {
                    Response resposta = SaidaBLL.Insert(saida);
                    if (resposta.HasSuccess)
                    {
                        MeuMessageBox.Show("Venda Cadastrada");
                    }
                    else
                    {
                        MeuMessageBox.Show(resposta.Message);
                    }

                    TxtProcurarCliente.Enabled = true;
                    CmbFormaPagamento.Enabled = true;
                    TxtProcurarCliente.Text = "Selecione o Cliente";
                    CmbFormaPagamento.SelectedIndex = 0;
                    DateTime.Enabled = true;
                    TxtBoxProcurarProduto.Text = "Selecione o Produto";
                    TxtBoxQuantidade.Clear();
                    DataGrid.Rows.Clear();
                    DataGrid.Refresh();
                }
                else
                {
                    return;
                }
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DataGrid.SelectedRows[0];

            ItemsSaida.RemoveAt(row.Index);
            DataGrid.Rows.RemoveAt(row.Index);
            AtualizarLblTotal();
        }
        private void AtualizarLblTotal()
        {
            double novoValor = 0;
            foreach (Item item in ItemsSaida)
            {
                novoValor += (item.Qtd * item.Preco);
            }
            LblValorTotal.Text = novoValor.ToString();
        }

        //Botoes de cadastro
        private void BtnNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new();
            formCadastroCliente.ShowDialog();
        }
        private void BtnNovoProduto_Click(object sender, EventArgs e)
        {
            FormCadastroProduto form = new();
            form.ShowDialog();
        }

        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
        private void TxtBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnProcurarCliente_Click(object sender, EventArgs e)
        {
            FormMostarClientes frmC = new(true);
            frmC.ShowDialog();

            if (frmC.ClienteSelecionado != null)
            {
                this.clienteID = frmC.ClienteSelecionado.ID;
                this.CLiNome = frmC.ClienteSelecionado.Nome_Cliente;
                TxtProcurarCliente.Text = frmC.ClienteSelecionado.ID + " - " + frmC.ClienteSelecionado.Nome_Cliente + " - " + frmC.ClienteSelecionado.Email;
            }
        }
        private void BtnProcurarProduto_Click(object sender, EventArgs e)
        {
            FormMostrarProdutos frm = new(true);
            frm.ShowDialog();

            if (frm.ProdutoSelecionado123 != null)
            {
                this.prodID = frm.ProdutoSelecionado123.ID;
                this.prodNome = frm.ProdutoSelecionado123.Nome;

                TxtBoxProcurarProduto.Text = frm.ProdutoSelecionado123.ID + " - " + frm.ProdutoSelecionado123.Nome + " - " + frm.ProdutoSelecionado123.Valor_Unitario;
            }
        }
        

    }
}
