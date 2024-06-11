using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PasswordEncryptor
{
    public class PasswordManager
    {
   
        

        public static string Encrypt(string plaintext, int shift)
        {
            string encryptedText = "";
            foreach (char c in plaintext)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    encryptedText += (char)(((c + shift - offset) % 26) + offset);
                }
                else
                {
                    encryptedText += c; // Non-letter characters are unchanged
                }
            }
            return encryptedText;
        }
        public static string Decrypt(string ciphertext, int shift)
        {
            return Encrypt(ciphertext, 26 - shift); // Decryption is just encryption with 26 - shift
        }



    }
}
