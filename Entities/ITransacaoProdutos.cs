using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Propriedades
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">Entidade</typeparam>
    /// <typeparam name="W">View model respectivo à entidade</typeparam>
    public interface ITransacaoProdutos<T,W>
    {

        public SingleResponse<T> EfetuarTransacao(T transacao);
        public DataResponse<W> LerTransacoes(DateTime inicio, DateTime fim);
        public SingleResponse<T> GetByID(int id);


    }
}
