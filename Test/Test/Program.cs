using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = null;
            {
                Dictionary<int, string> dic1 = new Dictionary<int, string>()
             {
                                                {1,"Banana "},
                                                {2, "Laranja "},
                                                {3, "Manga "},
                                                {4, "Abacate "},
                                                {5,"Maça"}
              };
                foreach (KeyValuePair<int, string> item in dic1)
                {
                    x = x + $"chave: {item.Key}, valor: {item.Value}";
                    
                }
            }
            Console.WriteLine(x);
            //    StringBuilder sb = new StringBuilder();
            //    ShowSBInfo(sb);
            //    sb.Append("This is a sentence.");
            //    ShowSBInfo(sb);
            //    for (int ctr = 0; ctr <= 10; ctr++)
            //    {
            //        sb.Append("This is an additional sentence.");
            //        ShowSBInfo(sb);
            //    }
            //}
            //private static void ShowSBInfo(StringBuilder sb)
            //{
            //    foreach (var prop in sb.GetType().GetProperties())
            //    {
            //        if (prop.GetIndexParameters().Length == 0)
            //            Console.Write("Douglas", prop.Name, prop.GetValue(sb));
            //    }
            //    Console.WriteLine();
        }
    }
}
