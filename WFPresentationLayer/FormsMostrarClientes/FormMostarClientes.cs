using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;
using WfPresentationLayer.FormCadastros;

namespace WfPresentationLayer.Alteraçoes
{
    public partial class FormMostarClientes : Form
    {
        private Form _objForm1;
        private ClienteBll clienteBLL = new ClienteBll();
        public FormMostarClientes()
        {
            InitializeComponent();
        }
        List<Cliente> Clientes = new List<Cliente>();
        private void FormMostarClientes_Load(object sender, EventArgs e)
        {
            Clientes = clienteBLL.GetAll().Dados;
            foreach (Cliente cliente in Clientes)
            {
                if (cliente.Ativo == true)
                {
                    SincronizarListaGrid(cliente);
                }
            }
        }
        private void PctBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            _objForm1?.Close();
            _objForm1 = new FormCadastroCliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PnlCl.Controls.Add(_objForm1);
            _objForm1.Show();
            _objForm1.BringToFront();
        }
        private void SincronizarListaGrid(Cliente item)
        {
            GridClientes.Rows.Add(item.ID, item.Nome_Cliente,item.Email, item.RG, item.CPF, item.Telefone, item.Telefone2,item.Programa_Fidelidade);
        }

        private void BtnAlterarCliente_Click(object sender, EventArgs e)
        {
            if (this.GridClientes.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.GridClientes.SelectedRows[0];
            if (GridClientes.CurrentRow.Cells[0].Value == null)
            {
                MeuMessageBox.Show("Voce nao selecionou nenhuma coluna");
            }
            else
            {
                Cliente c = new();

                c.ID = Convert.ToInt32(GridClientes.CurrentRow.Cells[0].Value.ToString());
                c.Nome_Cliente = Convert.ToString(GridClientes.CurrentRow.Cells[1].Value.ToString());
                c.Email = Convert.ToString(GridClientes.CurrentRow.Cells[2].Value.ToString());
                c.RG = Convert.ToString(GridClientes.CurrentRow.Cells[3].Value.ToString());
                c.CPF = Convert.ToString(GridClientes.CurrentRow.Cells[4].Value.ToString());
                c.Telefone = Convert.ToString(GridClientes.CurrentRow.Cells[5].Value.ToString());
                c.Telefone2 = Convert.ToString(GridClientes.CurrentRow.Cells[6].Value.ToString());
                _objForm1?.Close();
                _objForm1 = new FormCadastroCliente(c)
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };
                PnlCl.Controls.Add(_objForm1);
                _objForm1.Show();
                _objForm1.BringToFront();
            }
        }

        private void LimparGrid()
        {
            GridClientes.Rows.Clear();
            GridClientes.Refresh();
            GridClientes.DataSource = null;
        }
        private void BtnDeletarClientes_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.GridClientes.SelectedRows[0];
            int IDCLiente = Convert.ToInt32(GridClientes.CurrentRow.Cells[0].Value.ToString());
            string nome = Convert.ToString(GridClientes.CurrentRow.Cells[1].Value.ToString());

            DialogResult r = MeuMessageBox.Show("Deseja Apagar o " + nome + " Da tabela Ou do banco " + "\r\n" + "X Para Voltar","Escolha","Deletar Do banco","deletar da tabela");
            if (r == DialogResult.Yes)
            {
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja deletar o usuario " + nome ," Tem Certeza?","Sim","Nao");
                if (re == DialogResult.Yes)
                {
                    Response resposta = clienteBLL.Delete(IDCLiente);
                    if (resposta.HasSuccess)
                    {
                        MeuMessageBox.Show(resposta.Message, "Deu Certo","OK");
                    }
                    else MeuMessageBox.Show(resposta.Message);
                }
                else { }
            }
            else if(r == DialogResult.No)
            {
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja Apagar o usuario " + nome, " Tem Certeza?", "Sim", "Nao");
                if (re == DialogResult.Yes)
                {
                    Response resposta = clienteBLL.Disable(IDCLiente);
                    if (resposta.HasSuccess)
                    {
                        MeuMessageBox.Show(resposta.Message, "Deu Certo", "OK");
                    }
                    else MeuMessageBox.Show(resposta.Message);
                }
                else { }
            }
            
        }

        private void BtnClienteDesabilitado_Click(object sender, EventArgs e)
        {
            LimparGrid();
            Clientes = clienteBLL.GetAll().Dados;
            foreach (Cliente cliente in Clientes)
            {
                
                if (cliente.Ativo == false)
                {
                    SincronizarListaGrid(cliente);
                }
            }
            if (GridClientes.RowCount == 1)
            {
                MeuMessageBox.Show("Nao há Clientes Desabilitados");
                LimparGrid();
            }
        }
    }
}
