using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_sk
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentDetails SravaniStudentDetails = new StudentDetails(1001, "Sravani", "c#");
            StudentDetails JanuStudentDetails = new StudentDetails(1002, "Janu", "ASP.NET");


            SravaniStudentDetails.Payment(200);
            JanuStudentDetails.Payment(100);


            SravaniStudentDetails.Print();

            Console.WriteLine("\n");


            JanuStudentDetails.Print();
        }
    }
}
