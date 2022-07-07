using System.Diagnostics;

namespace WfPresentationLayer
{
    /// <summary>
    /// Form De agradecimento Geral 
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
            Process.Start(new ProcessStartInfo { FileName = "https://www.linkedin.com/in/marco-antônio-furtado-615164221/", UseShellExecute = true });
        }

        private void LinkGabriel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://www.linkedin.com/in/gabriel-felipe-nicoletti-102706191", UseShellExecute = true });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/Marco-Antonio-Furtado/Farmacia-Zyx", UseShellExecute = true });
        }

    }
}
