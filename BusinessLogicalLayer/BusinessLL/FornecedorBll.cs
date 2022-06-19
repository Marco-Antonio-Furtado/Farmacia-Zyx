﻿using BusinessLogicalLayer.Verificaçoes;
using Entities;
using Shared;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.BusinessLL
{
    public class FornecedorBll : ICRUD<Fornecedor>
    {
        FornecedorDAL fornecedorDAL = new FornecedorDAL();
        public Response Insert(Fornecedor item)
        {
            FornecedorValidator fornecedorValidate = new FornecedorValidator();
            Response resposta = fornecedorValidate.Validate(item);
            if (resposta.HasSuccess)
            {
                return fornecedorDAL.Insert(item);
            }
            return resposta;
        }

        public Response Update(Fornecedor item)
        {
            throw new NotImplementedException();
        }
        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Fornecedor> GetAll()
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Fornecedor> GetByID(int id)
        {
            throw new NotImplementedException();
        }
        public SingleResponse<Fornecedor> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
