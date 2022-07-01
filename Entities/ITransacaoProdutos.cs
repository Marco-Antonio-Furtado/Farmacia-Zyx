using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Propriedades
{
    public interface ITransacaoProdutos<T>
    {

        public SingleResponse<T> EfetuarTransacao(T transacao);
        public DataResponse<T> LerTransacoes(DateTime inicio, DateTime fim);
        public SingleResponse<T> GetByID(int id);

    }
}
