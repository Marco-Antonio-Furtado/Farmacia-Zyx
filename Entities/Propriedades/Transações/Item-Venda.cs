using Entities.Propriedades;

namespace Entities
{
    public class Item_Venda : Transacao
    {
        public Item_Venda(DateTime data, string produto, string nomeCliente, string nomeFuncionario, string formaPagamento,int quantidade, double precoUnitario, double valorTotal)
        {
            Data = data;
            IDProduto = produto;
            IDNomeCliente = nomeCliente;
            IDNomeFuncionario = nomeFuncionario;
            FormaPagamento = formaPagamento;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            ValorTotal = valorTotal;
        }  
        public string IDNomeCliente { get; set; }

        public override string ToString()
        {
            return this.IDProduto + "\r\n" +
                   this.IDFornecedor + "\r\n" +
                   this.PrecoUnitario + "\r\n" +
                   this.Quantidade + "\r\n" +
                   this.ValorTotal + "\r\n" +
                   this.FormaPagamento + "\r\n" +
                   this.IDNomeFuncionario + "\r\n" +
                   this.Data + "\r\n" +
                   this.IDNomeCliente;
        }
    }
}
