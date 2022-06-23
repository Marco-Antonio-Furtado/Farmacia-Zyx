namespace BusinessLogicalLayer.Verificaçoes
{
    internal class RegraValidacaoIten
    {

        internal string ValidateProdutoNome(string nome)
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
        internal string ValidateDescrisaoProduto(string descrisao)
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
        internal string ValidateLaboratorio(string laboratorio)
        {
            if (String.IsNullOrWhiteSpace(laboratorio))
            {
                return "laboratorio nao informado\r\n";
            }
            if(laboratorio.Length <= 2)
            {
                return "laboratorio insuficiente\r\n";
            }
            return "";

        }


    }
}

