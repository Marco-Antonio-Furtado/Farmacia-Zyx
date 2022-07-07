using BusinessLogicalLayer.BusinessLL;
using BusinessLogicalLayer.RegraDePreco;
using DataAccessLayer;
using Entities;
using Entities.Propriedades;
using Shared;

namespace BusinessLogicalLayer.RegraEstoque
{
    /// <summary>
    /// Nesta classe temos o controle de estoque tanto de entrada como de saida
    /// </summary>
    internal class RegraControleEstoque
    {
        /// <summary>
        /// Aqui a regra de controle de estoque para entradas 
        /// </summary>
        /// <param name="Entradas"></param>
        /// <returns></returns>
        public static Response EstoqueEntrada(Entrada Entradas)
        {
            ProdutoDal produtoDal = new();
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
        /// <summary>
        /// aqui a regra de controle de estoque de saida
        /// </summary>
        /// <param name="transacao"></param>
        /// <returns></returns>
        public static Response EstoqueSaida(Saida transacao)
        {
            RegraDescontoCliente descontoCliente = new();
            ProdutoBll produtoBll = new();
            ProdutoDal produtoDal = new();
            SaidaDAL saidaDAL = new();

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
