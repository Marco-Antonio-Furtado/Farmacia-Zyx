using BusinessLogicalLayer.RegraDePreco;
using DataAccessLayer;
using Entities;
using Entities.viewmodel;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class SaidaBll
    {
        SaidaDAL saidaDAL = new SaidaDAL();
        ProdutoBll produtoBll = new ProdutoBll();
        RegraDescontoCliente descontoCliente = new RegraDescontoCliente();
        public Response Insert(Saida transacao)
        {
            foreach (var item in transacao.Items)
            {

                SingleResponse<Produto> response = produtoBll.GetByID(item.IDProduto.ID);
                if (response.HasSuccess)
                {
                    if (response.Item.Quantia_Estoque < item.Qtd)
                    {
                        return new SingleResponse<Saida>("Itens insuficientes em estoque", false, null);
                    }
                }
            }
            descontoCliente.DescontoCliente(transacao);

            return saidaDAL.EfetuarTransacao(transacao);

        }
        public DataResponse<SaidaViewModel> LerTransacoes(DateTime inicio, DateTime fim)
        {
            return saidaDAL.LerTransacoes(inicio,fim);
        }
        public DataResponse<SaidaViewModel> GetAll()
        {
            return saidaDAL.GetAll();
        }
        public SingleResponse<Saida> GetByID(int id)
        {
            return saidaDAL.GetByID(id);
        }

    }
}
