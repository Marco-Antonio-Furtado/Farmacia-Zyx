using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer
{
    public partial class FormCadastroProduto : Form
    {
        LaboratorioBLL LB = new();

        ProdutoBll produtoBll = new();

        public FormCadastroProduto()
        {
            InitializeComponent();
            CmbBoxLaboratorio.DataSource = LB.GetAll().Dados;
            CmbBoxLaboratorio.ValueMember = "ID";
            CmbBoxLaboratorio.DisplayMember = "Razao_Social";
        }

        public FormCadastroProduto(int iDPRoduto, string nome, string laboratorio, string descrisao, string valorcompra)
        {
            InitializeComponent();

            CmbBoxLaboratorio.DataSource = LB.GetAll().Dados;
            CmbBoxLaboratorio.ValueMember = "ID";
            CmbBoxLaboratorio.DisplayMember = "Razao_Social";
            TxtBoxId.Visible = true;
            TxtBoxId.Enabled = false;
            LblIDPRoduto.Visible = true;

            TxtBoxDescrisaoProduto.Text = descrisao;
            TxtBoxId.Text = iDPRoduto.ToString();
            TxtBoxNomeProduto.Text = nome;
            TxtBoxDescrisaoProduto.Text = laboratorio;
            TxtBoxPrecoUnitario.Text = valorcompra;
        }

        private void BtnCadastrarProduto_Click_1(object sender, EventArgs e)
        {
            Laboratorio lab = new Laboratorio();
            lab.ID = Convert.ToInt32(CmbBoxLaboratorio.SelectedValue.ToString());

            Produto produto = new Produto();
            produto.Nome = TxtBoxNomeProduto.Text;
            produto.Descricao = TxtBoxDescrisaoProduto.Text;
            produto.ID_Laboratorio = lab;
            produto.Valor_Unitario = double.Parse(TxtBoxPrecoUnitario.Text);
            if (TxtBoxId.Visible == true)
            {
                produto.ID = int.Parse(TxtBoxId.Text);
                Response resposta = produtoBll.Update(produto);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                { this.Close(); }
            }
            else
            {
                Response resposta = produtoBll.Insert(produto);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                {
                    this.Close();
                }
            }
        }

        private void TxtBoxPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (TxtBoxPrecoUnitario.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }
    }
}
