namespace Entities
{
    public class Estado
    {
        public Estado(string nome, string uF)
        {
            Nome = nome;
            UF = uF;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }

        public override string ToString()
        {
            return this.Nome + "\r\n" +
                   this.UF + "\r\n";
        }


    }
}
