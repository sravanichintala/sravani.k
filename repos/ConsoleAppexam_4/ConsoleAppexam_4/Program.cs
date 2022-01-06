using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexam_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Console.WriteLine("Hello, World!");
            char ch = Console.ReadLine()[0];
            if (ch >= 65 && ch <= 90)
            {
                Console.WriteLine("It's a");
                Console.WriteLine("uppercase");
            }
            else if (ch >= 97 && ch <= 122)
            {
                Console.Write("It's a ");
                Console.Write("lowercase ");
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    Console.WriteLine("vowel.");
                }
            }
            else if (ch >= 48 && ch <= 57)
            {
                Console.WriteLine("It's a");
                Console.WriteLine("number");
            }
            else
            {
                Console.WriteLine("It's another symbol.");
            }

            Console.ReadLine();
        }
    }
    
}
