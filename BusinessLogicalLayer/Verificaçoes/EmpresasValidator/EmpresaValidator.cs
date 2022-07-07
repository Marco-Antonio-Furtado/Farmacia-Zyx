using BusinessLogicalLayer.RegrasValidacao;
using Entities.Propriedades;
using Shared;
using System.Text;

namespace BusinessLogicalLayer.Verificaçoes
{
    public class EmpresaValidator
    {
        internal static Response Validate(Empresa item)
        {
            StringBuilder erros = new("");

            if (!RegraValidacaoEmpresa.IsCnpj(item.CNPJ))
            {
                erros.Append("Cnpj invalido");
            }
            erros.Append(RegraValidacaoEmpresa.ValidateRazaoSocial(item.Razao_Social));
            erros.Append(RegraValidacaoString.ValidateNome(item.Nome_Contato));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            item.Nome_Contato = RegraNormatizacao.NormatizeName(item.Nome_Contato);
            return new Response("", true);
        }
    }
}
