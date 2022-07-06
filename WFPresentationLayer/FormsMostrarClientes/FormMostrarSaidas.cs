using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.viewmodel;
using Shared;

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
        private Form _objForm6;
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
            GridSaidas.Rows.Add(item.TransacaoID, item.ProdutoNome, item.ValorUnitario, item.Quantidade, item.FormaPagamento, item.ClienteNome, item.ValorTotal,item.Data,item.funcionario);
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



        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
        private void LimparGrid()
            {
                GridSaidas.Rows.Clear();
                GridSaidas.Refresh();
                GridSaidas.DataSource = null;

            }
    }
}
