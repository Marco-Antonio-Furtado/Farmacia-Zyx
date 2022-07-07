using BusinessLogicalLayer.Verificaçoes;
using Entities;
using Shared;
using DataAccessLayer;

namespace BusinessLogicalLayer.BusinessLL
{
    /// <summary>
    /// Meio para ligar o banco de dados de Fornecedores com a tela 
    /// e fazendo sua regras de negocios onde no caso de Fornecedor Sao validacoes
    /// </summary>
    public class FornecedorBll : ICRUD<Fornecedor>
    {
        FornecedorDAL fornecedorDAL = new();
        public Response Insert(Fornecedor item)
        {
            Response resposta = FornecedorValidator.Validate(item);
            if (resposta.HasSuccess)
            {
                return fornecedorDAL.Insert(item);
            }
            else { return resposta; }
        }
        public Response Update(Fornecedor item)
        {
            Response Resposta = FornecedorValidator.Validate(item);
            if (Resposta.HasSuccess)
            {
                return fornecedorDAL.Update(item);
            }
            else { return Resposta; }
        }
        public Response Delete(int id)
        {
            return fornecedorDAL.Delete(id);
        }

        public DataResponse<Fornecedor> GetAll()
        {
            return fornecedorDAL.GetAll();
        }

        public SingleResponse<Fornecedor> GetByID(int id)
        {
            return fornecedorDAL.GetByID(id);
        }
        public Response Disable(int iDCLiente)
        {
            return fornecedorDAL.Disable(iDCLiente);
        }
    }
}
