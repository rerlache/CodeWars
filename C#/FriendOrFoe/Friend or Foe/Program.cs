using System;
using System.Collections.Generic;

namespace Friend_or_Foe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            IEnumerable<string> friends = FriendOrFoe(names);
            foreach (var item in friends)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> result = new();
            foreach (string name in names)
            {
                if (name.Length == 4)
                {
                    result.Add(name);
                }
            }
            return result;
        }
    }
}
