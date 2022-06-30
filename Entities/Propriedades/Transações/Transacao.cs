namespace Entities.Propriedades
{
    public abstract class Transacao
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public int IDNomeFuncionario { get; set; }
        public double ValorTotal { get; set; }
        public List<Items> Items { get; set; }

        public Transacao()
        {
            this.Items = new List<Items>();
        }
    }

    public class Items
    {
        public int IDProduto { get; set; }
        public double Preco { get; set; }
        public Double Qtd { get; set; }
    }
}
