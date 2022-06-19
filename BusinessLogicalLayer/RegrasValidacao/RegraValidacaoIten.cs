using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class RegraValidacaoIten
    {

        internal string ValidateProdutoNome(string nome)
        {
            if (String.IsNullOrWhiteSpace(nome))
            {
                return "string nao pode ser vazia";
            }
            
            if (nome.Length <= 2)
            {
                return "nome insuficiente";
            }
            return "";

        }
        internal string ValidateDescrisaoProduto(string descrisao)
        {
            if (String.IsNullOrWhiteSpace(descrisao))
            {
                return "descrisao nao informada";
            }
            if (descrisao.Length <= 2)
            {
                return "descrisao insuficiente";
            }
            return "";

        }
        internal string ValidateLaboratorio(string laboratorio)
        {
            if (String.IsNullOrWhiteSpace(laboratorio))
            {
                return "laboratorio nao informado";
            }
            if(laboratorio.Length <= 2)
            {
                return "laboratorio insuficiente";
            }
            return "";

        }


    }
}

