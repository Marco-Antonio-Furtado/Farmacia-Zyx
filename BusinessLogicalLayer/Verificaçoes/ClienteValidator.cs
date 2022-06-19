﻿using DataAccessLayer;
using Entities;
using Shared;
using System.Text;

namespace BusinessLogicalLayer
{
    internal class ClienteValidator
    {
        private RegraValidacaoString stringValidator = new RegraValidacaoString();
        private RegraNormatizacao normatization = new RegraNormatizacao();
        
        public Response Validate(Cliente cliente)
        {

            StringBuilder erros = new StringBuilder("");

            
            erros.Append(stringValidator.ValidateNome(cliente.Nome) + "\r\n");
            erros.Append(stringValidator.ValidateCPF(cliente.CPF) + "\r\n");
            erros.Append(stringValidator.ValidateEmail(cliente.Email) + "\r\n");
            erros.Append(stringValidator.ValidateTelefone(cliente.Telefone1) + "\r\n");
            erros.Append(stringValidator.ValidateTelefone(cliente.Telefone2) + "\r\n");
            erros.Append(stringValidator.ValidateRG(cliente.RG) + "\r\n");

            if (String.IsNullOrWhiteSpace(erros.ToString()))
            {
                return new Response(erros.ToString(), false);
            }
            cliente.Nome = normatization.NormatizeName(cliente.Nome);
            return new Response("Daqui esta indo pro banco", true);
        }
    }
}