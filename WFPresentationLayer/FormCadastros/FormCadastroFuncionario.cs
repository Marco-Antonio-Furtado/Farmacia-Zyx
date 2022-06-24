using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer
{
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
            ((Control)this.TabEndereco).Enabled = false;
            //CmbBoxAdmin.DataSource = Enum.GetNames(typeof(Hierarquia));
        }
        private void BtnCadastroEndereco_Click_1(object sender, EventArgs e)
        {
            ((Control)this.TabEndereco).Enabled = true;
            this.TabGeral.SelectedIndex = 1;
        }
        private void BtnCadastroFuncionario_Click_1(object sender, EventArgs e)
        {
            Cargo c = new Cargo(1,"sei la o que o marco quer");
            FuncionarioBll funcionarioBll = new FuncionarioBll();
            Endereco endereco = new Endereco(nomeRua: TxtBoxRua.Text,
                                                        cEP: TxtBoxCep.Text,
                                                        numeroCasa: TxtBoxNumero.Text,
                                                        estadoID: int.Parse(TxtBoxEstado.Text),
                                                        cidadeID: int.Parse(TxtBoxCidade.Text));
            Funcionario funcionario = new Funcionario(nome: txtBoxNomeFuncionario.Text,
                                                      cPF: TxtBoxCpfFuncionario.Text,
                                                      rG: TxtBoxRgFuncionario.Text,
                                                      email: txtBoxEmailFuncionario.Text,
                                                      telefone: TxtBoxTelefone1Funcionario.Text,
                                                      cargo : c,
                                                      endereco: endereco,
                                                      senha: TxtBoxSenhaFuncionario.Text
                                                      
                                                      /*posicaoHierarquica: (Hierarquia)CmbBoxAdmin.SelectedIndex*/);
            Response respostaFuncionario = funcionarioBll.Insert(funcionario);
            MessageBox.Show(respostaFuncionario.Message);
            if (respostaFuncionario.HasSuccess)
            {
                this.Close();
            }
        }
    }
}
