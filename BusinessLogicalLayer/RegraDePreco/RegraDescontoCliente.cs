using DataAccessLayer;
using Entities;

namespace BusinessLogicalLayer.RegraDePreco
{
    internal class RegraDescontoCliente
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

            if (cli.Nome_Cliente != "CLIENTE_PADRAO")
            {
                int pontosGanhos = (int)Math.Floor(transacao.ValorTotal / 10);
                transacao.Cliente.Programa_Fidelidade += pontosGanhos;
            }

        }
    }
}
