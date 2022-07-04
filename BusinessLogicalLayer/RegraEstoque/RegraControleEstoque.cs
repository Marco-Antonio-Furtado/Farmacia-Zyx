using BusinessLogicalLayer.BusinessLL;
using BusinessLogicalLayer.RegraDePreco;
using DataAccessLayer;
using Entities;
using Entities.Propriedades;
using Shared;

namespace BusinessLogicalLayer.RegraEstoque
{
    internal class RegraControleEstoque
    {
        public static Response EstoqueEntrada(Entrada Entradas)
        {
            ProdutoDal produtoDal = new ProdutoDal();

            try
            {
                foreach (Item item in Entradas.Items)
                {
                    Produto produto = produtoDal.GetByIDEstoque(item.IDProduto.ID).Item;
                    double Quantiavelha = produto.Quantia_Estoque;
                    double QuantiaNova = item.Qtd + Quantiavelha;
                    produtoDal.SetEstoque(QuantiaNova, item.IDProduto.ID);
                }
                return new Response("Estoque atualizado com sucesso", true);

            }
            catch (Exception ex)
            {
                return new Response("Não foi possível atualizar o estoque" + ex.Message, false);
            }

        }

        public static Response EstoqueSaida(Saida transacao)
        {
            RegraDescontoCliente descontoCliente = new RegraDescontoCliente();
            ProdutoBll produtoBll = new ProdutoBll();
            ProdutoDal produtoDal = new ProdutoDal();
            SaidaDAL saidaDAL = new SaidaDAL();

            foreach (var item in transacao.Items)
            {

                SingleResponse<Produto> response = produtoBll.GetByID(item.IDProduto.ID);
                if (response.HasSuccess)
                {
                    if (response.Item.Quantia_Estoque < item.Qtd)
                    {
                        return new SingleResponse<Saida>("Itens insuficientes em estoque", false, null);
                    }
                    else
                    {
                        double quantiaNova = response.Item.Quantia_Estoque -= item.Qtd;
                        produtoDal.SetEstoque(quantiaNova, item.IDProduto.ID);

                    }
                }
            }
            descontoCliente.DescontoCliente(transacao);

            return saidaDAL.EfetuarTransacao(transacao);
        }


    }
}
