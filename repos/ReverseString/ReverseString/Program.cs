using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, reverse = "";
            s = Console.ReadLine();
            for (int i = s.Length-1; i >=0; i--)
            {
                reverse += s[i].ToString();
            }
            Console.WriteLine(reverse);
        }

    }
}
