using BusinessLogicalLayer;
using Entities;
using Entities.enums;
using Shared;
using System.Globalization;

namespace WfPresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ((Control)this.tabEndereço).Enabled = false;
        }


        private void btnProximo_Click(object sender, EventArgs e)
        {
            ((Control)this.tabEndereço).Enabled = true;
            this.tabControl1.SelectedIndex = 1;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = Enum.GetNames(typeof(Genero));
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            
        }


        
    }
}