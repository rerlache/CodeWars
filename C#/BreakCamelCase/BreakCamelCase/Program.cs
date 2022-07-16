using System;
using System.Text;

namespace BreakCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(BreakCamelCase("breakCamelCase"));
            Console.ReadLine();
        }

        static string BreakCamelCase(string str)
        {
            StringBuilder sb = new();
            foreach (char item in str)
            {
                if (!char.IsUpper(item))
                {
                    sb.Append(item);
                }
                else
                {
                    sb.Append(" ");
                    sb.Append(item);
                }
            }
            return sb.ToString();
        }
    }
}
