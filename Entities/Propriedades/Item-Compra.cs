using Entities.Propriedades;

namespace Entities
{
    public class Item_Compra : Transacao
    {
        //Laboratorio

        public Item_Compra(DateTime data, string produto,string fornecedor, string nomeFuncionario, string formaPagamento, int quantidade, double precoUnitario, double valorTotal)
        {
            Data = data;
            Produto = produto;
            Fornecedor = fornecedor;
            NomeFuncionario = nomeFuncionario;
            FormaPagamento = formaPagamento;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            ValorTotal = valorTotal;
        }
    }
}
