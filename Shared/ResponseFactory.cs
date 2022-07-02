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
            return new SingleResponse<T>("Dado coletado de " + typeof(T).Name + " com sucesso", true, item);
        }
        public DataResponse<T> CreateDataSuccessResponse<T>(List<T> item)
        {
            return new DataResponse<T>("Dados coletados de " + typeof(T).Name + " com sucesso", true, item);
        }
        public Response CreateFailedResponse()
        {
            return new Response("Operação Inválida", false);
        }
        public SingleResponse<T> CreateSingleFailedResponse<T>(T item)
        {
            return new SingleResponse<T>("Impossível Pegar o dado de " + typeof(T).Name + " contate um administrador", false, item);
        }
        public DataResponse<T> CreateDataFailedResponse<T>()
        {
            return new DataResponse<T>("Impossível Pegar os dados de " + typeof(T).Name +" contate um administrador", false, null);
        }
        public Response CreateFailedUniqueEmail()
        {
            return new Response("Esse email já Está em uso", false);
        }
        public Response CreateFailedUniqueCpf()
        {
            return new Response("Cpf Já cadastrado", false);
        }
        public Response CreateFailedUniqueCnpj()
        {
            return new Response("Cnpj Já cadastrado", false);
        }
        public Response CreateFailedUniqueName()
        {
            return new Response("Nome Já cadastrado", false);
        }
        public Response CreateFailedForeignProdutoLab()
        {
            return new Response("Não é possível deletar um laboratório conectado à um produto", false);
        }
        public Response CreateFailedForeignEndereco()
        {
            return new Response("Não é possível deletar um endereco conectado à um funcionario", false);
        }
        public Response CreateFailedForeignCargo()
        {
            return new Response("Não é possível deletar um cargo conectado à um funcionario", false);
        }
        /*
        public Response CreateFailedForeignFornecedor()
        {
            return new Response("Não é possível deletar uma entrada conectada à um fornecedor", false);
        }
        public Response CreateFailedForeignFuncionario()
        {
            return new Response("Não é possível deletar uma entrada conectada à um funcionario", false);
        }
        public Response CreateFailedForeignProdutoTransaction()
        {
            return new Response("Não é possível deletar uma transação conectada à um produto", false);
        }
        public Response CreateFailedForeignEntrada()
        {
            return new Response("Não é possível deletar uma transação conectado à uma entrada", false);
        }
        public Response CreateFailedForeignSaida()
        {
            return new Response("Não é possível deletar uma transação conectado à uma saída", false);
        }
        */
    }
}
