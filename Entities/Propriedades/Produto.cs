namespace Entities
{
    public class Produto
    {
        public Produto(string nome, string descricao, Laboratorio lab,double valorunitario)
        {
            Nome = nome;
            Descricao = descricao;
            Laboratorio = lab;
            ValorUnitario = valorunitario;
            
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public int QuantiaEstoque { get; set; }
        public bool Ativo { get; set; }

    }
}
