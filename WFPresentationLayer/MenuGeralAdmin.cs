using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using Shared;
using WfPresentationLayer.Alteraçoes;
using WfPresentationLayer.FormCadastros;
using WfPresentationLayer.FormsMostrarClientes;
using WfPresentationLayer.Trancaçoes;


namespace WfPresentationLayer
{
    public partial class MenuGeralAdmin : Form
    {
        private Form _objForm;
        
        public MenuGeralAdmin()
        {
            InitializeComponent();
            LblFuncionarioLogado.Text = "Bem vindo Senhor " + SystemParameters.UsuarioLogado.Nome_Funcionario;
            Cargo ca = SystemParameters.GetPermissao();
            if(ca.Nome_Cargo != "Administrador") { BtnMenuFuncionario.Visible = false; }

        }
        private void PctBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnMenuVendas_Click(object sender, EventArgs e)
        {
            ParametrosDatas Parametros = MeumsgBoxWithDates.ShowMessageWithDates("Selecione a Data De busaca das venda");
            _objForm?.Close();
            _objForm = new FormMostrarSaidas(Parametros)
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
            ParametrosDatas Parametros = MeumsgBoxWithDates.ShowMessageWithDates("Selecione a Data De busaca das venda");
            _objForm?.Close();
            _objForm = new FormMostrarEntradas(Parametros)
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
            _objForm = new FormMostarClientes
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
            _objForm = new FormMostrarProdutos
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
            _objForm = new Alteracao_Fornecedor
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
            _objForm = new Alteracao_Funcionario
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

        private void BtnMostraLab(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new FormMostarLaboratorio
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            MidlePanel.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
