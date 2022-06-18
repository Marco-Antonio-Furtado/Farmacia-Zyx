using BusinessLogicalLayer;
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
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtBoxNomeCliente.Text, TxtBoxCpfCLiente.Text, TxtBoxRgCliente.Text,
                                          txtBoxEmailCliente.Text, TxtBoxTelefone1Cliente.Text
                                          , TxtBoxTelefone2Cliente.Text);
            ClienteBll clientebll = new ClienteBll();
            string resposta = clientebll.Insert(cliente).Message;
            MessageBox.Show(resposta);
            //Nao sei se possso esse if
            if (resposta == "iria pro banco")
            { this.Close();  }

        }
    }
}
