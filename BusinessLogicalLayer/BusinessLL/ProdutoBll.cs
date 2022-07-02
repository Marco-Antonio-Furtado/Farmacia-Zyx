﻿using BusinessLogicalLayer.RegraDePreco;
using BusinessLogicalLayer.Verificaçoes;
using DataAccessLayer;
using Entities;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    public class ProdutoBll : ICRUD<Produto>
    {
        readonly ProdutoDal produtoDAL = new ProdutoDal();
        public Response Insert(Produto item)
        {
            double ValorVenda = RegraPrecoProduto.CalcularPrecoBase(item.Valor_Unitario);
            item.Valor_Venda = ValorVenda;
            Response resposta = ProdutoValidator.ValidateIten(item);
            if (resposta.HasSuccess)
            {
                return produtoDAL.Insert(item);
            }
            else { return resposta; }
        }

        public Response Update(Produto item)
        {
            double ValorVenda = RegraPrecoProduto.CalcularPrecoBase(item.Valor_Unitario);
            item.Valor_Venda = ValorVenda;
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
