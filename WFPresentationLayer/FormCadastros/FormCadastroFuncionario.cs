using BusinessLogicalLayer.BusinessLL;
using DataAccessLayer;
using Entities;
using Entities.Propriedades;
using Shared;

namespace WfPresentationLayer
{
    public partial class FormCadastroFuncionario : Form
    {
        wFPhelperDAL wf = new wFPhelperDAL();
        int IdEstado;
        public FormCadastroFuncionario()
        {
            InitializeComponent();
            ((Control)this.TabEndereco).Enabled = false;
            ((Control)this.CmbBoxCidade).Enabled = false;
        }
        
        private void BtnCadastroEndereco_Click_1(object sender, EventArgs e)
        {
            ((Control)this.TabEndereco).Enabled = true;
            this.TabGeral.SelectedIndex = 1;
            CmbBoxEstado.DataSource = wf.GetAllEstado().Dados;
            CmbBoxEstado.ValueMember = "Id";
            CmbBoxEstado.DisplayMember = "Nome";
        }
        private void BtnCadastroFuncionario_Click_1(object sender, EventArgs e)
        {
            string cep = TxtBoxCep.Text;
       
            if (cep == "     -")
            {
                cep = "";
            }
            Cargo c = new Cargo(1,"sei la o que o marco quer");
            
            FuncionarioBll funcionarioBll = new FuncionarioBll();
            Endereco endereco = new Endereco(nomeRua: TxtBoxRua.Text,
                                                        cEP: cep,
                                                        numeroCasa: TxtBoxNumero.Text,
                                                        estadoID: (int)CmbBoxEstado.SelectedValue,
                                                        cidadeID: (int)CmbBoxCidade.SelectedValue);
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

        private void TxtBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (TxtBoxNumero.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void CmbBoxEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            IdEstado = CmbBoxEstado.SelectedIndex + 1;
            CmbBoxCidade.DataSource = wf.GetAllCidade(IdEstado).Dados;
            CmbBoxCidade.DisplayMember = "nome";
            CmbBoxCidade.Enabled = true;
            CmbBoxCidade.ValueMember = "Id";
        }

        private void CmbBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            CmbBoxCidade.DroppedDown = true;
        }
    }
}
