using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            int width = num;

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }
        }
    }
}
