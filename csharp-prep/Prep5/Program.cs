using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the DisplayWelcome function
        DisplayWelcome();
        
        // Call the PromptUserName function and store the result
        string userName = PromptUserName();
        
        // Call the PromptUserNumber function and store the result
        int userNumber = PromptUserNumber();
        
        // Call the SquareNumber function to square the user's favorite number
        int squaredNumber = SquareNumber(userNumber);
        
        // Call the DisplayResult function to display the result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt for and return the user's name
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to prompt for and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());  // Assumes valid input (no exception handling)
        return number;
    }

    // Function to return the square of the given number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello {name}, your favorite number squared is {squaredNumber}.");
    }
}