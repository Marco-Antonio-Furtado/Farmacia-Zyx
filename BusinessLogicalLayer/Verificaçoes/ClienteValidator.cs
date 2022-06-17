using DataAccessLayer;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    //Projeto (Assembly) > Namespace > classe

    public class ClienteValidator
    {
        private StringValidator stringValidator = new StringValidator();
        private Normatization normatization = new Normatization();
        private ClienteDAL clienteDAL = new ClienteDAL();

        public Response Validate(Cliente cliente)
        {

            StringBuilder erros = new StringBuilder("");
            

            erros.Append(stringValidator.ValidateNome(cliente.Nome));
            erros.Append(stringValidator.ValidateCPF(cliente.CPF));
            erros.Append(stringValidator.ValidateEmail(cliente.Email));
            erros.Append(stringValidator.ValidateTelefone(cliente.Telefone1));
            erros.Append(stringValidator.ValidateTelefone(cliente.Telefone2));
            erros.Append(stringValidator.ValidateRG(cliente.RG));




            ////CPF do cliente deve ser único
            //if (clienteDAL.Exists(cliente.CPF).HasSuccess)
            //{
            //    erros += "CPF já cadastrado.";
            //}

            if (erros.Length != 0)
            {
                return new Response(erros.ToString(), false);
            }
            cliente.Nome = normatization.NormatizeName(cliente.Nome);
            return clienteDAL.Create(cliente);

        }

    }


}