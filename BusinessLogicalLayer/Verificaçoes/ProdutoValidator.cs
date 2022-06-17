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
    public class ProdutoValidator
    {
        private ClienteDAL clienteDAL = new ClienteDAL();
        private RegraValidacaoIten ItensValidator = new RegraValidacaoIten();

        public Response ValidateIten(Produto produto) 
        {
            StringBuilder erros = new StringBuilder("");


            erros.Append(ItensValidator.ValidateProdutoNome(produto.Nome));
            erros.Append(ItensValidator.ValidateDescrisaoProduto(produto.Descriscao));
            erros.Append(ItensValidator.ValidateLaboratorio(produto.Laboratorio));

            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }
            
            return new Response("daqui iriamos pro Dal",true);




        }


    }
}
