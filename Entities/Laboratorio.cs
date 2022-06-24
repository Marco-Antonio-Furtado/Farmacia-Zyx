namespace Entities
{
    public class Laboratorio
    {
        public Laboratorio(int iD, string nome, string cNPJ)
        {
            ID = iD;
            Nome = nome;
            CNPJ = cNPJ;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
    }
}
