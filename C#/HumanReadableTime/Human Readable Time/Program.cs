using System;

namespace Human_Readable_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] seconds = { 0, 5, 60, 86399, 359999 };
            foreach (int i in seconds)
            {
                Console.WriteLine(GetReadableTime(i));
            }
            Console.ReadLine();
        }
        public static string GetReadableTime(int seconds)
        {
            int hs;
            int mins;
            int secs;
            TimeSpan ts = TimeSpan.FromSeconds(seconds);
            if (ts.Days >= 1)
            {
                hs = ts.Days * 24 + ts.Hours;
            }
            else
            {
                hs = ts.Hours;
            }
            mins = ts.Minutes;
            secs = ts.Seconds;
            return String.Format("{0:00}:{1:00}:{2:00}", hs, mins, secs);
        }
    }
}
