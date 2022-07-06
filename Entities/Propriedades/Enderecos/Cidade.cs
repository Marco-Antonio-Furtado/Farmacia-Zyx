namespace Entities.Propriedades
{
    /// <summary>
    /// Classe de endereco de cidade para melhor funcionamento de busca de enderecos
    /// </summary>
    public class Cidade
    {
        public Cidade()
        {
        }

        public Cidade(string nome)
        {
            Nome_Cidade = nome;
        }
        public int ID { get; set; }
        public string Nome_Cidade { get; set; }
        public int ID_ESTADO { get; set; }
        public override string ToString()
        {
            return this.Nome_Cidade + "\r\n";
        
        }       
    }
}
