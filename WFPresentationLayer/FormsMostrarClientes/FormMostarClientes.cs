using BusinessLogicalLayer.BusinessLL;
using Entities;

namespace WfPresentationLayer.Alteraçoes
{
    public partial class FormMostarClientes : Form
    {
        private Form _objForm1;
        private ClienteBll clienteBLL = new ClienteBll();
        public FormMostarClientes()
        {
            InitializeComponent();
            List<Cliente> Clientes = clienteBLL.GetAll().Dados;
            foreach (Cliente cliente in Clientes)
            {
                SincronizarListaGrid(cliente);
            }
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
        private void SincronizarListaGrid(Cliente item)
        {
            GridClientes.Rows.Add(item.ID, item.Nome,item.Email, item.RG, item.CPF, item.Telefone, item.Telefone2);
        }
    }
}
