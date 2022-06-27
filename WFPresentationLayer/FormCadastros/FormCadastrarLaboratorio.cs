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
        public FormCadastrarLaboratorio(int IDLab,string razao,string email,string telefone,string cnpj,string nomeRes) 
        {
            InitializeComponent();
            txtBoxRazaoSocial.Text = razao;
            TxtBoxCnpjFornecedor.Text = cnpj;
            TxtBoxNomeResponsavel.Text = nomeRes;
            txtBoxEmail.Text = email;
            TxtBoxTelefone.Text = telefone;
            TxtBoxId.Text = IDLab.ToString();
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
    }
}
