namespace Entities.Propriedades
{
    /// <summary>
    /// Classe base para servir de classe pai para as duas empresas cadastradas no sistema
    /// </summary>
    public class Empresa
    {
        public int ID { get; set; }
        public bool Ativo { get; set; }
        public string Razao_Social { get; set; }
        public string CNPJ { get; set; }
        public string Nome_Contato { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
