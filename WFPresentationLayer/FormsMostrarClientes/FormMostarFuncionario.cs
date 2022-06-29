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
                if (Funcionario.Ativo == true)
                {
                    SincronizarListaGrid(Funcionario);
                }
            }
        }
        private void SincronizarListaGrid(Funcionario item)
        {
            GridFuncionario.Rows.Add(item.ID, item.Nome_Funcionario, item.RG, item.CPF,item.Telefone, item.Email,item.Endereco.Cidade.Nome_Cidade,item.Cargo.Nome_Cargo);
        }
        private void BtnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.GridFuncionario.SelectedRows[0];
            int IDCLiente = Convert.ToInt32(GridFuncionario.CurrentRow.Cells[0].Value.ToString());
            string nome = Convert.ToString(GridFuncionario.CurrentRow.Cells[1].Value.ToString());

            DialogResult r = MeuMessageBox.Show("Deseja Apagar o " + nome + " Da tabela Ou do banco " + "\r\n" + "X Para Voltar", "Escolha", "Deletar Do banco", "deletar da tabela");
            if (r == DialogResult.Yes)
            {
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja deletar o Funcionario " + nome, " Tem Certeza?", "Sim", "Nao");
                if (re == DialogResult.Yes)
                {
                    Response resposta = funcionarioBll.Delete(IDCLiente);
                    if (resposta.HasSuccess)
                    {
                        MeuMessageBox.Show(resposta.Message, "Deu Certo", "OK");
                    }
                    else MeuMessageBox.Show(resposta.Message);
                }
                else { }
            }
            else if (r == DialogResult.No)
            {
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja Apagar o Funcionario " + nome, " Tem Certeza?", "Sim", "Nao");
                if (re == DialogResult.Yes)
                {
                    Response resposta = funcionarioBll.Disable(IDCLiente);
                    if (resposta.HasSuccess)
                    {
                        MeuMessageBox.Show(resposta.Message, "Deu Certo", "OK");
                    }
                    else MeuMessageBox.Show(resposta.Message);
                }
                else { }
            }
        }

        private void BtnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.GridFuncionario.SelectedRows[0];
            int i = 32;
            if (GridFuncionario.CurrentRow.Cells[0].Value == null)
            {
                MeuMessageBox.Show("Voce nao selecionou nenhuma coluna");
            }
            else
            {
                int IDCLiente = Convert.ToInt32(GridFuncionario.CurrentRow.Cells[0].Value.ToString());
                string nome = Convert.ToString(GridFuncionario.CurrentRow.Cells[1].Value.ToString());
                string Rg = Convert.ToString(GridFuncionario.CurrentRow.Cells[2].Value.ToString());
                string cpf = Convert.ToString(GridFuncionario.CurrentRow.Cells[3].Value.ToString());
                string telefone = Convert.ToString(GridFuncionario.CurrentRow.Cells[4].Value.ToString());
                string email = Convert.ToString(GridFuncionario.CurrentRow.Cells[5].Value.ToString());
                string Endereco = Convert.ToString(GridFuncionario.CurrentRow.Cells[6].Value.ToString());
                string Cargo = Convert.ToString(GridFuncionario.CurrentRow.Cells[7].Value.ToString());

                _objForm2?.Close();
                _objForm2 = new FormCadastroFuncionario(IDCLiente, nome, email, Rg, cpf, telefone, Cargo)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };
                pnlFunc.Controls.Add(_objForm2);
                _objForm2.Show();
                _objForm2.BringToFront();
            }
        }

        private void BtnDesabilitados_Click(object sender, EventArgs e)
        {
            LimparGrid();
            funcionarios = funcionarioBll.GetAll().Dados;
            foreach (Funcionario Funcionario in funcionarios)
            {
                if (Funcionario.Ativo == false)
                {
                    SincronizarListaGrid(Funcionario);
                }
            }
            if (GridFuncionario.DataSource == null)
            {
                MeuMessageBox.Show("Nao a Funcionarios Desabilitados");
            }
        }
        private void LimparGrid()
        {
            GridFuncionario.Rows.Clear();
            GridFuncionario.Refresh();
            GridFuncionario.DataSource = null;
        }
    }
}
