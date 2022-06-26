using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer.FormsMostrarClientes
{
    public partial class FormMostarLaboratorio : Form
    {
        Form _objForm5;
        public FormMostarLaboratorio()
        {
            InitializeComponent();
        }

        private void BtnCadastrarlaboratorio_Click(object sender, EventArgs e)
        {
            _objForm5?.Close();
            _objForm5 = new FormCadastrarLaboratorio
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PNLLaboratorio.Controls.Add(_objForm5);
            _objForm5.Show();
            _objForm5.BringToFront();
        }
    }
}
