using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer.FormCadastros
{
    public partial class FormCadastroEstado : Form
    {
        public FormCadastroEstado()
        {
            InitializeComponent();
        }

        private void BtnCadastrarEstado_Click(object sender, EventArgs e)
        {

            EstadoBLL estadobll = new EstadoBLL();
            Estado estado = new Estado(nome: TxtBoxNome.Text,
                                        uF: TxtBoxUf.Text);
            Response resposta = estadobll.Insert(estado);

            if (resposta.HasSuccess)
            {
                MessageBox.Show("Estado Cadastrado");
            }
            else { MessageBox.Show(resposta.Message); }

        }
    }
}
