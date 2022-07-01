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

namespace WfPresentationLayer.Alteraçoes
{
    public partial class FormMostrarSaidas : Form
    {
        SaidaBll saidaBll = new SaidaBll();
        private Form _objForm6;
        public FormMostrarSaidas()
        {
            InitializeComponent();
        }
        public FormMostrarSaidas(ParametrosDatas datas)
        {
            InitializeComponent();
            DataResponse<Saida> Dados = saidaBll.GetAll(datas.Inicio, datas.Fim);


            //foreach (var item in collection)
            //{

            //}



        }
        private void SincronizarListaGrid(Cliente item)
        {
            //GridClientes.Rows.Add(item.ID, item.Nome_Cliente, item.Email, item.RG, item.CPF, item.Telefone, item.Telefone2);
        }

        private void BtnCadastrarCompra_Click(object sender, EventArgs e)
        {
            FormNovaVenda form = new FormNovaVenda();
            form.ShowDialog();

            //_objForm6?.Close();
            //_objForm6 = new FormNovaVenda()
            //{
            //    TopLevel = false,
            //    FormBorderStyle = FormBorderStyle.None,
            //    Dock = DockStyle.Fill,
            //};
            //PnlVendas.Controls.Add(_objForm6);
            //_objForm6.Show();
            //_objForm6.BringToFront();
        }
    }
}
