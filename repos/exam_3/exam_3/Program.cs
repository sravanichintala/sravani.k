using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, perimeterOfCir;
            double PI = 3.14;
            Console.WriteLine();
            r = Convert.ToDouble(Console.ReadLine());
            perimeterOfCir = 2 * PI * r;
            Console.WriteLine(perimeterOfCir);
            Console.Read();
        }
    }
}
