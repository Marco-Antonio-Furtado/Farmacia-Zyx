using BusinessLogicalLayer.RegraDePreco;
using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{

    /// <summary>
    /// Meio para ligar o banco de dados de Produtos com a tela 
    /// e fazendo sua regras de negocios onde no caso de Produtos Sao validacoes
    /// e as taxas de lucro de compra e venda
    /// </summary>
    public class ProdutoBll : ICRUD<Produto>
    {
        
        readonly ProdutoDal produtoDAL = new();
        public Response Insert(Produto item)
        {
            RegraPrecoProduto.TaxaLucroPadrao(item);
            Response resposta = ProdutoValidator.ValidateIten(item);
            if (resposta.HasSuccess)
            {
                return produtoDAL.Insert(item);
            }
            else { return resposta; }
        }
        public Response Update(Produto item)
        {
            RegraPrecoProduto.TaxaLucroPadrao(item);
            Response resposta = ProdutoValidator.ValidateIten(item);
            if (resposta.HasSuccess)
            {
               return produtoDAL.Update(item);
            }
            else { return resposta; }
        }
        public Response Delete(int id)
        {
            return produtoDAL.Delete(id);
        }
        public DataResponse<Produto> GetAll()
        {
            return produtoDAL.GetAll();
        }
        public SingleResponse<Produto> GetByID(int id)
        {
            return produtoDAL.GetByID(id);
        }
        public Response Disable(int iDCLiente)
        {
            return produtoDAL.Disable(iDCLiente);
        }
    }
}
