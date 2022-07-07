using BusinessLogicalLayer.BusinessLL;
using Entities.viewmodel;
using Shared;
using System.ComponentModel;

namespace WfPresentationLayer.Alteraçoes
{
    /// <summary>
    /// Form para mostrar as Saidas de produtos em uma datagrid
    /// onde quando inicializado pelu menu ele ira gerar duas datas (padroes ou nao)
    /// que ira fazer a busca das Saidas com base nas datas
    /// onde o mesmo pode abrir uma tela de nova Venda 
    /// e o mesmo pode mostrar a grid com todas as Saidas cadastradas
    /// </summary>
    public partial class FormMostrarSaidas : Form
    {
        SaidaBll saidaBll = new SaidaBll();
        public FormMostrarSaidas()
        {
            InitializeComponent();
        }
        public FormMostrarSaidas(ParametrosDatas datas)
        {
            InitializeComponent();
            DataResponse<SaidaViewModel> Dados = saidaBll.LerTransacoes(datas.Inicio, datas.Fim);
            if (Dados.Dados == null)
            {
                MeuMessageBox.Show("Nao ha itens a mostrar");
                return;
            }
            foreach (SaidaViewModel item in Dados.Dados)
            {
                SincronizarListaGrid(item);
            }
        }
        private void SincronizarListaGrid(SaidaViewModel item)
        {
            GridSaidas.Rows.Add(item.SAIDA_ID, item.NOME_PRODUTO, item.VALOR_UNITARIO, item.Quantidade, item.FORMA_PAGAMENTO, item.NOME_CLIENTE, item.VALOR, item.DATA_SAIDA, item.NOME_FUNCIONARIO);
            GridSaidas.Sort(GridSaidas.Columns[0], ListSortDirection.Ascending);
        }
        private void BtnCadastrarVendas_Click(object sender, EventArgs e)
        {
            FormNovaVenda form = new FormNovaVenda();
            form.ShowDialog();
        }
        private void BtnProcurarCompra_Click(object sender, EventArgs e)
        {
            LimparGrid();
            DataResponse<SaidaViewModel> Dados = saidaBll.GetAll();

            if (Dados.Dados == null)
            {
                MeuMessageBox.Show("Nao ha itens a mostrar");
                return;
            }
            foreach (SaidaViewModel item in Dados.Dados)
            {

                SincronizarListaGrid(item);
            }

        }
        private void BtnVendasHoje_Click(object sender, EventArgs e)
        {
            LimparGrid();
            DataResponse<SaidaViewModel> data = saidaBll.LerTransacoes(DateTime.Today, DateTime.Now);
            if (data.Dados == null)
            {
                MeuMessageBox.Show("nao ha itens a mostrar");
            }
            foreach (SaidaViewModel item in data.Dados)
            {
                SincronizarListaGrid(item);
            }
        }

        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
        private void LimparGrid()
        {
            GridSaidas.Rows.Clear();
            GridSaidas.Refresh();
            GridSaidas.DataSource = null;
        }
    }
}
