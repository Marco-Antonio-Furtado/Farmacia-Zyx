using System.Diagnostics;

namespace WfPresentationLayer
{

    /// <summary>
    /// Form De agradecimento Geral pela oportunidade que o programa tras
    /// </summary>
    public partial class FormDuvida : Form
    {
        public FormDuvida()
        {
            InitializeComponent();
        }
        private void ImageBtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LinkMarco_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://www.linkedin.com/in/marco-ant%C3%B4nio-furtado-615164221", UseShellExecute = true });
        }
        private void LinkGabriel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://www.linkedin.com/in/gabriel-felipe-nicoletti-102706191", UseShellExecute = true });
        }
    }
}
