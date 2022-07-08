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
        /// Deve ser chamado numa entrada de produtos já cadastrados para atualizar seus preços baseado em quanto foi pago pela quantidade de itens novos no estoque 
        /// </summary>
        /// <param name="entrada"></param>
        /// <param name="taxaDeLucro">Taxa de lucro desejada em numeros inteiros (20,40, 70...)</param>
        /// <returns></returns>
        public static Response AtualizarPrecosEntrada(Entrada entrada, double taxaDeLucro)
        {
            try
            {
               ProdutoDal produtoDal = new();
                foreach (Item item in entrada.Items)
                {
                    //se o preço do produto foi alterado no form, ele irá entrar nesse if e sofrerá as alterações necessárias no preço
                    if (item.IDProduto.IsPrecoAlterado == true)
                    {   
                        //adiquirindo todas as informações necessárias do produto no banco de dados
                        Produto produto = produtoDal.GetByID(item.IDProduto.ID).Item;
                        
                        //esses são os dados antes da atualização, por isso "estoqueAntigo" e "precoAntigo" estão ligados ao "produto"
                        //enquanto "item" carrega os dados que o usuário deseja atualizar                       
                        double estoqueAntigo = produto.Quantia_Estoque;
                        double estoqueNovo = item.Qtd;
                        double precoAntigo = produto.Valor_Unitario;
                        double precoNovo = item.Preco;

                        //fórmula para calcular o preço mínimo de venda para não sofrer perdas
                        double precoBase = ((precoAntigo * estoqueAntigo) + (precoNovo * estoqueNovo)) / (estoqueNovo + estoqueAntigo);
                        double precoAtualizado = Math.Ceiling(precoBase * (1 + taxaDeLucro/100));

                        produto.Valor_Unitario = Math.Floor(precoBase);
                        produto.Valor_Venda = precoAtualizado;
                        produtoDal.Update(produto);
                    }
                }
                return ResponseFactory.CreateInstance().CreateSuccessResponse();
            }
            catch (Exception)
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

            item.Valor_Unitario = Math.Floor(item.Valor_Unitario);
            item.Valor_Venda = Math.Ceiling(item.Valor_Unitario * (1 + taxaDeLucro / 100));

            return ResponseFactory.CreateInstance().CreateSuccessResponse();
        }
    }
}

