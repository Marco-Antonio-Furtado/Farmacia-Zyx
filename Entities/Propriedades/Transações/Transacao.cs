namespace Entities.Propriedades
{
    public abstract class Transacao
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public Funcionario IDFuncionario { get; set; }
        public double ValorTotal { get; set; }
        public List<Item> Items { get; set; }
        public string Forma_Pagamento { get; set; }
        public Transacao()
        {
            this.Items = new List<Item>();
        }
    }

    public class Item
    {
        public int Entrada_ID { get; set; }
        public Produto IDProduto { get; set; }
        public double Preco { get; set; }
        public double Qtd { get; set; }
    }
}
