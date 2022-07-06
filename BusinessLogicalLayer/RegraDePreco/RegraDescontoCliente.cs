using DataAccessLayer;
using Entities;

namespace BusinessLogicalLayer.RegraDePreco
{
    public class RegraDescontoCliente
    {
        ClienteDAL clienteDAL = new ClienteDAL();
        internal void DescontoCliente(Saida transacao)
        {
            Cliente cli = clienteDAL.GetByID(transacao.Cliente.ID).Item;
            if (cli.Programa_Fidelidade >= 10)
            {
                cli.Programa_Fidelidade -= 10;
                transacao.ValorTotal *= 0.9;
                
            }
            if (cli.Nome_Cliente != "CLIENTE PADRÃO")
            {
                int pontosGanhos = (int)Math.Floor(transacao.ValorTotal / 10);
                transacao.Cliente.Programa_Fidelidade += pontosGanhos;
                transacao.ValorTotal *= 0.9;
            }
        }

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
