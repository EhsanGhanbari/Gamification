using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Gamification.Shared
{
    public static class Cryptography
    {
        public static string Hash(string plainText)
        {
            var algorithm = HashAlgorithm.Create(CryptographyConstants.HashAlgorithm);
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            var hashedBytes = algorithm.ComputeHash(plainBytes);

            return BitConverter.ToString(hashedBytes).Replace("-", string.Empty);
        }

        public static string Encrypt(string plainText)
        {
            var cipher = EncryptText(plainText);
            return ByteArrayToString(cipher);
        }

        public static string Decrypt(string encryptedText)
        {
            var cipher = StringToByteArray(encryptedText);
            return DecryptText(cipher);
        }

        private static byte[] EncryptText(string text)
        {
            var encoder = new UTF8Encoding();
            var bytes = encoder.GetBytes(text);

            using (var memoryStream = new MemoryStream())
            {
                using (var rijndaelManaged = new RijndaelManaged())
                {
                    using (var encryptorTransform = rijndaelManaged.CreateEncryptor(CryptographyConstants.Key, CryptographyConstants.Vector))
                    {
                        using (var cs = new CryptoStream(memoryStream, encryptorTransform, CryptoStreamMode.Write))
                        {
                            cs.Write(bytes, 0, bytes.Length);
                            cs.FlushFinalBlock();

                            memoryStream.Position = 0;
                            var encrypted = new byte[memoryStream.Length];
                            memoryStream.Read(encrypted, 0, encrypted.Length);

                            return encrypted;
                        }
                    }
                }
            }
        }

        private static string DecryptText(byte[] encryptedText)
        {
            using (var encryptedStream = new MemoryStream())
            {
                using (var rijndaelManaged = new RijndaelManaged())
                {
                    using (var decryptorTransform = rijndaelManaged.CreateDecryptor(CryptographyConstants.Key, CryptographyConstants.Vector))
                    {
                        using (var decryptStream = new CryptoStream(encryptedStream, decryptorTransform, CryptoStreamMode.Write))
                        {
                            decryptStream.Write(encryptedText, 0, encryptedText.Length);
                            decryptStream.FlushFinalBlock();

                            encryptedStream.Position = 0;
                            var decryptedBytes = new byte[encryptedStream.Length];
                            encryptedStream.Read(decryptedBytes, 0, decryptedBytes.Length);

                            var encoder = new UTF8Encoding();
                            return encoder.GetString(decryptedBytes);
                        }
                    }
                }
            }
        }

        private static byte[] StringToByteArray(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("value");
            }

            var i = 0;
            var j = 0;
            var buffer = new byte[value.Length / 3];

            do
            {
                var val = byte.Parse(value.Substring(i, 3));
                buffer[j++] = val;
                i += 3;
            }
            while (i < value.Length);

            return buffer;
        }

        private static string ByteArrayToString(byte[] byteArray)
        {
            var temp = string.Empty;

            for (var i = 0; i <= byteArray.GetUpperBound(0); i++)
            {
                temp += byteArray[i].ToString(CultureInfo.InvariantCulture).PadLeft(3, '0');
            }

            return temp;
        }
    }

    internal static class CryptographyConstants
    {
        public static readonly string HashAlgorithm = "SHA1";
        public static readonly byte[] Key = { 123, 217, 19, 11, 24, 26, 85, 45, 114, 184, 27, 162, 37, 112, 222, 209, 241, 24, 175, 144, 173, 53, 196, 29, 24, 26, 17, 218, 131, 236, 53, 209 };
        public static readonly byte[] Vector = { 146, 64, 191, 111, 23, 3, 113, 119, 231, 121, 251, 112, 79, 32, 114, 156 };
    }
}
