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
using WfPresentationLayer.Trancaçoes;


namespace WfPresentationLayer
{
    public partial class MenuGeralAdmin : Form
    {
        private Form _objForm;
        public MenuGeralAdmin()
        {
            InitializeComponent();
        }

        private void PctBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BtnMenuVendas_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FormNovaVenda
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            MidlePanel.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void BtnMenuCompras_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FormNovaCompra
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            MidlePanel.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void BtnMenuClientes_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FormCadastroCliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            MidlePanel.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void BtnMenuProduto_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FormCadastroProduto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            MidlePanel.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void BtnMenuFornecedor_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FormCadastroFornecedor
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            MidlePanel.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void BtnMenuFuncionario_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FormCadastroFuncionario
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            MidlePanel.Controls.Add(_objForm);
            _objForm.Show();
        }

        private void PctBack_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
        }
    }
}
