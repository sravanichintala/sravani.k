using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_sn
{
    class Student
    {
        public String RollNumber, name, Course;
        public double totalFee,dueAmount;
        public double TotalFee 
        {
            get { return TotalFee; }
            set { totalFee = value; }
        }        

        public double DueAmount
        { 
            get { return dueAmount; }
            set { dueAmount = value; }
        }
        public void Enroll(String RollNumber,String Name,String Course)
        {
            if(Course.Equals("c#"))
            {
                TotalFee = 2000;
                dueAmount = 2000;
            }
            else
            {
                TotalFee = 3000;
                dueAmount = 3000;
            }
        }
        public void payment(double amount)
        {
            if (dueAmount >= amount)
                dueAmount -= amount;
            else
                dueAmount = 0;
        }
        public void print()

        {
            Console.WriteLine("RollNumber : " + RollNumber);
             Console.WriteLine("Name: " + name);
            Console.WriteLine("Course : " + Course);
            Console.WriteLine("TotalFee : " + TotalFee);
            Console.WriteLine("dueAmount : " + dueAmount);
        }

    }
        
       
}
