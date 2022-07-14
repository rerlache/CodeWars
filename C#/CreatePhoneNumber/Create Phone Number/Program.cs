using System;

namespace Create_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Change intArray to phonenumber format...");
            Console.Write("1234567890 -> ");
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Console.Write("1111111111 -> ");
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }
        static string CreatePhoneNumber(int[] numbers)
        {
            var temp = long.Parse(string.Concat(numbers));
            ;
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
            //return String.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
            //    numbers[0],
            //    numbers[1],
            //    numbers[2],
            //    numbers[3],
            //    numbers[4],
            //    numbers[5],
            //    numbers[6],
            //    numbers[7],
            //    numbers[8],
            //    numbers[9]);
        }
    }
}
