using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer
{
    public partial class FormCadastroProduto : Form
    {
        LaboratorioBLL LB = new LaboratorioBLL();
        public FormCadastroProduto()
        {
            InitializeComponent();
            CmbBoxLaboratorio.DataSource = LB.GetAll().Dados;
            CmbBoxLaboratorio.DisplayMember = "razaoSocial";
        }
        private void BtnCadastrarProduto_Click_1(object sender, EventArgs e)
        {
            
            CmbBoxLaboratorio.ValueMember = "ID";

            Produto produto = new Produto(nome: TxtBoxNomeProduto.Text,
                                          descricao: TxtBoxDescrisaoProduto.Text,
                                          laboratorio: CmbBoxLaboratorio.SelectedIndex + 1,
                                          valorunitario: double.Parse(TxtBoxPrecoProduto.Text));
                
            ProdutoBll produtoBll = new ProdutoBll();
            Response resposta = produtoBll.Insert(produto);
            MessageBox.Show(resposta.Message);
            if (resposta.HasSuccess)
            {
                this.Close();
            }
        }

        private void TxtBoxPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (TxtBoxPrecoProduto.Text.Contains(","))
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
