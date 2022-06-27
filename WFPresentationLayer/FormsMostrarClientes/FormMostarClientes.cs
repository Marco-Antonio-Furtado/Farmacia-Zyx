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
                SincronizarListaGrid(cliente);
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
            GridClientes.Rows.Add(item.ID, item.Nome,item.Email, item.RG, item.CPF, item.Telefone, item.Telefone2);
        }

        private void BtnAlterarCliente_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow row = this.GridClientes.SelectedRows[0];
            int i = 32;
            if (GridClientes.CurrentRow.Cells[0].Value == null)
            {
                MeuMessageBox.Show("Voce nao selecionou nenhuma coluna");
            }
            else
            {
                int IDCLiente = Convert.ToInt32(GridClientes.CurrentRow.Cells[0].Value.ToString());
                string nome = Convert.ToString(GridClientes.CurrentRow.Cells[1].Value.ToString());
                string email = Convert.ToString(GridClientes.CurrentRow.Cells[2].Value.ToString());
                string Rg = Convert.ToString(GridClientes.CurrentRow.Cells[3].Value.ToString());
                string cpf = Convert.ToString(GridClientes.CurrentRow.Cells[4].Value.ToString());
                string telefone = Convert.ToString(GridClientes.CurrentRow.Cells[5].Value.ToString());
                string telefone2 = Convert.ToString(GridClientes.CurrentRow.Cells[6].Value.ToString());
                _objForm1?.Close();
                _objForm1 = new FormCadastroCliente(IDCLiente, nome, email, Rg, cpf, telefone, telefone2)
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
    }
}
