
using BusinessLogicalLayer;
using Entities;

namespace WfPresentationLayer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            MetodoLogin metodoLogin = new MetodoLogin(TxtBoxLogin.Text, TxtBoxSenha.Text);
            
            if (metodoLogin.IsLoggedIn(metodoLogin))
            {
                LabelResposta.Text = "Bem vindo";
                MenuGeralAdmin menuGeralAdmin = new MenuGeralAdmin();
                    menuGeralAdmin.ShowDialog();
            }else { LabelResposta.Text = "Email ou Senha Invalidos"; }

               
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
    }
}
