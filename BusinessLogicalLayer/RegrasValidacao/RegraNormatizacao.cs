using System.Globalization;
using System.Text.RegularExpressions;

namespace BusinessLogicalLayer
{
    internal class RegraNormatizacao
    {
        internal string NormatizeName(string nome)
        {
            string nomeNormatizado = new CultureInfo("pt-br").TextInfo.ToTitleCase(nome);
            nomeNormatizado = nomeNormatizado.Trim();
            return Regex.Replace(nome, @"\s+", " ");
        }
    }
}
