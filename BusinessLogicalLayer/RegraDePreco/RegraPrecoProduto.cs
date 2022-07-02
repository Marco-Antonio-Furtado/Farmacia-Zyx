using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.RegraDePreco
{
    public class RegraPrecoProduto
    {
        public static double CalcularPrecoBase(double precoantigo)
        {
            double preconovo = 0;
            //No Doc nao ta falando sobre Preco mais fiz uma base aqui 
            if (precoantigo < 10)
            {
                preconovo = precoantigo * 2.5;
            }
            else if (precoantigo < 20)
            {
                preconovo = precoantigo * 2.1;
            }
            else if (precoantigo < 30)
            {
                preconovo = precoantigo * 2.0;
            }
            else if (precoantigo < 40)
            {
                preconovo = precoantigo * 1.8;
            }
            else if (precoantigo < 50)
            {
                preconovo = precoantigo * 1.7;           
            }
            else
            {
                preconovo = precoantigo * 1.6;
            }
            return preconovo;
        }
    }
}
