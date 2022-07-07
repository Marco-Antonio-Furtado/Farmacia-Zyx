using BusinessLogicalLayer.BusinessLL;
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

namespace WfPresentationLayer.FormCadastros
{
    public partial class FormCadastroCargo : Form
    {
        /// <summary>
        /// Form padrao para cadastro de cargo Lembrando que apenas administradores podem 
        /// gerenciar cadastrar alterar deletar e desabilitar funcionarios
        /// </summary>
        public FormCadastroCargo()
        {
            InitializeComponent();
        }

        private void BtnCadastrarCargo_Click(object sender, EventArgs e)
        {
            if (TxtBoxNomeCargo.Text == "Digite o Cargo")
            {
                MeuMessageBox.Show("voce nao informou o nome");
                    return;
            }
            Cargo c = new();  
            c.Nome_Cargo = TxtBoxNomeCargo.Text;

            CargoBLL cargo = new();
            cargo.Insert(c);
        }

        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBoxNomeCargo_Enter(object sender, EventArgs e)
        {
            if (TxtBoxNomeCargo.Text == "Digite o Cargo")
            {
                TxtBoxNomeCargo.Text = "";
            }
            else if (TxtBoxNomeCargo.Text == "")
            {
                TxtBoxNomeCargo.Text = "Digite o Cargo";
            }
        }
    }
}
