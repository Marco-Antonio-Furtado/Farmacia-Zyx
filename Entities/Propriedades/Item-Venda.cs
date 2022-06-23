using Entities.Propriedades;

namespace Entities
{
    public class Item_Venda : Transacao
    {
        public Item_Venda(DateTime data, string produto, string nomeCliente, string nomeFuncionario, string formaPagamento,int quantidade, double precoUnitario, double valorTotal)
        {
            Data = data;
            Produto = produto;
            NomeCliente = nomeCliente;
            NomeFuncionario = nomeFuncionario;
            FormaPagamento = formaPagamento;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            ValorTotal = valorTotal;
        }  
        public string NomeCliente { get; set; }
    
    }
}
