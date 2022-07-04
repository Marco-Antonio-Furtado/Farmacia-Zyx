using BusinessLogicalLayer.RegraDePreco;
using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class ProdutoBll : ICRUD<Produto>
    {
        //
        readonly ProdutoDal produtoDAL = new ProdutoDal();

        public Response Insert(Produto item)
        {
            //Produtos novos possuem uma margem automática de lucro de 20%
            item.Valor_Venda = item.Valor_Unitario * 1.2;
            Response resposta = ProdutoValidator.ValidateIten(item);
            if (resposta.HasSuccess)
            {
                return produtoDAL.Insert(item);
            }
            else { return resposta; }
        }

        public Response Update(Produto item)
        {
            //CHECA ISSO AQUI!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //double ValorVenda = RegraPrecoProduto.CalcularNovoPreco(item, 20);
            //item.Valor_Venda = ValorVenda;
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
        public Response Estoque(int a,int qtd)
        {
            return produtoDAL.SetEstoque(qtd ,a);
        }
    }
}
