using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.Propriedades;
using Entities.viewmodel;
using Shared;
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
        private Form _objForm6;
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
            GridEntrada.Rows.Add(item.TransacaoID, item.ProdutoNome, item.ValorUnitario, item.Quantidade, item.ValorTotal, item.FormaPagamento,item.Fornecedor, item.Data, item.Funcionario);
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
                MeuMessageBox.Show("nao ha itens a mostrar");
            }
            foreach (EntradaViewModel item in data.Dados)
            {
                SincronizarListaGrid(item);
            }
        }

        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
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
        private void LimparGrid()
        {
            GridEntrada.Rows.Clear();
            GridEntrada.Refresh();
            GridEntrada.DataSource = null;

        }

    }
}
