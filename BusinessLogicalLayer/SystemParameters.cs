using Entities;
using Entities.enums;

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

        public static Hierarquia GetPermissao()
        {
            return UsuarioLogado.PosicaoHierarquica;
        }
    }

}
