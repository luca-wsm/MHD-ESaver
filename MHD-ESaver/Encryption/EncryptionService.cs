using System;
using System.IO;
using System.Security.Cryptography;

namespace MHD_ESaver.Encryption
{
    public class EncryptionService
    {
        /// <summary>
        /// Encrypts the databse file with a hardcoded aes key and iv.
        /// Uses aes 256 bit and a random generated key
        /// </summary>
        public void Encrypt()
        {
            using (var fsInput = new FileStream(SQLConstants.DATABASE_FILE, FileMode.Open))
            {
                using (var fsOutput = new FileStream(SQLConstants.DATABASE_FILE_ENCRYPTED, FileMode.Create))
                {
                    using (var aes = new AesManaged())
                    {
                        aes.KeySize = 256;
                        aes.Key = Convert.FromBase64String(EncryptionConstants.ENCRYPTION_KEY);
                        aes.IV = Convert.FromBase64String(EncryptionConstants.ENCRYPTION_IV);
                        var encryptor = aes.CreateEncryptor();
                        using (CryptoStream cs = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                        {
                            fsInput.CopyTo(cs);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Decrypts the databse file with a hardcoded aes key and iv.
        /// Uses aes 256 bit and a random generated key
        /// </summary>
        public void Decrypt()
        {
            using (var fsInput = new FileStream(SQLConstants.DATABASE_FILE_ENCRYPTED, FileMode.Open))
            {
                using (var fsOutput = new FileStream(SQLConstants.DATABASE_FILE, FileMode.Create))
                {
                    using (var aes = new AesManaged())
                    {
                        aes.Key = Convert.FromBase64String(EncryptionConstants.ENCRYPTION_KEY);
                        aes.IV = Convert.FromBase64String(EncryptionConstants.ENCRYPTION_IV);
                        ICryptoTransform decryptor = aes.CreateDecryptor();
                        using (CryptoStream cs = new CryptoStream(fsOutput, decryptor, CryptoStreamMode.Write))
                        {
                            fsInput.CopyTo(cs);
                        }
                    }
                }
            }
        }
    }
}
