using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer.Alteraçoes
{
    public partial class FormMostrarProdutos : Form
    {
        private Form _objForm3;
        ProdutoBll ProdutoBll = new ProdutoBll();
        public FormMostrarProdutos()
        {
            InitializeComponent();
        }
        List<Produto> Produtos = new List<Produto>();
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
        private void SincronizarListaGrid(Produto item)
        {
            Gridprodutos.Rows.Add(item.ID, item.Nome, item.ID_Laboratorio.Razao_Social, item.Descricao, item.Quantia_Estoque, item.Valor_Unitario,item.Valor_Venda);
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
                    int IDPRoduto = Convert.ToInt32(Gridprodutos.CurrentRow.Cells[0].Value.ToString());
                    string nome = Convert.ToString(Gridprodutos.CurrentRow.Cells[1].Value.ToString());
                    string laboratorio = Convert.ToString(Gridprodutos.CurrentRow.Cells[2].Value.ToString());
                    string descrisao = Convert.ToString(Gridprodutos.CurrentRow.Cells[3].Value.ToString());
                    string valorcompra = Convert.ToString(Gridprodutos.CurrentRow.Cells[5].Value.ToString());
                    _objForm3?.Close();
                    _objForm3 = new FormCadastroProduto(IDPRoduto, nome, laboratorio, descrisao, valorcompra)
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill,
                    };
                    pnlProduto.Controls.Add(_objForm3);
                    _objForm3.Show();
                    _objForm3.BringToFront();
               
        }
        private void BtnDeletarProdutos_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.Gridprodutos.SelectedRows[0];
            int IDCLiente = Convert.ToInt32(Gridprodutos.CurrentRow.Cells[0].Value.ToString());
            string nome = Convert.ToString(Gridprodutos.CurrentRow.Cells[1].Value.ToString());

            DialogResult r = MeuMessageBox.Show("Deseja Apagar o " + nome + " Da tabela Ou do banco " + "\r\n" + "X Para Voltar", "Escolha", "Deletar Do banco", "deletar da tabela");
            if (r == DialogResult.Yes)
            {
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja deletar o usuario " + nome, " Tem Certeza?", "Sim", "Nao");
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
        private void LimparGrid()
        {
            Gridprodutos.Rows.Clear();
            Gridprodutos.Refresh();
            Gridprodutos.DataSource = null;
            
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
                MeuMessageBox.Show("Nao a Produtos Desabilitados");
                LimparGrid();
            }
        }
    }
}
