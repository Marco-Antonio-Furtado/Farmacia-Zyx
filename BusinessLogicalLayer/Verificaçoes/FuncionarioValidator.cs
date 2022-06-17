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
    public class FuncionarioValidator
    {
        private RegraValidacaoString stringValidator = new RegraValidacaoString();
        private RegraNormatizacao normatization = new RegraNormatizacao();
        private ClienteDAL clienteDAL = new ClienteDAL();

        public Response Validate(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder("");


            erros.Append(stringValidator.ValidateNome(funcionario.Nome));
            erros.Append(stringValidator.ValidateCPF(funcionario.CPF));
            erros.Append(stringValidator.ValidateEmail(funcionario.Email));
            erros.Append(stringValidator.ValidateTelefone(funcionario.Telefone1));
            erros.Append(stringValidator.ValidateRG(funcionario.RG));



            erros.Append(stringValidator.ValidateCEP(funcionario.Endereco?.CEP));


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
            //return clienteDAL.Create(funcionario);
            return new Response("", false);
            
        }
    }
}
