﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Verificaçoes
{
    public class ProdutoValidator
    {

        public string ValidateProdutoNome(string nome)
        {
            if (String.IsNullOrWhiteSpace(nome))
            {
                return "string nao pode ser vazia";
            }
            //exemplo de xy usa dois caracteres
            if (nome.Length <= 2)
            {
                return "nome insuficiente";
            }
            return "";

        }
        public string ValidateDescrisaoProduto(string descrisao)
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
        public string ValidateLaboratorio(string laboratorio)
        {
            if (!String.IsNullOrWhiteSpace(laboratorio))
            {
                return "laboratorio nao informado";
            }
            return "";

        }


    }
}
}
