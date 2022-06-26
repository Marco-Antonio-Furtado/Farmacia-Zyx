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
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer.Alteraçoes
{
    public partial class Alteracao_Funcionario : Form
    {
        private Form _objForm2;
       //List<Funcionario> funcionarios = new List<Funcionario>;
        public Alteracao_Funcionario()
        {
            InitializeComponent();

        }

        private void BtnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            
            _objForm2?.Close();
            _objForm2 = new FormCadastroFuncionario
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlFunc.Controls.Add(_objForm2);
            _objForm2.Show();
            _objForm2.BringToFront();
        }
    }
}
