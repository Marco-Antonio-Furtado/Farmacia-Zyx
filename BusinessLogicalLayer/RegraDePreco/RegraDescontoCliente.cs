using DataAccessLayer;
using Entities;

namespace BusinessLogicalLayer.RegraDePreco
{
    /// <summary>
    /// classe que controla os descontos dados pelo cliente
    /// </summary>
    public class RegraDescontoCliente
    {
        ClienteDAL clienteDAL = new();
        /// <summary>
        /// metodo que gera o desconto do cliente procurar o cliente pelo id e gerando a nova quantidade de ponto nova do cliente
        /// </summary>
        /// <param name="transacao"></param>
        internal void DescontoCliente(Saida transacao)
        {
            Cliente cli = clienteDAL.GetByID(transacao.Cliente.ID).Item;
            if (cli.Programa_Fidelidade >= 10)
            {
                transacao.Cliente.Programa_Fidelidade = cli.Programa_Fidelidade -= 10;
                transacao.ValorTotal *= 0.9;
                
            }
            if (cli.Nome_Cliente != "CLIENTE PADRÃO")
            {
                int pontosGanhos = (int)Math.Floor(transacao.ValorTotal / 10);
                transacao.Cliente.Programa_Fidelidade = cli.Programa_Fidelidade += pontosGanhos;
                
            }
        }
        /// <summary>
        /// Metodo para checar o desconto do cliente para melhor visualizacao na tela
        /// </summary>
        /// <param name="transacao"></param>
        /// <returns></returns>
        public bool ChecarDesconto(Saida transacao)
        {
            Cliente cli = clienteDAL.GetByID(transacao.Cliente.ID).Item;
            if(cli.Programa_Fidelidade >= 10 && cli.Nome_Cliente != "CLIENTE PADRÃO")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
