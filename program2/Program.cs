using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("你要输入的数组多长：");
            string s = Console.ReadLine();
            int ncount = Int32.Parse(s);
            int[] array = new int [ncount];
            for(int i = 0;i<ncount;i++)
            {
                string st = Console.ReadLine();
                array[i] = Int32.Parse(st);
            }
            int maxnum = array[0];
            int minnum = array[0];
            double sum = 0;
            for(int j = 0;j<ncount;j++)
            {
                if (array[j] > maxnum)
                    maxnum = array[j];
                if (array[j] < minnum)
                    minnum = array[j];
                sum = sum + array[j];
            }
            Console.WriteLine("最大值:" + maxnum);
            Console.WriteLine("最小值:" + minnum);
            double average = sum / ncount;
            Console.WriteLine("平均值:" + average);
            Console.WriteLine("和:" + sum);
        }
    }
}
