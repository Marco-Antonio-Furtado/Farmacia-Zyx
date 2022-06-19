using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("Logado");
                MenuGeralAdmin menuGeralAdmin = new MenuGeralAdmin();
                
                    menuGeralAdmin.ShowDialog();
                
            }else { MessageBox.Show("tente novamente"); }

               
        }
    }
}
