using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer
{
    public partial class FormCadastroCliente : Form
    {

        /// <summary>
        /// Form de cadastro de Cliente padrao de todo cadastro 
        /// onde o mesmo pode fazer o uptade se a textbox id for visivel 
        /// e insert se nao for visivel 
        /// Uma sobrecarga que abre com cliente ja preenchido para alteracao 
        /// e sem sobrecarga que abre para cadastro 
        /// </summary>
        readonly ClienteBll clientebll = new();
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        public FormCadastroCliente(Cliente cli)
        {
            InitializeComponent();
            LblTitulo.Text = "Alterar Cliente";
            TxtBoxID.Text = cli.ID.ToString();
            txtBoxNomeCliente.Text = cli.Nome_Cliente;
            TxtBoxCpfCLiente.Text = cli.CPF;
            txtBoxEmailCliente.Text = cli.Email;
            TxtBoxRgCliente.Text = cli.RG;
            TxtBoxTelefone1Cliente.Text = cli.Telefone;
            TxtBoxTelefone2Cliente.Text = cli.Telefone2;
            LblIdAlteracao.Visible = true;
            TxtBoxID.Visible = true;
            TxtBoxID.Enabled = false;
        }
        private void BtnCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            if(txtBoxNomeCliente.Text == "Digite o Nome" || txtBoxEmailCliente.Text == "Digite O email" || TxtBoxRgCliente.Text == "Digite o Rg")
            {
                MeuMessageBox.Show("voce nao informou todos os campos");
                return;
            }

            Cliente cliente = new(txtBoxNomeCliente.Text, TxtBoxCpfCLiente.Text, TxtBoxRgCliente.Text,
                                          txtBoxEmailCliente.Text, TxtBoxTelefone1Cliente.Text
                                          , TxtBoxTelefone2Cliente.Text);
            cliente.Ativo = true;


            if (TxtBoxID.Visible == true)
            {

                cliente.ID = int.Parse(TxtBoxID.Text);
                Response resposta = clientebll.Update(cliente);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                { this.Close(); }
            }
            else
            {
                Response resposta = clientebll.Insert(cliente);
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

        private void txtBoxNomeCliente_Enter(object sender, EventArgs e)
        {
            if (txtBoxNomeCliente.Text == "Digite o Nome")
            {
                txtBoxNomeCliente.Text = "";
            }
            else if (txtBoxNomeCliente.Text == "")
            {
                txtBoxNomeCliente.Text = "Digite o Nome";
            }
        }
        private void txtBoxEmailCliente_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmailCliente.Text == "Digite O email")
            {
                txtBoxEmailCliente.Text = "";
            }
            else if (txtBoxEmailCliente.Text == "")
            {
                txtBoxEmailCliente.Text = "Digite O email";
            }

        }

        private void TxtBoxRgCliente_Enter(object sender, EventArgs e)
        {
            if (TxtBoxRgCliente.Text == "Digite o Rg")
            {
                TxtBoxRgCliente.Text = "";
            }
            else if (TxtBoxRgCliente.Text == "")
            {
                TxtBoxRgCliente.Text = "Digite o Rg";
            }
        }
    }
}
