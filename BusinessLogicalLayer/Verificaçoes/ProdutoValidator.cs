﻿using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class ProdutoValidator
    {
        private RegraValidacaoIten ItensValidator = new RegraValidacaoIten();

        internal Response ValidateIten(Produto produto) 
        {
            StringBuilder erros = new StringBuilder("");
            

            erros.Append(ItensValidator.ValidateProdutoNome(produto.Nome));
            erros.Append(ItensValidator.ValidateDescrisaoProduto(produto.Descriscao));
            erros.Append(ItensValidator.ValidateLaboratorio(produto.Laboratorio));

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
