using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfPresentationLayer.FormCadastros
{
    public partial class FormCadastroFornecedor : Form
    {
        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void BtnCadastroFornecedor_Click(object sender, EventArgs e)
        {
            FornecedorBll fornecedorBll = new FornecedorBll();
            Fornecedor fornecedor = new Fornecedor(txtBoxRazaoSocial.Text,TxtBoxCnpjFornecedor.Text
                                                  ,TxtBoxNomeResponsavel.Text,txtBoxEmailFornecedor.Text,
                                                  txtBoxEmailFornecedor.Text);
            Response resposta = fornecedorBll.Insert(fornecedor);
            MessageBox.Show(resposta.Message);
            if (resposta.HasSuccess)
            {
                this.Close();
            }
        }
    }
}
