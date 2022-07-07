using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    /// <summary>
    /// Nesta classe eu valido o Fornecedor para ver se ele esta em condicoes de entrar no banco ou ser alterado
    /// chamando os metodos da validacao de string e de Empresa
    /// onde instancio um string builder e encho ele com as especificacoes que o Fornecedor pede
    /// </summary>
    internal class FornecedorValidator
    {
        internal static Response Validate(Fornecedor fornecedor)
        {
            StringBuilder erros = new("");

            erros.Append(RegraValidacaoString.ValidateEmail(fornecedor.Email));
            erros.Append(RegraValidacaoString.ValidateTelefone(fornecedor.Telefone));
            erros.Append(EmpresaValidator.Validate(fornecedor).Message);

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Verificacao feita", true);
        }
    }
}