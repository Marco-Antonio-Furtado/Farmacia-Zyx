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
            StringBuilder erros = new StringBuilder("");

            if (!RegraValidacaoEmpresa.IsCnpj(item.CNPJ))
            {
                erros.Append("Cnpj invalido");
            }
            erros.Append(RegraValidacaoEmpresa.ValidateRazaoSocial(item.RazaoSocial));
            erros.Append(RegraValidacaoString.ValidateNome(item.NomeContato));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            item.NomeContato = RegraNormatizacao.NormatizeName(item.NomeContato);
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}
