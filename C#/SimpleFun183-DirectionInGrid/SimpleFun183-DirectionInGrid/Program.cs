using System;

namespace SimpleFun183_DirectionInGrid
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DirectionInGrid(3, 3));
            Console.ReadLine();
        }

        static char DirectionInGrid(int n, int m)
        {
            int grid = n * m;
            return 'C';
        }
    }
}
