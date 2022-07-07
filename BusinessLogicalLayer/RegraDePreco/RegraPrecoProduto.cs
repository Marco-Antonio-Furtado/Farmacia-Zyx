using DataAccessLayer;
using Entities;
using Entities.Propriedades;
using Shared;

namespace BusinessLogicalLayer.RegraDePreco
{
    /// <summary>
    /// classe que atualiza o preco do produto assim que acontece a entrada de produto
    /// e tambem quando acontece o cadastro do produto
    /// </summary>
    public class RegraPrecoProduto
    {
        /// <summary>
        /// metodo que atualiza o preco na hora da entrada
        /// </summary>
        /// <param name="entrada"></param>
        /// <param name="taxaDeLucro"></param>
        /// <returns></returns>
        public static Response AtualizarPrecos(Entrada entrada, double taxaDeLucro)
        {
            try
            {
               ProdutoDal produtoDal = new();
                foreach (Item item in entrada.Items)
                {
                    if (item.IDProduto.IsPrecoAlterado == true)
                    {    
                        Produto produto = produtoDal.GetByID(item.IDProduto.ID).Item;

                        double estoqueAntigo = produto.Quantia_Estoque;
                        double estoqueNovo = item.Qtd;
                        double precoAntigo = produto.Valor_Unitario;
                        double precoNovo = item.Preco;

                        double precoBase = ((precoAntigo * estoqueAntigo) + (precoNovo * estoqueNovo)) / (estoqueNovo + estoqueAntigo);
                        double precoAtualizado = Math.Ceiling(precoBase * (1 + taxaDeLucro/100));

                        produto.Valor_Unitario = Math.Floor(precoBase);
                        produto.Valor_Venda = precoAtualizado;
                        produtoDal.Update(produto);
                    }
                }
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch(Exception ex)
            {
                return ResponseFactory.CreateInstance().CreateFailedResponse();
            }
        }

        /// <summary>
        /// Pega o antigo estoque do produto em caso da alteracao e joga na formula para gerar um novo preco
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static Response TaxaLucroPadrao(Produto item)
        {
            double taxaDeLucro = 20;
            ProdutoDal produtoDal = new();

            item.Valor_Venda = item.Valor_Unitario;
            item.Valor_Venda *= (1 + taxaDeLucro / 100);

            return ResponseFactory.CreateInstance().CreateSuccessResponse();
        }
    }
}

