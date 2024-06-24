using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            var r = new Random();
            //var favNumber = r.Next(0, 1001);
            var favNumber = 5;

            Console.WriteLine("Pick a number from 1 - 1000");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is to low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is to high");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }
    }
}
