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

        public FormCadastroCliente(int IDCLiente,string nome,string email,string Rg,string cpf,string telefone,string telefone2)
        {
            InitializeComponent();
            TxtBoxID.Text = IDCLiente.ToString();
            txtBoxNomeCliente.Text = nome;
            TxtBoxCpfCLiente.Text = cpf;
            txtBoxEmailCliente.Text = email;
            TxtBoxRgCliente.Text= Rg;
            TxtBoxTelefone1Cliente.Text = telefone;
            TxtBoxTelefone2Cliente.Text = telefone2;
            LblIdAlteracao.Visible = true;
            TxtBoxID.Visible = true;
            TxtBoxID.Enabled = false;
        }
        private void BtnCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtBoxNomeCliente.Text, TxtBoxCpfCLiente.Text, TxtBoxRgCliente.Text,
                                          txtBoxEmailCliente.Text, TxtBoxTelefone1Cliente.Text
                                          , TxtBoxTelefone2Cliente.Text);
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
    }
}
