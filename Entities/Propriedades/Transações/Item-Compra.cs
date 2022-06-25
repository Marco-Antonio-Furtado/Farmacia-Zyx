using Entities.Propriedades;

namespace Entities
{
    public class Item_Compra : Transacao
    {
        //Laboratorio

        public Item_Compra(DateTime data, string produto,string fornecedor, string nomeFuncionario, string formaPagamento, int quantidade, double precoUnitario, double valorTotal)
        {
            Data = data;
            IDProduto = produto;
            IDFornecedor = fornecedor;
            IDNomeFuncionario = nomeFuncionario;
            FormaPagamento = formaPagamento;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            ValorTotal = valorTotal;
        }
        public override string ToString()
        {
            return this.IDProduto + "\r\n" +
                   this.IDFornecedor + "\r\n" +
                   this.PrecoUnitario + "\r\n" +
                   this.Quantidade + "\r\n" +
                   this.ValorTotal + "\r\n" +
                   this.FormaPagamento + "\r\n" +
                   this.IDNomeFuncionario + "\r\n" +
                   this.Data + "\r\n";


        }





    }
}
