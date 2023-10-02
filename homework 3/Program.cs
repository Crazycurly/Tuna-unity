using System;
namespace homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Celsius to Fahrenheit
            Console.WriteLine("Celsius to Fahrenheit");
            double celsius = 32;
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
        }
    }
}