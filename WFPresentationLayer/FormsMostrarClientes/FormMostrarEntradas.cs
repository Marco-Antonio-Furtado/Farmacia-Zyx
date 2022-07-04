using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.Propriedades;
using Entities.viewmodel;
using Shared;
using WfPresentationLayer.Trancaçoes;

namespace WfPresentationLayer.Alteraçoes
{
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
        private void BtnCadastrarCompra_Click(object sender, EventArgs e)
        {
            FormNovaCompra form = new FormNovaCompra();
            form.ShowDialog();
            //_objForm6?.Close();
            //_objForm6 = new FormNovaCompra
            //{
            //    TopLevel = false,
            //    FormBorderStyle = FormBorderStyle.None,
            //    Dock = DockStyle.Fill,
            //};
            //PnlCompras.Controls.Add(_objForm6);
            //_objForm6.Show();
            //_objForm6.BringToFront();
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
        private void LimparGrid()
        {
            GridEntrada.Rows.Clear();
            GridEntrada.Refresh();
            GridEntrada.DataSource = null;

        }

    }
}
