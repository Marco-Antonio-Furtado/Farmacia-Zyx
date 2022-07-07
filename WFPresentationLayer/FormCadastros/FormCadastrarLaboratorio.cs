using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer.FormCadastros
{
    /// <summary>
    /// Form de cadastro de Laboratorio padrao de todo cadastro 
    /// onde o mesmo pode fazer o uptade se a textbox id for visivel 
    /// e insert se nao for visivel 
    /// Uma sobrecarga que abre com Laboratorio ja preenchido para alteracao 
    /// e sem sobrecarga que abre para cadastro 
    /// </summary>
    public partial class FormCadastrarLaboratorio : Form
    {
        
        LaboratorioBLL labbll = new();
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
            if (txtBoxRazaoSocial.Text == "Digite A Razão Social" || TxtBoxNomeResponsavel.Text == "Digite O Nome Contato" || txtBoxEmail.Text == "Digite O Email")
            {
                MeuMessageBox.Show("VOce nao informou todos os dados");
                return;
            }
            Laboratorio lab = new(razaoSocial: txtBoxRazaoSocial.Text,
                                              cNPJ: TxtBoxCnpjFornecedor.Text,
                                              nomeContato: TxtBoxNomeResponsavel.Text,
                                              email: txtBoxEmail.Text,
                                              telefone: TxtBoxTelefone.Text);
            lab.Ativo = true;
            if (TxtBoxId.Visible == true)
            {
                lab.ID = int.Parse(TxtBoxId.Text);
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

        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
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
