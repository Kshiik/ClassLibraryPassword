using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPassword;

namespace PasswordProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordCheker obj = new PasswordCheker();

            Console.WriteLine(obj.GeneratePassword());
            Console.ReadKey();
        }
    }
}
