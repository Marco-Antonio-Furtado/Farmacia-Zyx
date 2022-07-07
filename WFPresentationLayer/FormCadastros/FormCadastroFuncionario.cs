using BusinessLogicalLayer.BusinessLL;
using DataAccessLayer;
using Entities;
using Entities.Propriedades;
using Shared;
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer
{


    /// <summary>
    /// Form de cadastro de NOME_FUNCIONARIO padrao de todo cadastro 
    /// onde o mesmo pode fazer o uptade se a textbox id for visivel 
    /// e insert se nao for visivel 
    /// Uma sobrecarga que abre com NOME_FUNCIONARIO ja preenchido para alteracao 
    /// e sem sobrecarga que abre para cadastros 
    /// </summary>
    public partial class FormCadastroFuncionario : Form
    {
        WfHelperDal wf = new();
        int IdEstado;
        CargoBLL cargo = new();
        FuncionarioBll funcionarioBll = new();
        List<Cargo> listaAtiva = new();

        public FormCadastroFuncionario()
        {
            InitializeComponent();
            TxtBoxIDfunci.Visible = false;
            LblIDfunci.Visible = false;
            List<Cargo> Cargos = cargo.GetAll().Dados;

            foreach (Cargo cargo in Cargos)
            {
                if (cargo.Ativo == true)
                {
                    listaAtiva.Add(cargo);
                }
            }
            CmbBoxCargos.DisplayMember = "Nome_Cargo";
            CmbBoxCargos.ValueMember = "ID";
            CmbBoxCargos.DataSource = listaAtiva;
        }

        public FormCadastroFuncionario(Funcionario fun)
        {
            InitializeComponent();
            TxtBoxIDfunci.Visible = true;
            LblIDfunci.Visible = true;
            LblTitulo.Text = "Alterar Funcionario";
            List<Cargo> Cargos = cargo.GetAll().Dados;
            foreach (Cargo cargo in Cargos)
            {
                if (cargo.Ativo = true)
                {
                    listaAtiva.Add(cargo);
                }
            }
            CmbBoxCargos.DisplayMember = "Nome_Cargo";
            CmbBoxCargos.ValueMember = "ID";
            CmbBoxCargos.DataSource = listaAtiva;

            TxtBoxIDfunci.Text = fun.ID.ToString();
            txtBoxNomeFuncionario.Text = fun.Nome_Funcionario;
            txtBoxEmailFuncionario.Text = fun.Email;
            TxtBoxRgFuncionario.Text = fun.RG;
            TxtBoxTelefone1Funcionario.Text = fun.Telefone;
            
            TxtBoxCpfFuncionario.Text = fun.CPF;


            TxtBoxCep.Text = fun.Endereco.CEP;

        }

        private void BtnCadastroEndereco_Click_1(object sender, EventArgs e)
        {

            if (txtBoxNomeFuncionario.Text == "Digite o Nome" || txtBoxEmailFuncionario.Text == "Digite o Email" || TxtBoxCpfFuncionario.Text == "" || TxtBoxTelefone1Funcionario.Text == "" || TxtBoxSenhaFuncionario.Text == "" || TxtBoxRgFuncionario.Text == "Digite o Rg")
            {
                MeuMessageBox.Show("Voce nao inseriu todos os campos");
                return;
            }
            else
            {
                this.TabGeral.SelectedIndex = 1;
                CmbBoxEstado.ValueMember = "ID";
                CmbBoxEstado.DisplayMember = "Nome_Estado";
                CmbBoxEstado.DataSource = wf.GetAllEstado().Dados;
            }
            
        }
        private void BtnCadastroFuncionario_Click_1(object sender, EventArgs e)
        {
            string cep = TxtBoxCep.Text;
            if (cep == "     -")
            {
                cep = "";
            }

            if (TxtBoxIDfunci.Text != "")
            {
                Funcionario funcionario = funcionarioBll.GetByID(int.Parse(TxtBoxIDfunci.Text)).Item;
                TxtBoxCep.Text = funcionario.Endereco.CEP;
                Response r = funcionarioBll.Update(funcionario);
                MeuMessageBox.Show(r.Message);
                if (r.HasSuccess)
                { this.Close(); }
            }
            else
            {
                Cargo cargo = new(nome: CmbBoxCargos.Text);
                cargo.ID = (int)CmbBoxCargos.SelectedValue;
                Endereco endereco = new(nomeRua: TxtBoxRua.Text,
                                                            cEP: cep,
                                                            numeroCasa: TxtBoxNumero.Text,
                                                            estadoID: (int)CmbBoxEstado.SelectedValue,
                                                            cidadeID: (int)CmbBoxCidade.SelectedValue);
                Funcionario funcionario = new(nome: txtBoxNomeFuncionario.Text,
                                                          cPF: TxtBoxCpfFuncionario.Text,
                                                           rG: TxtBoxRgFuncionario.Text,
                                                          email: txtBoxEmailFuncionario.Text,
                                                          telefone: TxtBoxTelefone1Funcionario.Text,
                                                          cargo: cargo,
                                                          endereco: endereco,
                                                          senha: TxtBoxSenhaFuncionario.Text
                                                          );
                funcionario.Ativo = true;
                Response resposta = funcionarioBll.Insert(funcionario);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                {
                    this.Close();
                }
            }

        }
        private void BtnCadastrarCargo_Click(object sender, EventArgs e)
        {
            FormCadastroCargo formCadastroCargo = new();
            formCadastroCargo.Show();
        }




        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
        private void TxtBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.KeyChar = ',';
                if (TxtBoxNumero.Text.Contains(","))
                {
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void CmbBoxEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            IdEstado = CmbBoxEstado.SelectedIndex + 1;
            CmbBoxCidade.DataSource = wf.GetAllCidade(IdEstado).Dados;
            CmbBoxCidade.DisplayMember = "Nome_Cidade";
            CmbBoxCidade.Enabled = true;
            CmbBoxCidade.ValueMember = "Id";
        }
        private void CmbBoxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            CmbBoxCidade.DroppedDown = true;
        }
        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtBoxNomeFuncionario_Enter(object sender, EventArgs e)
        {
            if (txtBoxNomeFuncionario.Text == "Digite o Nome")
            {
                txtBoxNomeFuncionario.Text = "";
            }
            else if (txtBoxNomeFuncionario.Text == "")
            {
                txtBoxNomeFuncionario.Text = "Digite o Nome";
            }
        }
        private void txtBoxEmailFuncionario_Enter(object sender, EventArgs e)
        {
            if (txtBoxEmailFuncionario.Text == "Digite o Email")
            {
                txtBoxEmailFuncionario.Text = "";
            }
            else if (txtBoxEmailFuncionario.Text == "")
            {
                txtBoxEmailFuncionario.Text = "Digite o Email";
            }
        }
        private void TxtBoxRgFuncionario_Enter(object sender, EventArgs e)
        {
            if (TxtBoxRgFuncionario.Text == "Digite o Rg")
            {
                TxtBoxRgFuncionario.Text = "";
            }
            else if (TxtBoxRgFuncionario.Text == "")
            {
                TxtBoxRgFuncionario.Text = "Digite o Rg";
            }
        }
    }
}
