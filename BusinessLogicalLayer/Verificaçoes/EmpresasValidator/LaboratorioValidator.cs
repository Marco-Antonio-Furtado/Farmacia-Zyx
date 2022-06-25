using Entities;
using Entities.Propriedades;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Verificaçoes
{
    public class LaboratorioValidator
    {
        internal static Response Validate(Laboratorio item)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(RegraValidacaoString.ValidateEmail(item.Email));
            erros.Append(RegraValidacaoString.ValidateTelefone(item.Telefone));
            erros.Append(EmpresaValidator.Validate(item));

            if (!String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}
