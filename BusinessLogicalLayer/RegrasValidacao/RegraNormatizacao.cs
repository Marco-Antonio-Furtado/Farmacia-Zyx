using System.Globalization;
using System.Text.RegularExpressions;

namespace BusinessLogicalLayer
{
    /// <summary>
    /// nesta classe Contem a globalizacao padrao para brasileiro
    /// </summary>
    internal class RegraNormatizacao
    {
        internal static string NormatizeName(string nome)
        {
            string NomePadrao = new CultureInfo("pt-br").TextInfo.ToTitleCase(nome);
            NomePadrao = NomePadrao.Trim();
            return Regex.Replace(nome, @"\s+", " ");
        }
    }
}
