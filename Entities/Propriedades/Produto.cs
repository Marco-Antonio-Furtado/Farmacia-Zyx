namespace Entities
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string nome, string descricao,double valorunitario)
        {
            Nome = nome;
            Descricao = descricao;
            ValorUnitario = valorunitario;
            
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorVenda { get; set; }
        public Laboratorio Laboratorio { get; set; }
        public int QuantiaEstoque { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return this.Nome + "\r\n" +
                   this.Descricao + "\r\n" +
                   this.ValorUnitario + "\r\n" +
                   this.Laboratorio.RazaoSocial.ToString()+ "\r\n" +
                   this.QuantiaEstoque + "\r\n" +
                   this.Ativo.ToString();


        }





    }
}
