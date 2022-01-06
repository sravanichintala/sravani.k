using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sravani
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n value");
            int n = int.Parse(Console.ReadLine());
            AssemblyLineSuccessRate(n);
            AssemblyLineProductionRatePerHor(n);
            AssemblyLineWorkingItemsPerMinute(n);


            Console.WriteLine();

            // Console.WriteLine();
            Console.ReadKey();

        }
    }
}
