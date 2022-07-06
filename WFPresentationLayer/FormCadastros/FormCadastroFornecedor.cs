using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer.FormCadastros
{
    public partial class FormCadastroFornecedor : Form
    {

        /// <summary>
        /// Form de cadastro de Fornecedor padrao de todo cadastro 
        /// onde o mesmo pode fazer o uptade se a textbox id for visivel 
        /// e insert se nao for visivel 
        /// Uma sobrecarga que abre com Fornecedor ja preenchido para alteracao 
        /// e sem sobrecarga que abre para cadastro 
        /// </summary>
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

        // Metodos padrões Para melhor visualizacao e entendimento do usuario 

        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxRazaoSocial_Enter(object sender, EventArgs e)
        {
            if (txtBoxRazaoSocial.Text == "Digite A Razão Social")
            {
                txtBoxRazaoSocial.Text = "";
            }
            else if (txtBoxRazaoSocial.Text == "")
            {
                txtBoxRazaoSocial.Text = "Digite A Razão Social";
            }
        }

        private void txtBoxEmail_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text == "Digite O Email")
            {
                txtBoxEmail.Text = "";

            }
            else if (txtBoxEmail.Text == "")
            {
                txtBoxEmail.Text = "Digite O Email";
            }
        }

        private void TxtBoxNomeResponsavel_Enter(object sender, EventArgs e)
        {
            if (TxtBoxNomeResponsavel.Text == "Digite O Nome Contato")
            {
                TxtBoxNomeResponsavel.Text = "";
            }
            else if (TxtBoxNomeResponsavel.Text == "")
            {
                TxtBoxNomeResponsavel.Text = "Digite O Nome Contato";
            }
            
        }
    }
}
