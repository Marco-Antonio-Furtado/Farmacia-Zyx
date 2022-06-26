using BusinessLogicalLayer.BusinessLL;
using Entities;

namespace WfPresentationLayer.Alteraçoes
{
    public partial class FormMostrarProdutos : Form
    {
        private Form _objForm3;
        ProdutoBll ProdutoBll = new ProdutoBll();
        public FormMostrarProdutos()
        {
            InitializeComponent();
            List<Produto> Produtos = ProdutoBll.GetAll().Dados;
            foreach (Produto Produto in Produtos)
            {
                SincronizarListaGrid(Produto);
            }
        }

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
            Gridprodutos.Rows.Add(item.ID, item.Nome,item.ID_Laboratorio, item.Descricao, item.Valor_Unitario, item.Valor_Unitario);
        }
    }
}
