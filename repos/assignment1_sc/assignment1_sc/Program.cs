using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1_sc
{
    class Program
    {
        static void Main(string[] args)
        {
            
           FileStream Filestreamobj = new FileStream("C:\\Users\\Naveen Kokkirapati\\TEST\\MyFile.txt", FileMode.Open, FileAccess.Read);
           StreamReader sr = new StreamReader(Filestreamobj);
            Console.WriteLine(" ID");
            Console.WriteLine(" Source");
            Console.WriteLine(" Destination");
            Console.WriteLine("Date");
            Console.WriteLine(" Status");
            Console.WriteLine(" Network");



            while (sr.Peek() > 0)
            { 
                string line = sr.ReadLine();
                string[] values = line.Split(':');

                if (values.Length > 1)
                {
                    Console.Write(values[1]);

                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
