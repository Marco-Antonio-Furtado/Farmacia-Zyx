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
    public class FornecedorValidator
    {
        private RegraValidacaoString stringValidator = new RegraValidacaoString();
        private RegraNormatizacao normatization = new RegraNormatizacao();
        private ClienteDAL clienteDAL = new ClienteDAL();

        public Response Validate(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder("");

            erros.Append(stringValidator.ValidateNome(fornecedor.NomeResponsavel));
            erros.Append(stringValidator.ValidateEmail(fornecedor.Email));
            erros.Append(stringValidator.ValidateTelefone(fornecedor.Telefone));
            if (!stringValidator.IsCnpj(fornecedor.CNPJ)) erros.Append("CNPJ Invalido");
            erros.Append(stringValidator.ValidateRazaoSocial(fornecedor.RazaoSocial));

            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }

            //Se chegou aqui, validamos com sucesso!
            fornecedor.NomeResponsavel = normatization.NormatizeName(fornecedor.NomeResponsavel);
            // tem que ser fornecedorDAL ao invés de clienteDAL
            //return clienteDAL.Insert(fornecedor);
            return new Response("", true);
        }
    }
}