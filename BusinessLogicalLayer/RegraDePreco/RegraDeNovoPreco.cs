using DataAccessLayer;
using Entities;
using Entities.Propriedades;
using Shared;

namespace BusinessLogicalLayer.RegraDePreco
{
    internal class RegraDeNovoPreco
    {
        ProdutoDal produtoDal = new ProdutoDal();
        internal SingleResponse<Entrada> RefaturarPreco(Entrada Entradas)
        {
            foreach (Item item in Entradas.Items)
            {
                if (item.IDProduto.IsPrecoAlterado == true)
                {
                    Produto produto = produtoDal.GetByID(item.IDProduto.ID).Item;

                    double estoqueNovo = produto.Quantia_Estoque + item.Qtd;
                    double PrecoNovo = (produto.Valor_Unitario * produto.Quantia_Estoque) + ((item.Preco * item.Qtd) / (estoqueNovo + produto.Quantia_Estoque));
                    item.Preco = RegraPrecoProduto.CalcularPrecoBase(PrecoNovo);
                }
            }
            return ResponseFactory.CreateInstance().CreateSingleSuccessResponse(Entradas);
        }
        ///BOA SORTE MARCO BOA SORTE MARCO BOA SORTE MARCO BOA SORTE MARCO BOA SORTE MARCO BOA SORTE MARCO BOA SORTE MARCO BOA SORTE MARCO 
        ///

        //((precoAntigo* estoqueAntigo) + (precoNovo* estoqueNovo)) / (estoqueNovo+estoqueAntigo)
        //esse é o preço mínimo, em cima disso vc tem que botar uma margem de lucro, de preferencia, sempre maior que 10%, se não quando o cliente usar o desconto dele, a gente n tem lucro nenhum

    }
}
