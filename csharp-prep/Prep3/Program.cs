using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        string response;
        do
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Generate the random number once per round
            int number = 0; // To store user's guess
            
            Console.WriteLine("I am thinking of a number between 1 and 100.");
            
            while (number != randomNumber)
            {
                Console.WriteLine("What is your guess?");
                string guess = Console.ReadLine();
                
                // Validate the input
                if (int.TryParse(guess, out number))
                {
                    if (number < randomNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (number > randomNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You guessed the number!");
                        break; // Exit the loop when the user guesses correctly
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("Would you like to play again? (yes/no)");
            response = Console.ReadLine()?.ToLower(); // Ensure case-insensitive comparison
        } while (response == "yes");

        Console.WriteLine("Thanks you for playing! Goodbye!");
    }
}