namespace Entities.Propriedades.Pessoas
{

    /// <summary>
    /// Classe de pessoa geral para depois ser a classe pai de outras classes
    /// </summary>
    public class Pessoa
    {
        public int ID { get; set; }
        
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }

    }
}
