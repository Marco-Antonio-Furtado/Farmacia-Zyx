using BusinessLogicalLayer.BusinessLL;
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
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
            //((Control)this.tabEndereço).Enabled = false;
            //((Control)this.tabEndereço).Enabled = true;
            //this.tabControl1.SelectedIndex = 1;
        }

        private void BtnCadastraFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioBll funcionarioBll = new FuncionarioBll();
            Funcionario funcionario = new Funcionario(txtBoxNomeFuncionario.Text,TxtBoxCpfFuncionario.Text,TxtBoxRgFuncionario.Text,
                                          txtBoxEmailFuncionario.Text,TxtBoxTelefone1Funcionario.Text
                                          ,TxtBoxEnderecoFuncionario.ToString(),TxtBoxSenhaFuncionario.Text)
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (co)
        }
    }
}
