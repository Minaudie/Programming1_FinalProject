using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;
using System.Security.Cryptography;

namespace FinalProject
{
    public static class Utilities
    {
        public static byte[] mySalt;
        public static string SaltKey = "";
        public static Boolean isLoggedIn = false;
        public static string MyUsername = "";
        public static int pwdTries = 0;

        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

            byte[] data = new byte[1];

            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                mySalt = data;
                crypto.GetNonZeroBytes(data);
            }

            StringBuilder result = new StringBuilder(maxSize);

            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        public static byte[] Get_SALT()
        {
            int saltLengthLimit = 32;
            return Get_SALT(saltLengthLimit);
        }

        public static byte[] Get_SALT(int maxSaltLength)
        {
            var salt = new byte[maxSaltLength];

            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }

            SaltKey = Convert.ToBase64String(salt);
            return salt;
        }

        public static string Get_HASH_SHA512(string password, byte[] salt)
        {
            try
            {
                //plain text in byte
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(password);

                //plain text + salt key in byte
                byte[] plainTextWithSaltBytes = new byte[plainTextBytes.Length + salt.Length];

                for (int i = 0; i < plainTextBytes.Length; i++)
                {
                    plainTextWithSaltBytes[i] = plainTextBytes[i];
                }

                for (int i = 0; i < salt.Length; i++)
                {
                    plainTextWithSaltBytes[plainTextBytes.Length + i] = salt[i];
                }

                HashAlgorithm hash = new SHA512Managed();
                byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);
                byte[] hashWithSaltBytes = new byte[hashBytes.Length + salt.Length];

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashWithSaltBytes[i] = hashBytes[i];
                }

                for (int i = 0; i < salt.Length; i++)
                {
                    hashWithSaltBytes[hashBytes.Length + i] = salt[i];
                }

                return Convert.ToBase64String(hashWithSaltBytes);

            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        //returns salt
        public static byte[] returnSaltBytes(string salt)
        {
            byte[] saltDecode = Convert.FromBase64String(salt);
            return saltDecode;
        }

        //return comparison
        public static string Return_HASH_SHA512(string password, byte[] mysalt)
        {
            try
            {
                //plain text in byte
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(password);

                //plain text + salt key in byte
                byte[] plainTextWithSaltBytes = new byte[plainTextBytes.Length + mysalt.Length];

                for (int i = 0; i < plainTextBytes.Length; i++)
                {
                    plainTextWithSaltBytes[i] = plainTextBytes[i];
                }

                for (int i = 0; i < mysalt.Length; i++)
                {
                    plainTextWithSaltBytes[plainTextBytes.Length + i] = mysalt[i];
                }

                HashAlgorithm hash = new SHA512Managed();
                byte[] hashBytes = hash.ComputeHash(plainTextWithSaltBytes);
                byte[] hashWithSaltBytes = new byte[hashBytes.Length + mysalt.Length];

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashWithSaltBytes[i] = hashBytes[i];
                }

                for (int i = 0; i < mysalt.Length; i++)
                {
                    hashWithSaltBytes[hashBytes.Length + i] = mysalt[i];
                }

                return Convert.ToBase64String(hashWithSaltBytes);

            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public static string Encrypt(string clearText)
        {
            try
            {

                byte[] hashBytes = ComputeHash(clearText);

                byte[] saltBytes = GetRandomSalt();
                SaltKey = Convert.ToBase64String(saltBytes);

                byte[] saltHash = ComputeHash(saltBytes.ToString());
                byte[] hashWithSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashWithSaltBytes[i] = hashBytes[i];
                }

                for (int i = 0; i < saltBytes.Length; i++)
                {
                    hashWithSaltBytes[hashBytes.Length + i] = saltBytes[i];
                }

                string hashValue = Convert.ToBase64String(hashWithSaltBytes);

                return hashValue;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static byte[] GetRandomSalt()
        {
            int minSaltSize = 16;
            int maxSaltSize = 32;

            Random random = new Random();
            int saltSize = random.Next(minSaltSize, maxSaltSize);

            byte[] saltBytes = new byte[saltSize];

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetNonZeroBytes(saltBytes);

            return saltBytes;
        }

        public static byte[] ComputeHash(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            HashAlgorithm hash = new SHA256Managed();
            return hash.ComputeHash(plainTextBytes);
        }
    }
}
