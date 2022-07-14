using System;
using System.Linq;

namespace SimpleStringCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (var item in solve(Console.ReadLine()))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public static int[] solve(String s)
        {
            // nicer solution
            return new[]
            {
                s.Count(char.IsUpper),
                s.Count(char.IsLower),
                s.Count(char.IsDigit),
                s.Count(x => !char.IsLetterOrDigit(x))
            };
            // first try
            //
            //int ucCounter = 0;
            //int lcCounter = 0;
            //int nrCounter = 0;
            //int scCounter = 0;
            //foreach (var item in s)
            //{
            //    if (char.IsUpper(item))
            //    {
            //        ucCounter++;
            //    }
            //    if (char.IsLower(item))
            //    {
            //        lcCounter++;
            //    }
            //    if (char.IsDigit(item))
            //    {
            //        nrCounter++;
            //    }
            //    if (!char.IsLetterOrDigit(item))
            //    {
            //        scCounter++;
            //    }
            //}
            //int[] result = new int[] {ucCounter, lcCounter, nrCounter, scCounter};
            //return result;
        }
    }
}
