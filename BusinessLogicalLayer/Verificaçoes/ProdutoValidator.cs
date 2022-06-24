using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class ProdutoValidator
    {
        internal static Response ValidateIten(Produto produto) 
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(RegraValidacaoIten.ValidateProdutoNome(produto.Nome));
            erros.Append(RegraValidacaoIten.ValidateDescrisaoProduto(produto.Descriscao));
            erros.Append(RegraValidacaoIten.ValidateLaboratorio(produto.Laboratorio));

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
