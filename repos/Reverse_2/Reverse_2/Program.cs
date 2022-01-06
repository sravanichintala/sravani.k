using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter a sentance");
            string input = Console.ReadLine();
            input = input.Replace(" ", string.Empty);
            while(input.Length > 0)
              {
                Console.Write(input[0] + "-");
                int Count = 0;
                for ( int i=0; i< input.Length; i++)
                {
                    if (input[0] == input[i])
                    {
                        Count++;
                    }
                }
                Console.WriteLine(Count);
                input = input.Replace(input[0].ToString(), string.Empty);
              }
        }
    }
}
