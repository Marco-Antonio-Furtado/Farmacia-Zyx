using System.Security.Cryptography;
using System.Text;


namespace DataAccessLayer
{
    /// <summary>
    /// classe padrao de hash de senha 
    /// </summary>
    public static class HashSenha
    {
        public static string ComputeSha256Hash(string senha)
        {

            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Adicionando "sal" à senha para mais segurança ao hashear
                senha = "jd82b!*¨$aAOI23" + senha + "lLiD4¬?2";
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
