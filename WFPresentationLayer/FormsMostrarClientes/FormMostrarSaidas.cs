﻿using BusinessLogicalLayer.BusinessLL;
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
    }
}
