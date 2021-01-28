using System;
using System.Collections.Generic;
using System.Text;

namespace Date_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now.Add(new TimeSpan(2, 0, 0, 0)).ToString("ddd,MMMM dd,yyyy"));
            Console.WriteLine(DateTime.Parse("02-12-2014").Add(new TimeSpan(30, 0, 0, 0)).ToString("ddd,MMMM dd,yyyy"));
            Console.ReadKey();
        }
    }
}
