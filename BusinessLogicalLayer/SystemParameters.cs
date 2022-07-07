using Entities;
using Shared;

namespace BusinessLogicalLayer
{
    /// <summary>
    /// nesta classe se encontra o arquivo de suporte de login 
    /// apos o login a classe estatica manten informado o NOME_FUNCIONARIO que esta logado
    /// salvando desde nome,id e permissão
    /// </summary>
    public static class SystemParameters
    {
        public static Funcionario UsuarioLogado { get; private set; }

        public static void Logar(Funcionario funcionario)
        {
            UsuarioLogado = funcionario;
        }
        public static Cargo GetPermissao()
        {
            return UsuarioLogado.Cargo;
        }
        public static string GetNome()
        {
            return UsuarioLogado.Nome_Funcionario;
        } 
        public static int GetID()
            { return UsuarioLogado.ID; }
    }

}
