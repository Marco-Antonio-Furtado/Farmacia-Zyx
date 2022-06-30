using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Propriedades
{
    public interface IEntradaProdutos
    {
        public interface IEntradaProdutos
        {
            public Response EfetuarEntrada(Entrada entrada);
            public DataResponse<Entrada> LerEntradas(DateTime inicio, DateTime fim);
            public SingleResponse<Entrada> GetByID(int id);
        }
    }
}
