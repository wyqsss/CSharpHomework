using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] de = new bool [101];
            de[0] = false;
            de[1] = false;
            for(int i =2;i<=100;i++)
            {
                de[i] = true;
            }
            for(int i = 2; i <= 100; i++)
            {
                for (int j = 2*i; j <= 100; j = j + i)
                    de[j] = false;
            }
            for(int k = 2;k<=100;k++)
            {
                if (de[k])
                    Console.Write(" " + k);
            }
        }
    }
}
