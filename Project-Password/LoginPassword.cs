using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Project_Password
{
    public class LoginPassword
    {
        public int Id { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public LoginPassword(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
            decrypt = null;
        }

        public override string ToString()
        {
            string decrypted = Decrypt();
            StringBuilder passBuilder = new StringBuilder();
            for (int i = 0; i < decrypted.Length; i++)
            {
                passBuilder.Append('*');
            }
            return passBuilder.ToString();
        }

        private string decrypt;

        public string Decrypt()
        {
            if (decrypt == null)
            {
                decrypt = DecryptString(Password, Login);
            }
            return decrypt;
        }

        private static string DecryptString(string cipherText, string keyString)
        {
            var fullCipher = Convert.FromBase64String(cipherText);

            var iv = new byte[16];
            var cipher = new byte[fullCipher.Length - iv.Length];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, fullCipher.Length - iv.Length);

            var key = new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(keyString));

            using (var aesAlg = Aes.Create())
            {
                using (var decryptor = aesAlg.CreateDecryptor(key, iv))
                {
                    string result;
                    using (var msDecrypt = new MemoryStream(cipher))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                result = srDecrypt.ReadToEnd();
                            }
                        }
                    }

                    return result;
                }
            }
        }
    }
}

