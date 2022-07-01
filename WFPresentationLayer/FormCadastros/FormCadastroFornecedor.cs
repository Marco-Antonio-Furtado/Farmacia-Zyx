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
        FornecedorBll fornecedorBll = new FornecedorBll();
        public FormCadastroFornecedor(Fornecedor forne)
        {
            InitializeComponent();
            LblTitulo.Text = "Alterar Fornecedor";
            txtBoxRazaoSocial.Text = forne.Razao_Social;
            TxtBoxCnpjFornecedor.Text = forne.CNPJ;
            TxtBoxNomeResponsavel.Text = forne.Nome_Contato;
            txtBoxEmail.Text = forne.Email;
            TxtBoxTelefoneFornecedor.Text = forne.Telefone;
            TxtBoxID.Text = forne.ID.ToString();
            TxtBoxID.Enabled = false;
            TxtBoxID.Visible = true;
            LblIdAlteracao.Visible = true;
        }

        private void BtnCadastroFornecedor_Click_1(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(razaoSocial: txtBoxRazaoSocial.Text,
                                                   cNPJ: TxtBoxCnpjFornecedor.Text,
                                                   nomeContato: TxtBoxNomeResponsavel.Text,
                                                   email: txtBoxEmail.Text,
                                                   telefone: TxtBoxTelefoneFornecedor.Text);
            fornecedor.Ativo = true;
            if (TxtBoxID.Visible == true)
            {
                fornecedor.ID = int.Parse(TxtBoxID.Text);
                Response resposta = fornecedorBll.Update(fornecedor);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                { this.Close(); }
            }
            else
            {
                Response resposta = fornecedorBll.Insert(fornecedor);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                {
                    this.Close();
                }
            }
        }

        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
