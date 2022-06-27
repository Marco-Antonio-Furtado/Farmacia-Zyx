using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer.FormCadastros
{
    public partial class FormCadastroFornecedor : Form
    {
        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }
        FornecedorBll fornecedorBll = new FornecedorBll();
        public FormCadastroFornecedor(int iDLab, string? razao, string? email, string? telefone, string? cnpj, string? nomeRes)
        {
            InitializeComponent();
            txtBoxRazaoSocial.Text = razao;
            TxtBoxCnpjFornecedor.Text = cnpj;
            TxtBoxNomeResponsavel.Text = nomeRes;
            txtBoxEmail.Text = email;
            TxtBoxTelefoneFornecedor.Text = telefone;
            TxtBoxID.Text = iDLab.ToString();
            TxtBoxID.Enabled = false;
            TxtBoxID.Visible = true;
            LblIdAlteracao.Visible = true;
        }

        private void BtnCadastroFornecedor_Click_1(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(razaoSocial: txtBoxRazaoSocial.Text,
                                                   cNPJ: TxtBoxCnpjFornecedor.Text,
                                                   nomeContato: TxtBoxNomeResponsavel.Text,
                                                   email: txtBoxEmail.Text,
                                                   telefone: TxtBoxTelefoneFornecedor.Text);
            if (TxtBoxID.Visible == true)
            {
                fornecedor.ID = int.Parse(TxtBoxID.Text);
                Response resposta = fornecedorBll.Update(fornecedor);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                { this.Close(); }
            }
            else
            {
                Response resposta = fornecedorBll.Insert(fornecedor);
                MeuMessageBox.Show(resposta.Message);
                if (resposta.HasSuccess)
                {
                    this.Close();
                }
            }
        }
    }
}
