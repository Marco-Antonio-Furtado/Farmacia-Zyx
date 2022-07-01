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
    public partial class MeumsgBoxWithDates : Form
    {
        public MeumsgBoxWithDates()
        {
            InitializeComponent();
        }

        public ParametrosDatas ParametrosDatas { get; set; }

        public static ParametrosDatas ShowMessageWithDates(string mensagem)
        {
            var msgBox = new MeumsgBoxWithDates();
            msgBox.LblMensagem.MaximumSize = new Size(124, 45);
            msgBox.LblMensagem.MinimumSize = new Size(280, 124);
            msgBox.LblMensagem.AutoSize = true;
            msgBox.LblMensagem.Text = mensagem;
            msgBox.BtnOk.Visible = true;
            msgBox.ShowDialog();
            return msgBox.ParametrosDatas;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnOk_Click_1(object sender, EventArgs e)
        {
            ParametrosDatas parametros = new ParametrosDatas()
            {
                Inicio = DataInicio.Value,
                Fim = DataFim.Value,
            };
            this.ParametrosDatas = parametros;
            this.Close();
        }
    }

    //public struct ParametrosDatas
    //{
    //    public DateTime Inicio { get; set; }
    //    public DateTime Fim { get; set; }
    //}

}
