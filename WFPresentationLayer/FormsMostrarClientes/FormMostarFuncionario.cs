using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfPresentationLayer.Alteraçoes
{
    public partial class Alteracao_Funcionario : Form
    {
        public Alteracao_Funcionario()
        {
            InitializeComponent();
        }

        private void BtnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroFuncionario form = new FormCadastroFuncionario();
            form.ShowDialog();
        }
    }
}
