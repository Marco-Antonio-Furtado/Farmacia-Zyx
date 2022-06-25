namespace Entities
{
    public class Produto
    {
        public Produto(string nome, string descricao, Laboratorio lab,double valorunitario)
        {
            Nome = nome;
            Descricao = descricao;
            IDLaboratorio = lab;
            ValorUnitario = valorunitario;
            
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }
        public Laboratorio IDLaboratorio { get; set; }
        public int QuantiaEstoque { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return this.Nome + "\r\n" +
                   this.Descricao + "\r\n" +
                   this.ValorUnitario + "\r\n" +
                   this.IDLaboratorio.ToString()+ "\r\n" +
                   this.QuantiaEstoque + "\r\n" +
                   this.Ativo.ToString();


        }





    }
}
