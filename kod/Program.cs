using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sifreni daxil edin: ");
            string kod = Console.ReadLine();
            Console.WriteLine(Password(ref kod));
            static bool Password(ref string sifre)
            {
                foreach (char s in sifre)
                {
                    if (char.IsDigit(s) != false || char.IsLetter(char.ToLower(s)) != false || char.IsLetter(char.ToUpper(s)) != false)
                    {
                        return true;

                    }
                    return false;

                }
                return false;
            }
        }
    }
}
