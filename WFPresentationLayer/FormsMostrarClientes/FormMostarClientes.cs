namespace WfPresentationLayer.Alteraçoes
{
    public partial class FormMostarClientes : Form
    {
        private Form _objForm1;
        public FormMostarClientes()
        {
            InitializeComponent();
        }

        private void PctBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            _objForm1?.Close();
            _objForm1 = new FormCadastroCliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PnlCl.Controls.Add(_objForm1);
            _objForm1.Show();
            _objForm1.BringToFront();
        }
    }
}
