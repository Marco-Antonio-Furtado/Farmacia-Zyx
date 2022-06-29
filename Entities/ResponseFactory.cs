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

        public  Response CreateSuccessResponse()
        {
            return new Response("Operação realizada com sucesso.", true);
        }
        public  SingleResponse<T> CreateSingleSuccessResponse<T>(T item)
        {
            return new SingleResponse<T>("Dado Coletado de " + typeof(T) + " com sucesso", true, item);
        }
        public DataResponse<T> CreateDataSuccessResponse<T>(List<T> item)
        {
            return new DataResponse<T>("Dados Coletados de " + typeof(T) + " com sucesso", true, item);
        }
        public Response CreateFailedResponse()
        {
            return new Response("Operacao Invalida", false);
        }
        public SingleResponse<T> CreateSingleFailedResponse<T>(T item)
        {
            return new SingleResponse<T>("Impossivel Pegar O dado de " + typeof(T) + " contate administrador", false, item);
        }
        public DataResponse<T> CreateDataFailedResponse<T>()
        {
            return new DataResponse<T>("Impossivel Pegar Os dados de " + typeof(T) +"contate administrador", false, null);
        }
        public Response CreateFailedUniqueEmail()
        {
            return new Response("Email Esta em uso", false);
        }
        public Response CreateFailedUniqueCpf()
        {
            return new Response("Cpf Ja cadastrado", false);
        }
        public Response CreateFailedUniqueCnpj()
        {
            return new Response("Cnpj Ja cadastrado", false);
        }
        public Response CreateFailedUniqueName()
        {
            return new Response("Nome Ja cadastrado", false);
        }


    }
}
