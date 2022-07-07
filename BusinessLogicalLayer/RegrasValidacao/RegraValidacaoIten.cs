namespace BusinessLogicalLayer.Verificaçoes
{
    /// <summary>
    /// Classe criada para validar itens/produtos para melhor organizacao do sistema
    /// </summary>
    internal class RegraValidacaoIten
    {
        /// <summary>
        /// Validador de nome de produto
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        internal static string ValidateProdutoNome(string nome)
        {
            if (String.IsNullOrWhiteSpace(nome))
            {
                return "string nao pode ser vazia\r\n";
            }

            if (nome.Length <= 2)
            {
                return "nome insuficiente\r\n";
            }
            return "";
        }
        /// <summary>
        /// validador de descrisao de produto
        /// </summary>
        /// <param name="descrisao"></param>
        /// <returns></returns>
        internal static string ValidateDescrisaoProduto(string descrisao)
        {
            if (String.IsNullOrWhiteSpace(descrisao))
            {
                return "descrisao nao informada\r\n";
            }
            if (descrisao.Length <= 2)
            {
                return "descrisao insuficiente\r\n";
            }
            return "";
        }
    }
}

