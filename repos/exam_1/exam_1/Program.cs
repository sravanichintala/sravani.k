using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string line = Console.ReadLine();
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }

            }
        }
    }
}
