using System;
using System.Text;

namespace Convert_string_to_camel_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert: the-stealth-warrior");
            Console.WriteLine(ToCamelCase("the-stealth-warrior"));
            Console.WriteLine("Convert: The_Stealth_Warrior");
            Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));
            Console.ReadLine();
        }

        static string ToCamelCase(string str)
        {
            StringBuilder sb = new();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '-' && str[i] != '_')
                {
                    sb.Append(str[i]);
                }
                else
                {
                    sb.Append(char.ToUpper(str[i + 1]));
                    i++;
                }
            }
            return sb.ToString();
        }
    }
}
