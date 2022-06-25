namespace Entities.Propriedades
{
    public class Cidade
    {
        public Cidade(string nome)
        {
            Nome = nome;
        }
        public int ID { get; set; }
        public string Nome { get; set; }
        public int ID_ESTADO { get; set; }
        public override string ToString()
        {
            return this.Nome + "\r\n";
        
        }       
    }
}
