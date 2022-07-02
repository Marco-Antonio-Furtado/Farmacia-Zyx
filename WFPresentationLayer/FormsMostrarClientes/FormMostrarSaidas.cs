using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.viewmodel;
using Shared;

namespace WfPresentationLayer.Alteraçoes
{
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

            //_objForm6?.Close();
            //_objForm6 = new FormNovaVenda()
            //{
            //    TopLevel = false,
            //    FormBorderStyle = FormBorderStyle.None,
            //    Dock = DockStyle.Fill,
            //};
            //PnlVendas.Controls.Add(_objForm6);
            //_objForm6.Show();
            //_objForm6.BringToFront();
        }

        private void BtnProcurarCompra_Click(object sender, EventArgs e)
        {
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
    }
}
