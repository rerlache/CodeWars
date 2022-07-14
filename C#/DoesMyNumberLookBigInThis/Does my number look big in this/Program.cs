using System;

namespace Does_my_number_look_big_in_this
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number to check: ");
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine(String.Format("is the number {0} narcistic?", value));
                Console.WriteLine(Narcissistic(value));
                Console.WriteLine("Press enter to restart");
                Console.ReadLine();

            } while (true);
        }
        public static bool Narcissistic(int value)
        {
            int result = 0;
            string str = value.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                double digit = Char.GetNumericValue(str[i]);
                result += (int)Math.Pow(digit, str.Length);
            }
            return result == value;
        }
    }
}
