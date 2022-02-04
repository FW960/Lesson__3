using System;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int i = 0;

        string hi = Console.ReadLine();

        i = hi.Length - 1;

        do
        {

        Console.Write(hi[i]);

        i--;
        } while (i <= hi.Length && i >= 0);

        Console.WriteLine();
        }
    }
}
