using DataAccessLayer;
using Entities;
using Entities.Propriedades;
using Shared;

namespace BusinessLogicalLayer.RegraDePreco
{
    public class RegraPrecoProduto
    {
        public static Response AtualizarPrecos(Entrada entrada, double taxaDeLucro)
        {
            ProdutoDal produtoDal = new ProdutoDal();
    
            try
            {
                foreach (Item item in entrada.Items)
                {
                    if (item.IDProduto.IsPrecoAlterado == true)
                    {    
                        Produto produto = produtoDal.GetByID(item.IDProduto.ID).Item;

                        double estoqueAntigo = produto.Quantia_Estoque;
                        double estoqueNovo = produto.Quantia_Estoque + item.Qtd;
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
    }
}

