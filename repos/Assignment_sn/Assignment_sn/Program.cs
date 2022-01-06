using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_sn
{
    class Program
    {
        static void Main(string[] args)
        {
            Student sobj = new Student();
            sobj.Enroll("1", "Naveen", "c#");
            Student sobj1 = new Student();
            sobj1.Enroll("2", "sravani", "ASP.NET");
            sobj.payment(1000);
            sobj1.payment(1000);
            sobj.print();
            sobj1.print();
            Console.ReadKey();
        }
    }
}
