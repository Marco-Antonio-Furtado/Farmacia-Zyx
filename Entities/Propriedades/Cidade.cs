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
    }
}
