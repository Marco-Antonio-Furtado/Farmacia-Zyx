using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;
using System.ComponentModel;

namespace WfPresentationLayer.Alteraçoes
{

    /// <summary>
    /// Form Padrão mostrar Funcionarios em uma datagrid 
    /// dentro desse form a algumas Funcoes que ele faz dentro delas 
    /// Cadastro de Funcionarios que abre o form de cliente vazio
    /// alterar NOME_FUNCIONARIO que abre o form de cadastro de NOME_FUNCIONARIO preenchido onde o mesmo é feito clicando na linha e clicando no botao
    /// mostrar desabilitados mostra na grid todos os Funcionarios desabilitados
    /// deletar deleta ou desabilita os NOME_FUNCIONARIO da grid e do banco de dados onde o mesmo é feito clicando na linha e clicando no botao
    /// 
    /// onde todos esse forms sao aberto dentro de um panel padrão
    /// </summary>
    public partial class Alteracao_Funcionario : Form
    {
        private Form _objForm2;
        FuncionarioBll funcionarioBll = new FuncionarioBll();

        public Alteracao_Funcionario()
        {
            InitializeComponent();
        }
        List<Funcionario> funcionarios = new List<Funcionario>();
        private void BtnCadastrarFuncionario_Click(object sender, EventArgs e)
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
        private void BtnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            if (this.GridFuncionario.SelectedRows.Count == 0)
            {
                return;
            }
            if (GridFuncionario.CurrentRow.Cells[0].Value == null)
            {
                MeuMessageBox.Show("Voce nao selecionou nenhuma coluna");
                return;
            }
            DataGridViewRow row = this.GridFuncionario.SelectedRows[0];
            int IDCLiente = Convert.ToInt32(GridFuncionario.CurrentRow.Cells[0].Value.ToString());
            string nome = Convert.ToString(GridFuncionario.CurrentRow.Cells[1].Value.ToString());

            DialogResult r = MeuMessageBox.Show("Deseja Apagar o NOME_FUNCIONARIO " + nome + " Da tabela Ou do banco " + "\r\n" + "X Para Voltar", "Escolha", "Deletar Do banco", "deletar da tabela");
            if (r == DialogResult.Yes)
            {
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja deletar o NOME_FUNCIONARIO " + nome, " Tem Certeza?", "Sim", "Nao");
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
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja Apagar o NOME_FUNCIONARIO " + nome, " Tem Certeza?", "Sim", "Nao");
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
            if (this.GridFuncionario.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.GridFuncionario.SelectedRows[0];
            int i = 32;
            if (GridFuncionario.CurrentRow.Cells[0].Value == null)
            {
                MeuMessageBox.Show("Voce nao selecionou nenhuma coluna");
            }
            else
            {
                Funcionario fun = new();
                Cargo c = new();
                fun.ID = Convert.ToInt32(GridFuncionario.CurrentRow.Cells[0].Value.ToString());
                fun.Nome_Funcionario = Convert.ToString(GridFuncionario.CurrentRow.Cells[1].Value.ToString());
                fun.RG = Convert.ToString(GridFuncionario.CurrentRow.Cells[2].Value.ToString());
                fun.CPF = Convert.ToString(GridFuncionario.CurrentRow.Cells[3].Value.ToString());
                fun.Telefone = Convert.ToString(GridFuncionario.CurrentRow.Cells[4].Value.ToString());
                fun.Email = Convert.ToString(GridFuncionario.CurrentRow.Cells[5].Value.ToString());
                c.Nome_Cargo = Convert.ToString(GridFuncionario.CurrentRow.Cells[7].Value.ToString());
                fun.Cargo = c;
                _objForm2?.Close();
                _objForm2 = new FormCadastroFuncionario(fun)
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
            if (GridFuncionario.RowCount == 1)
            {
                MeuMessageBox.Show("Nao há Funcionarios Desabilitados");
                LimparGrid();
            }
        }
        private void SincronizarListaGrid(Funcionario item)
        {
            GridFuncionario.Rows.Add(item.ID, item.Nome_Funcionario, item.RG, item.CPF,item.Telefone, item.Email,item.Endereco.Cidade.Nome_Cidade,item.Cargo.Nome_Cargo);
            GridFuncionario.Sort(GridFuncionario.Columns[0], ListSortDirection.Ascending);
        }


        // Metodos padrões Para melhor visualizacao e entendimento do usuario 
        private void LimparGrid()
        {
            GridFuncionario.Rows.Clear();
            GridFuncionario.Refresh();
            GridFuncionario.DataSource = null;
        }

    }
}
