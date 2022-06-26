namespace Entities
{
    public class Produto
    {
        public Produto()
        {
        }

        public Produto(string nome, string descricao, int laboratorio,double valorunitario)
        {
            Nome = nome;
            Descricao = descricao;
            ID_Laboratorio = laboratorio;
            Valor_Unitario = valorunitario;
            
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor_Unitario { get; set; }
        public int ID_Laboratorio { get; set; }
        public int Quantia_Estoque { get; set; }
        public double Valor_Venda { get; set; }
        public bool Ativo { get; set; }

        public override string ToString()
        {
            return this.Nome + "\r\n" +
                   this.Descricao + "\r\n" +
                   this.Valor_Unitario + "\r\n" +
                   this.ID_Laboratorio.ToString()+ "\r\n" +
                   this.Quantia_Estoque + "\r\n" +
                   this.Ativo.ToString();


        }





    }
}
