using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((DateTime.Now.Ticks / 10) % 1000000000);
        }
    }
}
