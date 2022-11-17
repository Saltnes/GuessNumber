using System;

namespace GuessN
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This program thinks of a number between 0 and your input");
            Console.WriteLine("Then you'll have guess the number!");
            Console.WriteLine("The program will let you know if the number is too high or too low");
            Console.WriteLine("Enter the highest number the program will think about");

            var highest = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            var numberToGuess = random.Next(highest) + 1;
            var userGuess = 0;
            var guesses = 0;

            Console.WriteLine("Good luck the number is between 1 and {0}!", highest);

            while (userGuess != numberToGuess)
            {
                guesses++;

                Console.WriteLine("Enter your guess!");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("{0} is too high!", userGuess);
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("{0} is too low!", userGuess);
                }
                else
                {
                    Console.WriteLine("{0} is right. Congratulations you guessed the number!", userGuess);
                    Console.WriteLine("You used: {0}", guesses + " guesses! Press any key to exit.");
                    Console.ReadLine();
                }
            }
        }
    }
}