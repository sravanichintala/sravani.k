using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_5
{
    class Program
    {
        static void Main(string[] args)
        {
			//	Console.WriteLine("Hello, World!");
			int input1 = Convert.ToInt32(Console.ReadLine());
			int input2 = Convert.ToInt32(Console.ReadLine());

			int sum = input1 + input2;
			if (input1 == input2)
			{
				sum = sum * 3;
				Console.WriteLine(sum);
			}
			else
			{
				Console.WriteLine(sum);
			}
		}
	}
    
}
