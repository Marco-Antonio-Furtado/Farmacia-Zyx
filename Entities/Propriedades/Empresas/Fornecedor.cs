using Entities.Propriedades;

namespace Entities
{
    public class Fornecedor : Empresa
    {
        public Fornecedor(string razaoSocial, string cNPJ, string nomeContato, string email, string telefone)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            NomeContato = nomeContato;
            Email = email;
            Telefone = telefone;
        }
        public override string ToString()
        {
            return this.RazaoSocial + "\r\n" +
                   this.CNPJ + "\r\n" +
                   this.Email + "\r\n" +
                   this.Telefone + "\r\n" +
                   this.Ativo + "\r\n" +
                   this.NomeContato + "\r\n";
        }
    }
}
