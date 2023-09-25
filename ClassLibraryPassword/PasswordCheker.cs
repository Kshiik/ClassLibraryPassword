using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPassword
{
    public class PasswordCheker
    {
        /// <summary>
        /// Проверка пароля
        /// </summary>
        /// <param name="password"></param>
        /// Возращает true при корректном пароле
        /// Возращает false в противном случае
        /// <returns></returns>

        public bool ValidatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 20)
                return false;
            if (!password.Any(Char.IsLower))
                return false;
            if (!password.Any(Char.IsUpper))
                return false;
            if (!password.Any(Char.IsDigit))
                return false;
            if (password.Intersect("#$*&_-^+@").Count()==0)
                return false;
            if (String.IsNullOrEmpty(password))
                return false;


            return true;
        }
        public string GeneratePassword()
        {
            string password="";
            char[] digit = "0123456789".ToCharArray();
            char[] lettersLower = "abcdefghijklmnopqrstuwxyz".ToCharArray();
            char[] lettersUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] specialSymbol = "@#$^_-.*".ToCharArray();
            Random rand = new Random();
            int kol = rand.Next(8, 15);
            char[] pass = new char[kol];

            do
            {
                for (int i = 0; i < kol; i++)
                {
                    int numb = rand.Next(0,4);
                    if (numb == 0)
                    {
                        int a = rand.Next(0, lettersUpper.Length);
                        pass[i] = lettersUpper[a];
                    }
                    if (numb == 1)
                    {
                        int a = rand.Next(0, lettersLower.Length);
                        pass[i] = lettersLower[a];
                    }
                    if (numb == 2)
                    {
                        int a = rand.Next(0, digit.Length);
                        pass[i] = digit[a];
                    }
                    if (numb == 3)
                    {
                        int a = rand.Next(0, specialSymbol.Length);
                        pass[i] = specialSymbol[a];
                    }
                    password = String.Concat(pass);
                }

            } while (!ValidatePassword(password));

            return password;

        }

    }
}
