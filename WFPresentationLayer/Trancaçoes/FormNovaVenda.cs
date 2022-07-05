using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using BusinessLogicalLayer.RegraDePreco;
using Entities;
using Entities.enums;
using Entities.Propriedades;
using Shared;

namespace WfPresentationLayer
{
    public partial class FormNovaVenda : Form
    {
        RegraDescontoCliente Regra = new RegraDescontoCliente();
        ClienteBll clienteBll = new ClienteBll();
        ProdutoBll produtoBLL = new ProdutoBll();
        SaidaBll SaidaBLL = new SaidaBll();
        public FormNovaVenda()
        {
            InitializeComponent();
            CmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamento));
            DataGrid.DataBindings.Add(nameof(DataGrid.BackgroundColor), this, nameof(Control.BackColor));
            CmbBoxClientes.SelectedIndex = -1;
            CmbBoxProduto.SelectedIndex = -1;
            CmbFormaPagamento.SelectedIndex = -1;
        }
        List<Item> ItemsSaida = new List<Item>();

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
            if (CmbBoxProduto.Text == "" || CmbFormaPagamento.Text == "" || CmbFormaPagamento.Text == "")
            {
                MeuMessageBox.Show("Voce nao selecionou os itens");
            }
            else
            { 
                

                
                Produto produto = new();
                Item item = new Item();
                produto.ID = (int)CmbBoxProduto.SelectedValue;
                item.IDProduto = produto;
                Produto proselcionado = produtoBLL.GetByID(produto.ID).Item;
                item.Preco = proselcionado.Valor_Venda;
                item.Qtd = int.Parse(TxtBoxQuantidade.Text);


                double valorAntigo = double.Parse(LblValorTotal.Text);
                double valorNovo = item.Preco * item.Qtd;
                LblValorTotal.Text = Convert.ToString(valorAntigo + valorNovo);

                ItemsSaida.Add(item);
                SincronizarListaGrid(item);
                LimparFormulario();
            }
        }
        private void LimparFormulario()
        {
            CmbBoxClientes.Enabled = false;
            CmbBoxProduto.SelectedIndex = -1;
            CmbFormaPagamento.Enabled = false;
            DateTime.Enabled = false;
            TxtBoxQuantidade.Clear();
        }
        private void SincronizarListaGrid(Item item)
        {
            DataGrid.Rows.Add(CmbBoxProduto.Text, item.Preco, item.Qtd, (item.Preco * item.Qtd), CmbBoxClientes.Text,SystemParameters.GetNome(), DateTime.Value); ;
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DataGrid.SelectedRows[0];
            ItemsSaida.RemoveAt(row.Index);
            DataGrid.Rows.RemoveAt(row.Index);
        }
        private void BtnCadastrarNovaVenda_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
                Saida saida = new Saida();
            Funcionario funcionario = new();
            cliente.ID = (int)CmbBoxClientes.SelectedValue;
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

                    CmbBoxClientes.Enabled = true;
                    CmbFormaPagamento.Enabled = true;
                    CmbBoxClientes.SelectedIndex = 0;
                    CmbFormaPagamento.SelectedIndex = 0;
                    DateTime.Enabled = true;
                    CmbBoxProduto.SelectedIndex = -1;
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

                    CmbBoxClientes.Enabled = true;
                    CmbFormaPagamento.Enabled = true;
                    CmbBoxClientes.SelectedIndex = 0;
                    CmbFormaPagamento.SelectedIndex = 0;
                    DateTime.Enabled = true;
                    CmbBoxProduto.SelectedIndex = -1;
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
        private void TxtBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void FormNovaVenda_Load(object sender, EventArgs e)
        {
            List<Cliente> ClienteAtivo = new();
            List<Cliente> Clientes = clienteBll.GetAll().Dados;
            foreach (Cliente cl in Clientes)
            {
                if (cl.Ativo == true)
                {
                    ClienteAtivo.Add(cl);
                }
            }
            CmbBoxClientes.DisplayMember = "Nome_Cliente";
            CmbBoxClientes.ValueMember = "ID";
            CmbBoxClientes.DataSource = ClienteAtivo;

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
        }

        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
