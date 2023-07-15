using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name?");
            var name = System.Console.ReadLine();
            var currentDate = System.DateTime.Now;
            System.Console.WriteLine($"{System.Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            System.Console.Write($"{System.Environment.NewLine}Press any key to exit...");
            System.Console.ReadKey(true);
        }
    }
}