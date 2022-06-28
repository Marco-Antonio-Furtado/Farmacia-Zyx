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
        public static SingleResponse<Produto> CalcularPrecoBase(Produto item)
        {
            //No Doc nao ta falando sobre Preco mais fiz uma base aqui 
            if (item.Valor_Unitario < 10)
            {
                item.Valor_Venda = item.Valor_Unitario * 2.5;
            }
            else if (item.Valor_Unitario < 20)
            {
                item.Valor_Venda = item.Valor_Unitario * 2.1;
            }
            else if (item.Valor_Unitario < 30)
            {
                item.Valor_Venda = item.Valor_Unitario * 2.0;
            }
            else if (item.Valor_Unitario < 40)
            {
                item.Valor_Venda = item.Valor_Unitario * 1.8;
            }
            else if (item.Valor_Unitario < 50)
            {
                item.Valor_Venda = item.Valor_Unitario * 1.7;           
            }
            else
            {
                item.Valor_Venda = item.Valor_Unitario * 1.6;
            }
            return new SingleResponse<Produto> ("Operacao Bem Realizada", true, item);
        }
    }
}
