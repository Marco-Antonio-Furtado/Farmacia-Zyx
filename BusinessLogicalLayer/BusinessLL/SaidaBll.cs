using DataAccessLayer;
using Entities;
using Entities.viewmodel;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class SaidaBll
    {
        SaidaDAL saidaDAL = new SaidaDAL();
        ClienteDAL clienteDAL = new ClienteDAL();
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
               
                bool discountFlag = false;
                Cliente cli = clienteDAL.GetByID(transacao.Cliente.ID).Item;
                if(cli.Programa_Fidelidade >= 10)
                {
                    cli.Programa_Fidelidade -= 10;
                    transacao.ValorTotal *= 0.9;
                    discountFlag = true;
                }

                if(!discountFlag)
                {
                int pontosGanhos = (int)Math.Floor(transacao.ValorTotal/10);
                transacao.Cliente.Programa_Fidelidade += pontosGanhos;
                }

            return saidaDAL.EfetuarTransacao(transacao);

        }
        public DataResponse<SaidaViewModel> GetAll(DateTime inicio, DateTime fim)
        {
            return saidaDAL.LerTransacoes(inicio,fim);
        }
        public SingleResponse<Saida> GetByID(int id)
        {
            return saidaDAL.GetByID(id);
        }

    }
}
