using BusinessLogicalLayer.BusinessLL;
using Entities;
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

namespace WfPresentationLayer.Alteraçoes
{
    public partial class Alteracao_Funcionario : Form
    {
        private Form _objForm2;
        FuncionarioBll funcionarioBll = new FuncionarioBll();

        public Alteracao_Funcionario()
        {
            InitializeComponent();
        }
        List<Funcionario> funcionarios = new List<Funcionario>();


        private void BtnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            
            _objForm2?.Close();
            _objForm2 = new FormCadastroFuncionario
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlFunc.Controls.Add(_objForm2);
            _objForm2.Show();
            _objForm2.BringToFront();
        }

        private void Alteracao_Funcionario_Load(object sender, EventArgs e)
        {
            funcionarios = funcionarioBll.GetAll().Dados;
            foreach (Funcionario Funcionario in funcionarios)
            {
                SincronizarListaGrid(Funcionario);
            }
        }

        private void SincronizarListaGrid(Funcionario item)
        {
            GridFuncionario.Rows.Add(item.ID, item.Nome, item.RG, item.CPF,item.Telefone, item.Email,item.Endereco.CidadeID.ToString(),item.Cargo.Nome);
        }
    }
}
