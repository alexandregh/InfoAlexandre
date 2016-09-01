using System;
using System.Text;
using System.Security.Cryptography;

namespace InfoAlexandre.Security.CriptographyPasswords
{
    public class CriptographyPassword
    {
        #region Implementação Métodos Segurança

        public static string CriptografarSenha(string senha)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            byte[] hashSha256 = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
            return BitConverter.ToString(hashSha256).Replace("-", "");
        }

        #endregion
    }
}