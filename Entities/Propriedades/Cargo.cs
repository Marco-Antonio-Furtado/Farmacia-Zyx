namespace Shared
{
    public class Cargo
    {
        public Cargo()
        {
        }

        public Cargo(int iD, string nome)
        {
            ID = iD;
            Nome = nome;
        }

        public int ID { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return this.Nome + "\r\n";
                 
        }





    }
}
