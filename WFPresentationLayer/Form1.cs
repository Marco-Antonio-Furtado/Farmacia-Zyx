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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MeuMessageBox.Show("algo", "titulo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeuMessageBox.Show("Alguma Coisa Aqui" ,"botao sim ","botao nao");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MeuMessageBox.Show("AlgumaCoisaAquibotaosimbotaonao");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("compara com esse tamnaho", "titulo", MessageBoxButtons.YesNo);
        }
    }
}
