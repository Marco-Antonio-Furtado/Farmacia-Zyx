namespace Entities
{
    public class Fornecedor
    {
        public Fornecedor(string razaoSocial, string cNPJ, string nomeResponsavel, string email, string telefone = "99999999999")
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            NomeResponsavel = nomeResponsavel;
            Email = email;
            Telefone = telefone;
            
        }

        public int ID { get; set; }
        public bool Ativo { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string NomeResponsavel { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
