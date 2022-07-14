using System;
using System.Text.RegularExpressions;

namespace FIXME_Replace_all_dots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceDots("one.two.three"));
            Console.ReadLine();
        }

        public static string ReplaceDots(string str)
        {
            return new Regex(@"\.").Replace(str, "-");
        }
    }
}
