using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class SaidaBll
    {
        SaidaDAL saidaDAL = new SaidaDAL();
        ProdutoBll produtoBll = new ProdutoBll();
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
            return saidaDAL.EfetuarTransacao(transacao);

        }
        public DataResponse<Saida> GetAll(DateTime inicio, DateTime fim)
        {
            return saidaDAL.LerTransacoes(inicio,fim);
        }
        public SingleResponse<Saida> GetByID(int id)
        {
            return saidaDAL.GetByID(id);
        }

    }
}
