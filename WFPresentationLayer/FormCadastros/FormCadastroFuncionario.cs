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

        private void BtnCadastroEndereco_Click(object sender, EventArgs e)
        {
            ((Control)this.TabEndereco).Enabled = true;
            this.TabGeral.SelectedIndex = 1;
        }

        private void BtnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioBll funcionarioBll = new FuncionarioBll();
            Endereco EnderecoFuncionario = new Endereco(TxtBoxRua.Text, TxtBoxBairro.Text, TxtBoxCep.Text, 
                                                        TxtBoxNumero.Text,TxtBoxComplemento.Text, TxtBoxPontoDeReferencia.Text,
                                                        TxtBoxCidade.Text, TxtBoxEstado.Text);
            Funcionario funcionario = new Funcionario(txtBoxNomeFuncionario.Text, TxtBoxCpfFuncionario.Text,
                                                      TxtBoxRgFuncionario.Text, txtBoxEmailFuncionario.Text,
                                                      TxtBoxTelefone1Funcionario.Text, EnderecoFuncionario, TxtBoxSenhaFuncionario.Text);
            Response resposta = funcionarioBll.Insert(funcionario);


            MessageBox.Show(resposta.Message);
            if (resposta.HasSuccess)
            {
                this.Close();
            }

        }
    }
}
