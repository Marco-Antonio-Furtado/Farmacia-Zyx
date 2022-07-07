using BusinessLogicalLayer.RegraDePreco;
using BusinessLogicalLayer.RegraEstoque;
using DataAccessLayer;
using Entities;
using Entities.viewmodel;
using Shared;

namespace BusinessLogicalLayer.BusinessLL
{
    /// <summary>
    /// Meio para ligar o banco de dados Das Saidas dos produtos com a tela
    /// e fazendo sua regras de negocios onde no caso de das saidas das vendas sao
    /// as regras de estoque e regras de fidelidade do cliente
    /// </summary>
    public class SaidaBll
    {
        SaidaDAL saidaDAL = new();

   
        public Response Insert(Saida transacao)
        {
           return RegraControleEstoque.EstoqueSaida(transacao);

        }
        public DataResponse<SaidaViewModel> LerTransacoes(DateTime inicio, DateTime fim)
        {
            return saidaDAL.LerTransacoes(inicio,fim);
        }
        public DataResponse<SaidaViewModel> GetAll()
        {
            return saidaDAL.GetAll();
        }
    }
}
