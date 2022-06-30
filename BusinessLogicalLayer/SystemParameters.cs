using Entities;
using Entities.enums;
using Shared;

namespace BusinessLogicalLayer
{
    public static class SystemParameters
    {
        public static Funcionario UsuarioLogado { get; private set; }

        public static void Logar(Funcionario funcionario)
        {
            UsuarioLogado = funcionario;
        }

        public static void LogOff()
        {
            UsuarioLogado = null;
        }

        public static bool IsUserLoggedIn()
        {
            return UsuarioLogado != null;
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
