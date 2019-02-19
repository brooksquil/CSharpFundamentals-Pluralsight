using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Your Name: ");
            
            string name = Console.ReadLine();
            
            Console.WriteLine("How many hours of sleep did you get last night? ");
            
            // Readline returns a string - int.parse converts the input to and int
            int hoursOfSleep = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Hello, " + name + "...");
            if (hoursOfSleep > 8)
            {
                Console.WriteLine("You are well rested!");
            }
            else
            {
                Console.WriteLine("You need more sleep!");
            }
        }
    }
}