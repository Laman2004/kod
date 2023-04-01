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
                    int a=0;
                    int b=0;
                    int c=0;
                    if (char.IsDigit(s) != false)
                    {
                        a++;

                    }
                     if (char.IsUpper(s) != false)
                    {
                        b++;

                    }
                     if (char.IsLower(s) != false)
                    {
                        c++;
                    }
                    if(a>0 && b>0 && c>0)
                        return true;
                }
                return false;
            }
        }
    }
}
