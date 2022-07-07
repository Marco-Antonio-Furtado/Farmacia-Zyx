using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.Propriedades;
using Entities.viewmodel;
using Shared;
using System.ComponentModel;
using WfPresentationLayer.Trancaçoes;

namespace WfPresentationLayer.Alteraçoes
{

    /// <summary>
    /// Form para mostrar as entradas de produtos em uma datagrid
    /// onde quando inicializado pelu menu ele ira gerar duas datas (padroes ou nao)
    /// que ira fazer a busca das entradas com base nas datas
    /// onde o mesmo pode abrir uma tela de nova compra 
    /// e o mesmo pode mostrar a grid com todas as vendas cadastradas
    /// </summary>
    public partial class FormMostrarEntradas : Form
    {
        EntradaBll entradaBll = new EntradaBll();
        public FormMostrarEntradas()
        {
            InitializeComponent();
        }
        public FormMostrarEntradas(ParametrosDatas Datas)
        {
            InitializeComponent();
            DataResponse<EntradaViewModel> data = entradaBll.LerTransacoes(Datas.Inicio,Datas.Fim);
            if(data.Dados == null)
            {
                MeuMessageBox.Show("nao ha itens a mostrar");
            }
            foreach (EntradaViewModel item in data.Dados)
            {
                SincronizarListaGrid(item);
            }
        }
        private void SincronizarListaGrid(EntradaViewModel item)
        {
            GridEntrada.Rows.Add(item.ENTRADA_ID, item.NOME_PRODUTO, item.Valor_Unitario, item.Quantidade, item.preco, item.FORMA_PAGAMENTO,item.RAZAO_SOCIAL, item.DATA_ENTRADA, item.NOME_FUNCIONARIO);
            GridEntrada.Sort(GridEntrada.Columns[0], ListSortDirection.Ascending);
        }
        private void BtnCadastrarVendas_Click(object sender, EventArgs e)
        {
            FormNovaCompra form = new FormNovaCompra();
            form.ShowDialog();
        }
        private void BtnCadastrarCompra_Click(object sender, EventArgs e)
        {
            FormNovaCompra form = new FormNovaCompra();
            form.ShowDialog();
        }
        private void BtnProcurarCompra_Click(object sender, EventArgs e)
        {
            LimparGrid();
            DataResponse<EntradaViewModel> data = entradaBll.GetAll();
            if (data.Dados == null)
            {
                MeuMessageBox.Show("Nao ha itens a mostrar");
            }
            foreach (EntradaViewModel item in data.Dados)
            {
                SincronizarListaGrid(item);
            }
        }
        private void BtnEntradasHoje_Click(object sender, EventArgs e)
        {
            LimparGrid();
            DataResponse<EntradaViewModel> data = entradaBll.LerTransacoes(DateTime.Today,DateTime.Now);
            if (data.Dados == null)
            {
                MeuMessageBox.Show("Nao ha itens a mostrar");
            }
            foreach (EntradaViewModel item in data.Dados)
            {
                SincronizarListaGrid(item);
            }
        }
        private void BtnSelecionarVendas_Click(object sender, EventArgs e)
        {
            LimparGrid();
            DataResponse<EntradaViewModel> Dados = entradaBll.GetAll();

            if (Dados.Dados == null)
            {
                MeuMessageBox.Show("Nao ha itens a mostrar");
                return;
            }
            foreach (EntradaViewModel item in Dados.Dados)
            {
                SincronizarListaGrid(item);
            }
        }
        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
        private void LimparGrid()
        {
            GridEntrada.Rows.Clear();
            GridEntrada.Refresh();
            GridEntrada.DataSource = null;
        }
    }
}
