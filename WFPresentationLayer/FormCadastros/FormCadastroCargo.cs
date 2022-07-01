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
        public FormCadastroCargo()
        {
            InitializeComponent();
        }

        private void BtnCadastrarCargo_Click(object sender, EventArgs e)
        {
            Cargo c = new Cargo();  
            c.Nome_Cargo = TxtBoxNomeCargo.Text;

            CargoBLL cargo = new CargoBLL();
            cargo.Insert(c);
        }

        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
