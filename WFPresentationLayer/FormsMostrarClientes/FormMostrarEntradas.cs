using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.Propriedades;
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
            DataResponse<Entrada> data = entradaBll.GetAll(Datas.Inicio,Datas.Fim);

            foreach (Entrada item in data.Dados)
            {
                SincronizarListaGrid(item);
            }


        }

        private void FormMostrarEntradas_Load(object sender, EventArgs e)
        {
            
        }


        private void SincronizarListaGrid(Entrada item)
        {
            string prod = "";
            double quan = 0;
            foreach (Item ite in item.Items)
            {
                quan = ite.Qtd;
                prod = ite.IDProduto.Nome;
                break;
            }

            GridEntrada.Rows.Add(item.ID,item.Items, item.ValorTotal, quan, item.Forma_Pagamento, item.IDFornecedor.Razao_Social, item.Data, item.IDFuncionario.Nome_Funcionario);
        }

        private void BtnCadastrarCompra_Click(object sender, EventArgs e)
        {
            FormNovaCompra form = new FormNovaCompra();
            form.ShowDialog();


            //_objForm6?.Close();
            //_objForm6 = new FormNovaCompra()
            //{
            //    TopLevel = false,
            //    FormBorderStyle = FormBorderStyle.None,
            //    Dock = DockStyle.Fill,
            //};
            //PnlCompras.Controls.Add(_objForm6);
            //_objForm6.Show();
            //_objForm6.BringToFront();
        }
    }
}
