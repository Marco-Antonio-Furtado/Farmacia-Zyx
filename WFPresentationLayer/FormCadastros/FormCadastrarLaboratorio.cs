using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer.FormCadastros
{
    public partial class FormCadastrarLaboratorio : Form
    {
        public FormCadastrarLaboratorio()
        {
            InitializeComponent();
        }

        private void BtnCadastroLaboratorio_Click(object sender, EventArgs e)
        {
            Laboratorio lab = new Laboratorio(razaoSocial: txtBoxRazaoSocial.Text,
                                              cNPJ: TxtBoxCnpjFornecedor.Text,
                                              nomeContato: TxtBoxNomeResponsavel.Text,
                                              email: txtBoxEmail.Text,
                                              telefone: TxtBoxTelefone.Text);
            LaboratorioBLL labbll = new LaboratorioBLL();
            Response resposta = labbll.Insert(lab);
            MessageBox.Show(resposta.Message,"Titulo do message");
            if (resposta.HasSuccess)
            {
                this.Close();
            }


        }
    }
}
