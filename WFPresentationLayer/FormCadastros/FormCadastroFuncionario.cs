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

namespace WfPresentationLayer
{
    public partial class FormCadastroFuncionario : Form
    {
        public FormCadastroFuncionario()
        {
            InitializeComponent();
            ((Control)this.TabEndereco).Enabled = false;
        }
        private void BtnCadastroEndereco_Click_1(object sender, EventArgs e)
        {
            ((Control)this.TabEndereco).Enabled = true;
            this.TabGeral.SelectedIndex = 1;
        }

        private void BtnCadastroFuncionario_Click_1(object sender, EventArgs e)
        {
            EnderecoBll enderecoBll = new EnderecoBll();
            FuncionarioBll funcionarioBll = new FuncionarioBll();
            Endereco EnderecoFuncionario = new Endereco(TxtBoxRua.Text, TxtBoxBairro.Text, TxtBoxCep.Text,
                                                        TxtBoxNumero.Text, TxtBoxComplemento.Text, TxtBoxPontoDeReferencia.Text,
                                                        TxtBoxCidade.Text, TxtBoxEstado.Text);
            Funcionario funcionario = new Funcionario(txtBoxNomeFuncionario.Text, TxtBoxCpfFuncionario.Text,
                                                      TxtBoxRgFuncionario.Text, txtBoxEmailFuncionario.Text,
                                                      TxtBoxTelefone1Funcionario.Text, EnderecoFuncionario, TxtBoxSenhaFuncionario.Text);
            Response respostaEndereco = enderecoBll.Insert(EnderecoFuncionario);
            Response respostaFuncionario = funcionarioBll.Insert(funcionario);


            MessageBox.Show(respostaFuncionario.Message);
            if (respostaFuncionario.HasSuccess)
            {
                this.Close();
            }
        }
    }
}
