using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    /// <summary>
    /// Nesta classe eu valido o produto para ver se ele esta em condicoes de entrar no banco ou ser alterado
    /// chamando os metodos da validacao de iten
    /// onde instancio um string builder e encho ele com as especificacoes que o iten pede
    /// </summary>
    internal class ProdutoValidator
    {
        internal static Response ValidateIten(Produto produto) 
        {
            StringBuilder erros = new("");

            erros.Append(RegraValidacaoIten.ValidateProdutoNome(produto.Nome));
            erros.Append(RegraValidacaoIten.ValidateDescrisaoProduto(produto.Descricao));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            else
            {
                return new Response("Daqui esta indo pro banco", true);
            }
        }
    }
}
