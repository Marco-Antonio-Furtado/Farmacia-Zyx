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
    internal class FuncionarioValidator
    {
        private RegraValidacaoString stringValidator = new RegraValidacaoString();
        private RegraNormatizacao normatization = new RegraNormatizacao();

        public Response Validate(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder("");


            erros.Append(stringValidator.ValidateNome(funcionario.Nome) + "\r\n");
            erros.Append(stringValidator.ValidateCPF(funcionario.CPF) + "\r\n");
            erros.Append(stringValidator.ValidateEmail(funcionario.Email) + "\r\n");
            erros.Append(stringValidator.ValidateTelefone(funcionario.Telefone1) + "\r\n");
            erros.Append(stringValidator.ValidateRG(funcionario.RG) + "\r\n");
            erros.Append(stringValidator.ValidateCEP(funcionario.Endereco?.CEP));


            ////CPF do cliente deve ser único
            //if (clienteDAL.Exists(cliente.CPF).HasSuccess)
            //{
            //    erros += "CPF já cadastrado.";
            //}

            
            if (String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }

            //Se chegou aqui, validamos com sucesso!
            funcionario.Nome = normatization.NormatizeName(funcionario.Nome);
            //return clienteDAL.Create(funcionario);
            return new Response("Daqui esta indo pro banco", true);
            
        }
    }
}
