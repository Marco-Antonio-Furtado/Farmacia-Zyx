using BusinessLogicalLayer.BusinessLL;
using DataAccessLayer;
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

namespace WfPresentationLayer.FormsMostrarClientes
{
    public partial class FormMostarLaboratorio : Form
    {
        Form _objForm5;
        LaboratorioBLL laboratorioBLL = new LaboratorioBLL();
        public FormMostarLaboratorio()
        {
            InitializeComponent();
        }
        List<Laboratorio> Laboratorios = new List<Laboratorio>();
        private void BtnCadastrarlaboratorio_Click(object sender, EventArgs e)
        {
            _objForm5?.Close();
            _objForm5 = new FormCadastrarLaboratorio
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            PNLLaboratorio.Controls.Add(_objForm5);
            _objForm5.Show();
            _objForm5.BringToFront();
        }

        private void FormMostarLaboratorio_Load(object sender, EventArgs e)
        {
            Laboratorios = laboratorioBLL.GetAll().Dados;
            foreach (Laboratorio laboratorio in Laboratorios)
            {
                if (laboratorio.Ativo == true)
                {
                    SincronizarListaGrid(laboratorio);
                }
            }
        }
        private void SincronizarListaGrid(Laboratorio item)
        {
            GridLaboratorio.Rows.Add(item.ID, item.Razao_Social, item.Telefone, item.Nome_Contato, item.Email, item.CNPJ);
        }

        private void BtnAlterarLaboratorio_Click(object sender, EventArgs e)
        {
          DataGridViewRow row = this.GridLaboratorio.SelectedRows[0];
          if (GridLaboratorio.CurrentRow.Cells[0].Value == null)
          {
              MeuMessageBox.Show("Voce nao selecionou nenhuma coluna");
          }
          else
          {
              int IDLab = Convert.ToInt32(GridLaboratorio.CurrentRow.Cells[0].Value.ToString());
              string razao = Convert.ToString(GridLaboratorio.CurrentRow.Cells[1].Value.ToString());
              string telefone = Convert.ToString(GridLaboratorio.CurrentRow.Cells[2].Value.ToString());
              string nomeRes = Convert.ToString(GridLaboratorio.CurrentRow.Cells[3].Value.ToString());
              string email = Convert.ToString(GridLaboratorio.CurrentRow.Cells[4].Value.ToString());
              string cnpj = Convert.ToString(GridLaboratorio.CurrentRow.Cells[5].Value.ToString());

                _objForm5?.Close();
              _objForm5 = new FormCadastrarLaboratorio(IDLab, razao, email, telefone, cnpj, nomeRes)
              {
                  TopLevel = false,
                  FormBorderStyle = FormBorderStyle.None,
                  Dock = DockStyle.Fill,
              };
                PNLLaboratorio.Controls.Add(_objForm5);
                _objForm5.Show();
                _objForm5.BringToFront();
            }
            

        }

        private void BtnDeletarLaboratorio_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.GridLaboratorio.SelectedRows[0];
            int IDCLiente = Convert.ToInt32(GridLaboratorio.CurrentRow.Cells[0].Value.ToString());
            string nome = Convert.ToString(GridLaboratorio.CurrentRow.Cells[1].Value.ToString());

            DialogResult r = MeuMessageBox.Show("Deseja Apagar o Laboratorio" + nome + " Da tabela Ou do banco " + "\r\n" + "X Para Voltar", "Escolha", "Deletar Do banco", "deletar da tabela");
            if (r == DialogResult.Yes)
            {
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja deletar o Laboratorio " + nome, " Tem Certeza?", "Sim", "Nao");
                if (re == DialogResult.Yes)
                {
                    Response resposta = laboratorioBLL.Delete(IDCLiente);
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
                DialogResult re = MeuMessageBox.Show("Tem Certeza que deseja Apagar o Laboratorio " + nome, " Tem Certeza?", "Sim", "Nao");
                if (re == DialogResult.Yes)
                {
                    Response resposta = laboratorioBLL.Disable(IDCLiente);
                    if (resposta.HasSuccess)
                    {
                        MeuMessageBox.Show(resposta.Message, "Deu Certo", "OK");
                    }
                    else MeuMessageBox.Show(resposta.Message);
                }
                else { }
            }
        }

        private void BtnDesabilitados_Click(object sender, EventArgs e)
        {
            LimparGrid();
            List<Laboratorio> LaboratoriosOFF = laboratorioBLL.GetAll().Dados;
            foreach (Laboratorio laboratorio in LaboratoriosOFF)
            {
                if (laboratorio.Ativo == false)
                {
                    SincronizarListaGrid(laboratorio);
                }
            }
            if (GridLaboratorio.RowCount == 1)
            {
                MeuMessageBox.Show("Nao a Laboratorios Desabilitados");
                LimparGrid();
            }

        }
        private void LimparGrid()
        {
            GridLaboratorio.Rows.Clear();
            GridLaboratorio.Refresh();
            GridLaboratorio.DataSource = null;
        }
    }
}
