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
            DataResponse<EntradaViewModel> data = entradaBll.GetAll(Datas.Inicio,Datas.Fim);

            foreach (EntradaViewModel item in data.Dados)
            {
                SincronizarListaGrid(item);
            }
            //ValorUnitario = Convert.ToDouble(reader["VALOR_UNITARIO"]),
            //            Funcionario = Convert.ToString(reader["NOME_FUNCIONARIO"]),
            //            TransacaoID = Convert.ToInt32(reader["ENTRADA_ID"]),
            //            ProdutoNome = Convert.ToString(reader["NOME_PRODUTO"]),
            //            Quantidade = Convert.ToDouble(reader["QUANTIDADE"]),
            //            FormaPagamento = Convert.ToString(reader["FORMA_PAGAMENTO"]),
            //            Fornecedor = Convert.ToString(reader["RAZAO_SOCIAL"]),
            //            ValorTotal = Convert.ToDouble(reader["PRECO"]),
            //            Data = Convert.ToDateTime(reader["DATA_ENTRADA"])


        }

        private void FormMostrarEntradas_Load(object sender, EventArgs e)
        {
            
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
