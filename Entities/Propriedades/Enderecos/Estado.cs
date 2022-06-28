namespace Entities
{
    public class Estado
    {
        public Estado()
        {
        }

        public Estado(string nome, string uF)
        {
            Nome_Estado = nome;
            UF = uF;
        }

        public int ID { get; set; }
        public string Nome_Estado { get; set; }
        public string UF { get; set; }

        public override string ToString()
        {
            return this.Nome_Estado + "\r\n" +
                   this.UF + "\r\n";
        }


    }
}
