using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer.FormCadastros
{
    public partial class FormCadastroFornecedor : Form
    {
        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }
        private void BtnCadastroFornecedor_Click_1(object sender, EventArgs e)
        {
            FornecedorBll fornecedorBll = new FornecedorBll();
            Fornecedor fornecedor = new Fornecedor(razaoSocial: txtBoxRazaoSocial.Text,
                                                   cNPJ: TxtBoxCnpjFornecedor.Text,
                                                   nomeContato: TxtBoxNomeResponsavel.Text,
                                                   email: txtBoxEmail.Text,
                                                   telefone: TxtBoxTelefoneFornecedor.Text);
            Response resposta = fornecedorBll.Insert(fornecedor);
            MessageBox.Show(resposta.Message);
            if (resposta.HasSuccess)
            {
                this.Close();
            }
        }
    }
}
