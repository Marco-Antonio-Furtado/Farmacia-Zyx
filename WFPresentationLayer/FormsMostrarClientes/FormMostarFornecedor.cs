using BusinessLogicalLayer.BusinessLL;
using Entities;
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer.Alteraçoes
{
    public partial class Alteracao_Fornecedor : Form
    {
        private Form _objForm5;
        FornecedorBll fornecedorBll = new FornecedorBll();
        public Alteracao_Fornecedor()
        {
            InitializeComponent();

            List<Fornecedor> fornecedores = fornecedorBll.GetAll().Dados;
            foreach (Fornecedor Fornecedor in fornecedores)
            {
                SincronizarListaGrid(Fornecedor);
            }
        }

        private void BtnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            _objForm5?.Close();
            _objForm5 = new FormCadastroFornecedor
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PnlFornecedores.Controls.Add(_objForm5);
            _objForm5.Show();
            _objForm5.BringToFront();

        }
        private void SincronizarListaGrid(Fornecedor item)
        {
         GridFornecedor.Rows.Add(item.ID, item.Razao_Social, item.Telefone, item.Nome_Contato, item.Email, item.CNPJ);
        }
    }
}
