using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer.FormCadastros
{
    public partial class FormCadastrarLaboratorio : Form
    {
        LaboratorioBLL labbll = new LaboratorioBLL();
        public FormCadastrarLaboratorio()
        {
            InitializeComponent();
            TxtBoxId.Visible = false;
            LblIdAlteracao.Visible = false;
        }
        public FormCadastrarLaboratorio(Laboratorio lab)
        {
            InitializeComponent();
            LblText.Text = "Alterar Laboratorio";
            txtBoxRazaoSocial.Text = lab.Razao_Social;
            TxtBoxCnpjFornecedor.Text = lab.CNPJ;
            TxtBoxNomeResponsavel.Text = lab.Nome_Contato;
            txtBoxEmail.Text = lab.Email;
            TxtBoxTelefone.Text = lab.Telefone;
            TxtBoxId.Text = lab.ID.ToString();
            TxtBoxId.Enabled = false;
            TxtBoxId.Visible = true;
            LblIdAlteracao.Visible = true;
        }

        private void BtnCadastroLaboratorio_Click(object sender, EventArgs e)
        {
            Laboratorio lab = new Laboratorio(razaoSocial: txtBoxRazaoSocial.Text,
                                              cNPJ: TxtBoxCnpjFornecedor.Text,
                                              nomeContato: TxtBoxNomeResponsavel.Text,
                                              email: txtBoxEmail.Text,
                                              telefone: TxtBoxTelefone.Text);
            lab.ID = int.Parse(TxtBoxId.Text);
            lab.Ativo = true;
            if (TxtBoxId.Visible == true)
            {
                Response resposta = labbll.Update(lab);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                { this.Close(); }
            }
            else
            {
                Response resposta = labbll.Insert(lab);
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
        private void txtBoxEmail_Enter_1(object sender, EventArgs e)
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
    }
}
