using DataAccessLayer;
using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Verificaçoes
{
    internal class FornecedorValidator
    {
        private RegraValidacaoString stringValidator = new RegraValidacaoString();
        private RegraNormatizacao normatization = new RegraNormatizacao();

        public Response Validate(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(stringValidator.ValidateNome(fornecedor.NomeResponsavel) + "\r\n");
            erros.Append(stringValidator.ValidateEmail(fornecedor.Email) + "\r\n");
            erros.Append(stringValidator.ValidateTelefone(fornecedor.Telefone) + "\r\n");
            if (!stringValidator.IsCnpj(fornecedor.CNPJ)) erros.Append("CNPJ Invalido" + "\r\n");
            erros.Append(stringValidator.ValidateRazaoSocial(fornecedor.RazaoSocial) + "\r\n");

            if (String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }

            //Se chegou aqui, validamos com sucesso!
            fornecedor.NomeResponsavel = normatization.NormatizeName(fornecedor.NomeResponsavel);
            // tem que ser fornecedorDAL ao invés de clienteDAL
            //return clienteDAL.Insert(fornecedor);
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}