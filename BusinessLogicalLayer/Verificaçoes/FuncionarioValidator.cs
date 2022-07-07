using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    /// <summary>
    /// Nesta classe eu valido o NOME_FUNCIONARIO para ver se ele esta em condicoes de entrar no banco ou ser alterado
    /// chamando os metodos da validacao de string e de endereco
    /// onde instancio um string builder e encho ele com as especificacoes que o NOME_FUNCIONARIO pede
    /// </summary>
    internal class FuncionarioValidator
    {
        internal static Response Validate(Funcionario funcionario)
        {
            StringBuilder erros = new("");

            erros.Append(RegraValidacaoString.ValidateNome(funcionario.Nome_Funcionario));
            erros.Append(RegraValidacaoString.ValidateCPF(funcionario.CPF));
            erros.Append(RegraValidacaoString.ValidateEmail(funcionario.Email));
            erros.Append(RegraValidacaoString.ValidateTelefone(funcionario.Telefone));
            erros.Append(RegraValidacaoString.ValidateRG(funcionario.RG));

            erros.Append(EnderecoValitor.Validate(funcionario.Endereco).Message);

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            funcionario.Nome_Funcionario = RegraNormatizacao.NormatizeName(funcionario.Nome_Funcionario);
            return new Response("Daqui esta indo pro banco", true);
            
        }
    }
}
