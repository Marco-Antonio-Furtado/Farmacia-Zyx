
using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer
{
    public partial class FormLogin : Form
    {
        FuncionarioBll funcionario = new FuncionarioBll();
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
                MenuGeralAdmin menuGeralAdmin = new MenuGeralAdmin();
                menuGeralAdmin.ShowDialog();
                this.Close();
            }
            else 
            { 
                LabelResposta.Text = "Email ou Senha Invalidos";
                MeuMessageBox.Show(r.Message);
            }
           
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
        private void KeyChanger(object sender, EventArgs e)
        {
             this.TxtBoxSenha.PasswordChar = '*'; 
        }
        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Response Logar(string Email,string Senha)
        {
            
           return funcionario.LoginBLL(Email, Senha);
            
        }
    }
}
