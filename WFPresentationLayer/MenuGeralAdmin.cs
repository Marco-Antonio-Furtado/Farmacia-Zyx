using BusinessLogicalLayer;
using BusinessLogicalLayer.BusinessLL;
using Shared;
using WfPresentationLayer.Alteraçoes;
using WfPresentationLayer.FormCadastros;
using WfPresentationLayer.FormsMostrarClientes;
using WfPresentationLayer.Trancaçoes;


namespace WfPresentationLayer
{
    /// <summary>
    /// Form De menu geral onde antes de ser carregado ele checa se o usuario é administrador e se for ele mostra as alteracoes de funcionarios
    /// no form ele abre o menu de alteracao de todos os campos possiveis (vendas,compras,cliente,produtos,fornecedores,funcionarios,laboratorios
    /// 
    /// </summary>
    public partial class MenuGeralAdmin : Form
    {
        private Form _objForm;
        
        public MenuGeralAdmin()
        {
            InitializeComponent();
            LblFuncionarioLogado.Text = "Bem vindo Senhor " + SystemParameters.UsuarioLogado.Nome_Funcionario;
            Cargo ca = SystemParameters.GetPermissao();
            if(ca.Nome_Cargo != "Administrador") { BtnMenuFuncionario.Visible = false;
                pctFuncionario.Visible = false;
            }
        }
        private void BtnMenuVendas_Click(object sender, EventArgs e)
        {
            PctMenu.Hide();
            LblMenu.Hide();
            ParametrosDatas Parametros = MeumsgBoxWithDates.ShowMessageWithDates("Selecione a Data De busca das Vendas");
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
            PctMenu.Hide();
            LblMenu.Hide();
            ParametrosDatas Parametros = MeumsgBoxWithDates.ShowMessageWithDates("Selecione a Data De busca das Compras");
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
            PctMenu.Hide();
            LblMenu.Hide();

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
            PctMenu.Hide();
            LblMenu.Hide();
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
            PctMenu.Hide();
            LblMenu.Hide();
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
            PctMenu.Hide();
            LblMenu.Hide();
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
        private void BtnMostraLab(object sender, EventArgs e)
        {
            PctMenu.Hide();
            LblMenu.Hide();
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

        /// <summary>
        /// abrir form de agradecimentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PctDuvida_Click(object sender, EventArgs e)
        {
            FormDuvida formDuvida = new FormDuvida();
            formDuvida.ShowDialog();
        }

        /// <summary>
        /// metodo para relogar no sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRelogar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
        private void PctBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PctBack_Click(object sender, EventArgs e)
        {
            _objForm?.Close();
            PctMenu.Show();
            LblMenu.Show();
        }

    }
}
