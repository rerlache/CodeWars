using System;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Console.Write("p1 select: ");
                string p1Input = Console.ReadLine();
                Console.Write("p2 select: ");
                string p2Input = Console.ReadLine();
                Console.WriteLine(Play(p1Input, p2Input));
                Console.ReadLine();
            } while (true);
        }
        public static string Play(string p1, string p2)
        {
            if (p1 == p2)
            {
                return "Draw!";
            }
            if ((p1 == "scissors" && p2 == "paper") || (p1 == "paper" && p2 == "rock") || (p1 == "rock" && p2 == "scissors"))
            {
                return "Player 1 won!";
            }
            else
            {
                return "Player 2 won!";
            }
        }
    }
}
