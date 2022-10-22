using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime date = DateTime.Now.AddDays(-30);
            Console.WriteLine(date);
            Console.WriteLine("---------------------------");
            DateTime date2 = new DateTime(2022, 09, 20, 18, 43, 01, 952);
            DateTime date3 = new DateTime(2021, 12, 01, 18, 43, 01, 952);
            _ = date2 - date3;
            Console.WriteLine(_);
        }
    }
}
