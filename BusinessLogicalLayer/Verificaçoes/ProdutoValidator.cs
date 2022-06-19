using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class ProdutoValidator
    {
        private RegraValidacaoIten ItensValidator = new RegraValidacaoIten();

        internal Response ValidateIten(Produto produto) 
        {
            StringBuilder erros = new StringBuilder("");
            

            erros.Append(ItensValidator.ValidateProdutoNome(produto.Nome) + "\r\n");
            erros.Append(ItensValidator.ValidateDescrisaoProduto(produto.Descriscao) + "\r\n");
            erros.Append(ItensValidator.ValidateLaboratorio(produto.Laboratorio) + "\r\n");

            if (erros.ToString() != "\r\n\r\n\r\n")
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
