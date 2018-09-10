using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "";
            string s2 = "";
            double a = 0;
            double b;
            double c;
            Console.WriteLine("Please input 2 number :");
            s1 = Console.ReadLine();
            a = Double.Parse(s1);
            s2 = Console.ReadLine();
            b = Double.Parse(s2);
            c = a * b;
            Console.WriteLine(a+"*"+b+"="+c);
        }
    }
}
