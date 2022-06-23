using BusinessLogicalLayer.BusinessLL;
using Entities;
using Entities.enums;
using Shared;
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer
{
    public partial class FormCadastroFuncionario : Form
    {
        
        public FormCadastroFuncionario()
        {
            InitializeComponent();
            ((Control)this.TabEndereco).Enabled = false;
            CmbBoxAdmin.DataSource = Enum.GetNames(typeof(Hierarquia));
        }

        private Form _objForm1;
        private void BtnCadastroEndereco_Click_1(object sender, EventArgs e)
        {
            ((Control)this.TabEndereco).Enabled = true;
            this.TabGeral.SelectedIndex = 1;
        }

        private void BtnCadastroFuncionario_Click_1(object sender, EventArgs e)
        {
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
                                                      telefone1: TxtBoxTelefone1Funcionario.Text,
                                                      endereco: endereco,
                                                      senha: TxtBoxSenhaFuncionario.Text,
                                                      posicaoHierarquica: (Hierarquia)CmbBoxAdmin.SelectedIndex);
            Response respostaFuncionario = funcionarioBll.Insert(funcionario);
            MessageBox.Show(respostaFuncionario.Message);
            if (respostaFuncionario.HasSuccess)
            {
                this.Close();
            }
        }

        private void BtnCadastrarEstado_Click(object sender, EventArgs e)
        {
            _objForm1?.Close();
            _objForm1 = new FormCadastroEstado
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PanelAddUF.Controls.Add(_objForm1);
            _objForm1.Show();
        }            

        private void BtnCadastrarCidade_Click(object sender, EventArgs e)
        {
            _objForm1?.Close();
            _objForm1 = new FormCadastroCidade
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PanelAddUF.Controls.Add(_objForm1);
            _objForm1.Show();
        }
    }
}
