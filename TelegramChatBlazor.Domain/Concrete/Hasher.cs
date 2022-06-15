using System.Security.Cryptography;
using TelegramChatBlazor.Domain.Abstract.Services;

namespace TelegramChatBlazor.Domain.Concrete
{
    public class Hasher : IHasher
    {
        const int Iterations = 1000;
        const int SaltSize = 16;
        const int HashSize = 32;

        public string GetHash(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            byte[] salt = new byte[SaltSize];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            try
            {
                //create hash
                var hashBytes = new byte[SaltSize + HashSize];

                using (var rfc = new Rfc2898DeriveBytes(str, salt, Iterations))
                {
                    var hash = rfc.GetBytes(HashSize);
                    Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                    Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);
                }

                return Convert.ToBase64String(hashBytes);
            }
            catch
            {
                return null;
            }
        }

        public bool Сompare(string hashedStr, string str)
        {
            if (string.IsNullOrEmpty(hashedStr) || string.IsNullOrEmpty(str))
                return false;

            try
            {
                var hashBytes = Convert.FromBase64String(hashedStr);
                var salt = new byte[SaltSize];
                Array.Copy(hashBytes, 0, salt, 0, SaltSize);

                byte[] hash;
                using (var rfc = new Rfc2898DeriveBytes(str, salt, Iterations))
                {
                    hash = rfc.GetBytes(HashSize);
                }

                for (var i = 0; i < HashSize; i++)
                {
                    if (hashBytes[i + SaltSize] != hash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}