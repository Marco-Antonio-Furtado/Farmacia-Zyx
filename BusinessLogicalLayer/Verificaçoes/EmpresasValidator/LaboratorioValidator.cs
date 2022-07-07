using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{

    /// <summary>
    /// Nesta classe eu valido o Laboratorio para ver se ele esta em condicoes de entrar no banco ou ser alterado
    /// chamando os metodos da validacao de string e de Empresa
    /// onde instancio um string builder e encho ele com as especificacoes que o Laboratorio pede
    /// </summary>
    public class LaboratorioValidator
    {
        internal static Response Validate(Laboratorio item)
        {
            StringBuilder erros = new("");

            erros.Append(RegraValidacaoString.ValidateEmail(item.Email));
            erros.Append(RegraValidacaoString.ValidateTelefone(item.Telefone));
            erros.Append(EmpresaValidator.Validate(item).Message);

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}
