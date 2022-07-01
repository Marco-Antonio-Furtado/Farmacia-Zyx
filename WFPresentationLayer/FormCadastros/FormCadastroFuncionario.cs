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
        List<Cargo> listaAtiva = new List<Cargo>();

        public FormCadastroFuncionario()
        {
            InitializeComponent();
            TabGeral.TabPages.Remove(TabEndereco);

            List<Cargo> Cargos = cargo.GetAll().Dados;
            LblIdAlteracao.Visible = false;
            TxtBoxID.Visible = false;
            LblIdEndereco.Visible = false;
            TxtBoxIDEndereco.Visible = false;

            foreach (Cargo cargo in Cargos)
            {
                if(cargo.Ativo = true)
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
            TabGeral.TabPages.Remove(TabEndereco);
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

            TxtBoxID.Text = fun.ID.ToString();
            txtBoxNomeFuncionario.Text = fun.Nome_Funcionario;
            txtBoxEmailFuncionario.Text = fun.Email;
            TxtBoxRgFuncionario.Text =fun.RG;
            TxtBoxTelefone1Funcionario.Text = fun.Telefone;
            TxtBoxCpfFuncionario.Text = fun.CPF;
            //LblIdAlteracao.Visible = true;
            //TxtBoxID.Visible = true;

        }

        private void BtnCadastroEndereco_Click_1(object sender, EventArgs e)
        {
            if (txtBoxNomeFuncionario.Text == "" || txtBoxEmailFuncionario.Text == "" || TxtBoxCpfFuncionario.Text == "" || TxtBoxTelefone1Funcionario.Text == "" || TxtBoxSenhaFuncionario.Text == "" || TxtBoxRgFuncionario.Text == "")
            {
                MeuMessageBox.Show("Voce nao inseriu todos os campos");
            }
            else 
            {
                TabGeral.TabPages.Add(TabEndereco);
                this.TabGeral.SelectedIndex = 1;
                CmbBoxEstado.ValueMember = "ID";
                CmbBoxEstado.DisplayMember = "Nome_Estado";
                CmbBoxEstado.DataSource = wf.GetAllEstado().Dados;
            }
        }
        private void BtnCadastroFuncionario_Click_1(object sender, EventArgs e)
        {
            string cep = TxtBoxCep.Text;
       int idfunc = int.Parse(TxtBoxID.Text);
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
            if (LblTitulo.Visible == true)
            {
            Funcionario PegarEndereco = funcionarioBll.GetByID(idfunc).Item;

                funcionario.Endereco.ID = PegarEndereco.Endereco.ID;
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

        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
