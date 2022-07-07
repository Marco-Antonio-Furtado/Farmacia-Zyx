
using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer
{
    /// <summary>
    /// form de login os mesmo sao passados email e senha para a textbox e comparado com o banco de dados
    /// 
    /// </summary>
    public partial class FormLogin : Form
    {
        FuncionarioBll funcionario = new();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            Response r = Logar(TxtBoxLogin.Text, TxtBoxSenha.Text);

            if (r.HasSuccess)
            {
                LabelResposta.Text = "Bem vindo";
                MenuGeralAdmin menuGeralAdmin = new();
                menuGeralAdmin.ShowDialog();
                this.Close();
            }
            else 
            { 
                LabelResposta.Text = "Email ou Senha Invalidos";
                MeuMessageBox.Show(r.Message);
            }
           
        }
        private Response Logar(string Email,string Senha)
        {
           return funcionario.LoginBLL(Email, Senha);
        }


        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
        private void KeyChanger(object sender, EventArgs e)
        {
             this.TxtBoxSenha.PasswordChar = '*'; 
        }
        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TxtBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if(TxtBoxLogin.Text == "Digite Seu Email")
            {
                TxtBoxLogin.Text = "";
            }
            else if(TxtBoxLogin.Text == "")
            {
                TxtBoxLogin.Text = "Digite Seu Email"; 
            }
        }
        private void TxtBoxSenha_TextChanged(object sender, EventArgs e)
        {
            if (TxtBoxSenha.Text == "Digite Sua Senha")
            {
                TxtBoxSenha.Text = "";
            }
            else if (TxtBoxSenha.Text == "")
            {
                TxtBoxSenha.Text = "Digite Sua Senha";
            }
        }
    }
}
