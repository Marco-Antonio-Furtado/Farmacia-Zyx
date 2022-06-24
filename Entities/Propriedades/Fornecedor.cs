namespace Entities
{
    public class Fornecedor
    {
        public Fornecedor(string razaoSocial, string cNPJ, string nomeContato, string email, string telefone = "99999999999")
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            NomeContato = nomeContato;
            Email = email;
            Telefone = telefone;
            
        }

        public int ID { get; set; }
        public bool Ativo { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string NomeContato { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
