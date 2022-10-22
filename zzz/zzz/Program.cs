using System;

namespace zzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = 310;
            DateTime x = DateTime.Now.AddDays(-1); //.AddDays(1);
            //DateTime y = x.AddDays(-w);
            Console.WriteLine(x);
            //Console.WriteLine(y);
            Console.WriteLine("-------------");
            //Console.WriteLine(x.AddDays(-1));

            DateTime z = x.AddDays(-w);
            Console.WriteLine(z);
        }
    }
}
