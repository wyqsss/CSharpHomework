using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    
    public class Dclock
    {
        public delegate void ClockRing();
        public event ClockRing ring;
        public void Beginring(DateTime dt)
        {
            while (true)
            {
                DateTime dt_0 = DateTime.Now;
                if (dt_0 >= dt)
                {
                    ring();
                    break;
                }
            }
        }
    }

    public class Show
    {
        public void print()
        {
            Console.WriteLine("时间到");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ClockRing d = (DateTime dt) => { if (dt == DateTime.Now) Console.WriteLine(dt + "：时间到");
                var ex = new Dclock();
            var show = new Show();
            DateTime dt_1 = DateTime.Parse("2018-10-6 16:08:15");
            ex.ring += new Dclock.ClockRing(show.print);
            ex.Beginring(dt_1);
            }
   
    }
}
