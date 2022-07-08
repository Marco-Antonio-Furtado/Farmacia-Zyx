using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;
using System.ComponentModel;

namespace WfPresentationLayer.Alteraçoes
{

    /// <summary>
    /// Form Padrão mostrar Produtos em uma datagrid 
    /// dentro desse form a algumas Funcoes que ele faz dentro delas 
    /// Cadastro de Produtos que abre o form de Produto vazio
    /// alterar Produtos que abre o form de cadastro de Produto preenchido onde o mesmo é feito clicando na linha e clicando no botao
    /// mostrar desabilitados mostra na grid todos os Produtos desabilitados
    /// deletar deleta ou desabilita os Produtos da grid e do banco de dados onde o mesmo é feito clicando na linha e clicando no botao
    /// 
    /// onde dentro do form ele tem uma sobrecarga se ele for aberto para gerar um Produtos em tela de Cadastros ou vendas
    /// 
    /// onde todos esse forms sao aberto dentro de um panel padrão
    /// </summary>
    public partial class FormMostrarProdutos : Form
    {
        private Form _objForm3;
        ProdutoBll ProdutoBll = new();
        
        private bool _isOpenedByAnotherForm;

        public FormMostrarProdutos(bool v)
        {
            InitializeComponent();
            this._isOpenedByAnotherForm = v;
        }
        public FormMostrarProdutos()
        {
            InitializeComponent();
        }

        public Produto ProdutoSelecionado123 { get; set; }
        List<Produto> Produtos = new();
        private void BtnCadastrarProduto_Click(object sender, EventArgs e)
        {
            _objForm3?.Close();
            _objForm3 = new FormCadastroProduto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlProduto.Controls.Add(_objForm3);
            _objForm3.Show();
            _objForm3.BringToFront();
        }
        private void BtnAlterarProdutos_Click(object sender, EventArgs e)
        {
            if (this.Gridprodutos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.Gridprodutos.SelectedRows[0];
            if (Gridprodutos.CurrentRow.Cells[0].Value == null)
            {
                MeuMessageBox.Show("Voce nao selecionou nenhuma coluna");
            }
            else
            {
                Produto p = new();
                Laboratorio lab = new();
                p.ID = Convert.ToInt32(Gridprodutos.CurrentRow.Cells[0].Value.ToString());
                p.Nome = Convert.ToString(Gridprodutos.CurrentRow.Cells[1].Value.ToString());
                lab.Razao_Social = Convert.ToString(Gridprodutos.CurrentRow.Cells[2].Value.ToString());
                p.Descricao = Convert.ToString(Gridprodutos.CurrentRow.Cells[3].Value.ToString());
                p.Quantia_Estoque = Convert.ToInt32(Gridprodutos.CurrentRow.Cells[4].Value.ToString());
                p.Valor_Unitario = Convert.ToInt32(Gridprodutos.CurrentRow.Cells[5].Value.ToString());
                p.Valor_Venda = Convert.ToInt32(Gridprodutos.CurrentRow.Cells[6].Value.ToString());
                p.ID_Laboratorio = lab;
                _objForm3?.Close();
                _objForm3 = new FormCadastroProduto(p)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };
                pnlProduto.Controls.Add(_objForm3);
                _objForm3.Show();
                _objForm3.BringToFront();
            }
        }
        private void BtnDesabilitados_Click(object sender, EventArgs e)
        {
            LimparGrid();
            Produtos = ProdutoBll.GetAll().Dados;
            foreach (Produto Produto in Produtos)
            {
                if (Produto.Ativo == false)
                {
                    SincronizarListaGrid(Produto);
                }
            }
            if (Gridprodutos.RowCount == 1)
            {
                MeuMessageBox.Show("Nao há Produtos Desabilitados");
                LimparGrid();
            }
        }
        private void BtnDeletarProdutos_Click(object sender, EventArgs e)
        {
            if (this.Gridprodutos.SelectedRows.Count == 0)
            {
                return;
            }
            if (Gridprodutos.CurrentRow.Cells[0].Value == null)
            {
                MeuMessageBox.Show("Voce nao selecionou nenhuma coluna");
                return;
            }
            int IDCLiente = Convert.ToInt32(Gridprodutos.CurrentRow.Cells[0].Value.ToString());
            string nome = Convert.ToString(Gridprodutos.CurrentRow.Cells[1].Value.ToString());

            DialogResult r = MeuMessageBox.Show("Deseja Apagar o Produto " + nome + " Da tabela Ou do banco " + "\r\n" + "X Para Voltar", "Escolha", "Deletar Do banco", "deletar da tabela");
            if (r == DialogResult.Yes)
            {
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja deletar o Produto " + nome, " Tem Certeza?", "Sim", "Nao");
                if (re == DialogResult.Yes)
                {
                    Response resposta = ProdutoBll.Delete(IDCLiente);
                    if (resposta.HasSuccess)
                    {
                        MeuMessageBox.Show(resposta.Message, "Deu Certo", "OK");
                    }
                    else MeuMessageBox.Show(resposta.Message);
                }
                else { }
            }
            else if (r == DialogResult.No)
            {
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja Apagar o Produto " + nome, " Tem Certeza?", "Sim", "Nao");
                if (re == DialogResult.Yes)
                {
                    Response resposta = ProdutoBll.Disable(IDCLiente);
                    if (resposta.HasSuccess)
                    {
                        MeuMessageBox.Show(resposta.Message, "Deu Certo", "OK");
                    }
                    else MeuMessageBox.Show(resposta.Message);
                }
                else { }
            }
        }
        private void FormMostrarProdutos_Load(object sender, EventArgs e)
        {
            Produtos = ProdutoBll.GetAll().Dados;
            foreach (Produto Produto in Produtos)
            {
                if (Produto.Ativo == true)
                {
                    SincronizarListaGrid(Produto);
                }
            }
        }
        private void SincronizarListaGrid(Produto item)
        {
            Gridprodutos.Rows.Add(item.ID, item.Nome, item.ID_Laboratorio.Razao_Social, item.Descricao, item.Quantia_Estoque, item.Valor_Unitario,item.Valor_Venda);
            Gridprodutos.Sort(Gridprodutos.Columns[0], ListSortDirection.Ascending);

        }

        /// <summary>
        /// Metodos padrões Para melhor visualizacao e entendimento do usuario 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gridprodutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Produto ProdutoSelecionado = new();
            ProdutoSelecionado.ID = Convert.ToInt32(Gridprodutos.Rows[e.RowIndex].Cells[0].Value);
            SingleResponse<Produto> response = ProdutoBll.GetByID(ProdutoSelecionado.ID);
            if (!response.HasSuccess)
            {
                MessageBox.Show(response.Message);
                return;
            }
            if (this._isOpenedByAnotherForm)
            {
                this.ProdutoSelecionado123 = response.Item;
                this.Close();
            }
        }
        
        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
        private void LimparGrid()
        {
            Gridprodutos.Rows.Clear();
            Gridprodutos.Refresh();
            Gridprodutos.DataSource = null;
            
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LimparGrid();
            Produtos = ProdutoBll.GetAll().Dados;
            foreach (Produto Produto in Produtos)
            {
                if (Produto.Ativo == true)
                {
                    SincronizarListaGrid(Produto);
                }
            }
        }
    }
}
