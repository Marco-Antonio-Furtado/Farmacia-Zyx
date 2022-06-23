using BusinessLogicalLayer.BusinessLL;
using Entities.Propriedades;
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
    public partial class FormCadastroCidade : Form
    {
        public FormCadastroCidade()
        {
            InitializeComponent();
        }

        private void BtnCadastrarCidade_Click(object sender, EventArgs e)
        {
            CidadeBLL cidadeBll = new CidadeBLL();
            Cidade cidade = new Cidade(nome: TxtBoxNomeCidade.Text);

            Response resposta = cidadeBll.Insert(cidade);
            if (resposta.HasSuccess)
            {
                MessageBox.Show("Cidade Cadastrado");
            }
            else { MessageBox.Show(resposta.Message); }


        }
    }
}
