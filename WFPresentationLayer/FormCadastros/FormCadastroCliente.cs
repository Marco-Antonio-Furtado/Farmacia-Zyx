using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;
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


        private void BtnCadastrarCliente_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtBoxNomeCliente.Text, TxtBoxCpfCLiente.Text, TxtBoxRgCliente.Text,
                                          txtBoxEmailCliente.Text, TxtBoxTelefone1Cliente.Text
                                          , TxtBoxTelefone2Cliente.Text);
            ClienteBll clientebll = new ClienteBll();
            Response resposta = clientebll.Insert(cliente);
            MessageBox.Show(resposta.Message);
            if (resposta.HasSuccess)
            { this.Close(); }
        }
    }
}
