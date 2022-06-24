using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class ResponseFactory
    {
        #region Singleton
        private static ResponseFactory _factory;

        public static ResponseFactory CreateInstance()
        {
            if (_factory == null)
            {
                _factory = new ResponseFactory();
            }
            return _factory;
        }

        private ResponseFactory() { }
        #endregion Singleton

        public Response CreateSuccessResponse()
        {
            return new Response("Operação realizada com sucesso.", true);
        }


        public SingleResponse<T> CreateSingleSuccessResponse<T>(T item)
        {
            return new SingleResponse<T>("Operação realizada com sucesso.", true, item);
        }


    }

}
