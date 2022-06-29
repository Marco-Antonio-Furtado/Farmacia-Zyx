using BusinessLogicalLayer.BusinessLL;
using DataAccessLayer;
using Entities;
using Entities.Propriedades;
using Shared;
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer
{
    public partial class FormCadastroFuncionario : Form
    {
        WfHelperDal wf = new();
        int IdEstado;
        CargoBLL cargo = new();
        FuncionarioBll funcionarioBll = new();

        public FormCadastroFuncionario()
        {
            InitializeComponent();
            ((Control)this.TabEndereco).Enabled = false;
            ((Control)this.CmbBoxCidade).Enabled = false;

            List<Cargo> Cargos = cargo.GetAll().Dados;
            foreach (Cargo cargo in Cargos)
            {
                if(cargo.Ativo = true)
                {
                    CmbBoxCargos.Items.Add(cargo);
                }
            }
            CmbBoxCargos.DisplayMember = "Nome_Cargo";
            CmbBoxCargos.ValueMember = "ID";
        }

        public FormCadastroFuncionario(int iDCLiente, string nome, string email, string rg, string cpf, string telefone, string cargo1)
        {
            InitializeComponent();
            ((Control)this.TabEndereco).Enabled = false;
            ((Control)this.CmbBoxCidade).Enabled = false;

            List<Cargo> Cargos = cargo.GetAll().Dados;
            foreach (Cargo cargo in Cargos)
            {
                if (cargo.Ativo = true)
                {
                    CmbBoxCargos.Items.Add(cargo);
                }
            }
            CmbBoxCargos.DisplayMember = "Nome_Cargo";
            CmbBoxCargos.ValueMember = "ID";

            CmbBoxCargos.DisplayMember = "Nome";
            CmbBoxCargos.ValueMember = "ID";
            txtBoxNomeFuncionario.Text = nome;
            txtBoxEmailFuncionario.Text = email;
            TxtBoxRgFuncionario.Text =rg;
            TxtBoxTelefone1Funcionario.Text = telefone;
            TxtBoxCpfFuncionario.Text = cpf;
            LblIdAlteracao.Visible = true;
            TxtBoxID.Visible = true;
            
        }

        private void BtnCadastroEndereco_Click_1(object sender, EventArgs e)
        {
            ((Control)this.TabEndereco).Enabled = true;
            this.TabGeral.SelectedIndex = 1;
            CmbBoxEstado.DataSource = wf.GetAllEstado().Dados;
            CmbBoxEstado.ValueMember = "Id";
            CmbBoxEstado.DisplayMember = "Nome_Estado";
        }
        private void BtnCadastroFuncionario_Click_1(object sender, EventArgs e)
        {
            string cep = TxtBoxCep.Text;
       
            if (cep == "     -")
            {
                cep = "";
            }
            Cargo cargo = new Cargo(nome: CmbBoxCargos.Text);
            cargo.ID = (int)CmbBoxCargos.SelectedValue;
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
                                                      cargo: cargo,
                                                      endereco: endereco,
                                                      senha: TxtBoxSenhaFuncionario.Text
                                                      ) ;
            funcionario.Ativo = true;
            if (TxtBoxID.Visible == true)
            {
                funcionario.ID = int.Parse(TxtBoxID.Text);
                Response resposta = funcionarioBll.Update(funcionario);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                { this.Close(); }
            }
            else
            {
                Response resposta = funcionarioBll.Insert(funcionario);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                {
                    this.Close();
                }
            }
        }
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

        private void BtnCadastrarCargo_Click(object sender, EventArgs e)
        {
            FormCadastroCargo formCadastroCargo = new FormCadastroCargo();
            formCadastroCargo.Show();
        }
    }
}
