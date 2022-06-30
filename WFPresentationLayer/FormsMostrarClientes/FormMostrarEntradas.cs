using BusinessLogicalLayer.BusinessLL;
using Entities;
using Shared;

namespace WfPresentationLayer.Alteraçoes
{
    public partial class FormMostrarEntradas : Form
    {
        EntradaBll entradaBll = new EntradaBll();
        public FormMostrarEntradas()
        {
            InitializeComponent();
        }
        public FormMostrarEntradas(ParametrosDatas Datas)
        {
            InitializeComponent();
            DataResponse<Entrada> data = entradaBll.GetAll(Datas.Inicio,Datas.Fim);
        }

        private void FormMostrarEntradas_Load(object sender, EventArgs e)
        {
            
        }


        private void SincronizarListaGrid(Cliente item)
        {
            //GridClientes.Rows.Add(item.ID, item.Nome_Cliente, item.Email, item.RG, item.CPF, item.Telefone, item.Telefone2);
        }
    }
}
