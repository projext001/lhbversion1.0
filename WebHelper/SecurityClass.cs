using System;
using System.Web;

namespace WebHelper
{
    public class SecurityClass
    {
        string key = "jfkgotmyvhspcandxlrwebquiz";
        public string Encrypt(string plainText)
        {
            char[] chars = new char[plainText.ToLower().Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                if (plainText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = plainText[i] - 97;
                    chars[i] = key[j];
                }
            }

            return new string(chars);
        }
        public string Decrypt(string cipherText)
        {
            char[] chars = new char[cipherText.ToLower().Length];

            for (int i = 0; i < cipherText.Length; i++)
            {
                if (cipherText[i] == ' ')
                {
                    chars[i] = ' ';
                }
                else
                {
                    int j = key.IndexOf(cipherText[i]) - 97;
                    chars[i] = (char)j;
                }
            }

            return new string(chars);
        }
    }
}
