using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer
{
    public partial class FormCadastroCliente : Form
    {
        ClienteBll clientebll = new ClienteBll();
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
            TxtBoxRgCliente.Text= cli.RG;
            TxtBoxTelefone1Cliente.Text = cli.Telefone;
            TxtBoxTelefone2Cliente.Text = cli.Telefone2;
            LblIdAlteracao.Visible = true;
            TxtBoxID.Visible = true;
            TxtBoxID.Enabled = false;
        }
        private void BtnCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtBoxNomeCliente.Text, TxtBoxCpfCLiente.Text, TxtBoxRgCliente.Text,
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

        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
