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
    public partial class FormNovaVenda : Form
    {
        
        RegraDescontoCliente Regra = new RegraDescontoCliente();
        ProdutoBll produtoBLL = new ProdutoBll();
        SaidaBll SaidaBLL = new SaidaBll();
        public FormNovaVenda()
        {
            InitializeComponent();
            CmbFormaPagamento.DataSource = Enum.GetNames(typeof(FormaPagamento));
            DataGrid.DataBindings.Add(nameof(DataGrid.BackgroundColor), this, nameof(Control.BackColor));
            TxtProcurarCliente.Text = "";
            TxtBoxProcurarProduto.Text = "";
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
            if (TxtBoxProcurarProduto.Text == "Selecione o Produto" || CmbFormaPagamento.Text == "" || TxtProcurarCliente.Text == "Selecione o Cliente")
            {
                MeuMessageBox.Show("Voce nao selecionou os itens");
            }
            else
            { 
                Produto produto = new();
                Item item = new Item();

                string[] prselc = (TxtBoxProcurarProduto.Text).Split(" - ");
                


                produto.ID = int.Parse(prselc[0]);
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
            TxtProcurarCliente.Enabled = false;
            BtnProcurarCliente.Enabled = false;
            TxtBoxProcurarProduto.Text = "Selecione o Produto";
            CmbFormaPagamento.Enabled = false;
            DateTime.Enabled = false;
            TxtBoxQuantidade.Clear();
        }
        private void SincronizarListaGrid(Item item)
        {

            string[] prselc = (TxtBoxProcurarProduto.Text).Split(" - ");
            string[] clienteselc = (TxtProcurarCliente.Text).Split(" - ");

            DataGrid.Rows.Add(prselc[1], item.Preco, item.Qtd, (item.Preco * item.Qtd), clienteselc[1],SystemParameters.GetNome(), DateTime.Value); ;
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.DataGrid.SelectedRows[0];

            double valorAntigo = double.Parse(LblValorTotal.Text);
            double valorNovo = valorAntigo - double.Parse(row.Cells[3].ToString());



            LblValorTotal.Text = valorNovo.ToString();

            ItemsSaida.RemoveAt(row.Index);
            DataGrid.Rows.RemoveAt(row.Index);
        }
        private void BtnCadastrarNovaVenda_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Saida saida = new Saida();
            Funcionario funcionario = new();

            string[] clienteselc = (TxtProcurarCliente.Text).Split(" - ");


            cliente.ID = int.Parse(clienteselc[0]);
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
        private void TxtBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void FormNovaVenda_Load(object sender, EventArgs e)
        {
        }
        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnProdutoSelecionado_Click(object sender, EventArgs e)
        {
            FormMostrarProdutos frm = new FormMostrarProdutos(true);
            frm.ShowDialog();

           
           if (frm.ProdutoSelecionado123 != null)
           {
                TxtBoxProcurarProduto.Text = frm.ProdutoSelecionado123.ID + " - " + frm.ProdutoSelecionado123.Nome + " - " + frm.ProdutoSelecionado123.Valor_Unitario;

            }
        }
        private void BtnProcurarCliente_Click(object sender, EventArgs e)
        {
            FormMostarClientes frmC = new FormMostarClientes(true);
            frmC.ShowDialog();

            if (frmC.ClienteSelecionado != null)
            {
                TxtProcurarCliente.Text = frmC.ClienteSelecionado.ID + " - " + frmC.ClienteSelecionado.Nome_Cliente + " - " + frmC.ClienteSelecionado.Email;
            }
        }
        
    }
}
