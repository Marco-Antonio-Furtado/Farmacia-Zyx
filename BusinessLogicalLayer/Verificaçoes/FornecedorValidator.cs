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
        private StringValidator stringValidator = new StringValidator();
        private Normatization normatization = new Normatization();
        private ClienteDAL clienteDAL = new ClienteDAL();

        public Response Validate(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder("");


            erros.Append(stringValidator.ValidateNome(fornecedor.NomeResponsavel));
            erros.Append(stringValidator.ValidateEmail(fornecedor.Email));
            erros.Append(stringValidator.ValidateTelefone(fornecedor.Telefone));
            if (!stringValidator.IsCnpj(fornecedor.CNPJ)) erros.Append("CNPJ Invalido");
            erros.Append(stringValidator.ValidateRazaoSocial(fornecedor.RazaoSocial));





            


            ////CPF do cliente deve ser único
            //if (clienteDAL.Exists(cliente.CPF).HasSuccess)
            //{
            //    erros += "CPF já cadastrado.";
            //}

            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }

            //Se chegou aqui, validamos com sucesso!
            funcionario.Nome = normatization.NormatizeName(funcionario.Nome);
            return clienteDAL.Create(fornecedor);
        }
    }
}