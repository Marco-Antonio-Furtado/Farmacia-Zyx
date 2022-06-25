using BusinessLogicalLayer.RegrasValidacao;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class FuncionarioValidator
    {
        internal Response Validate(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(RegraValidacaoString.ValidateNome(funcionario.Nome));
            erros.Append(RegraValidacaoString.ValidateCPF(funcionario.CPF));
            erros.Append(RegraValidacaoString.ValidateEmail(funcionario.Email));
            erros.Append(RegraValidacaoString.ValidateTelefone(funcionario.Telefone));
            erros.Append(RegraValidacaoString.ValidateRG(funcionario.RG));

            erros.Append(EnderecoValitor.Validate(funcionario.Endereco).Message);
            



            ////CPF do cliente deve ser único
            //if (clienteDAL.Exists(cliente.CPF).HasSuccess)
            //{
            //    erros += "CPF já cadastrado.";

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }

            funcionario.Nome = RegraNormatizacao.NormatizeName(funcionario.Nome);
            return new Response("Daqui esta indo pro banco", true);
            
        }
    }
}
