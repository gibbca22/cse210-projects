using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> values = new List<int>();
        int userNumber = -1;
        
        while (userNumber != 0)
        {
            // Get the user input
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                values.Add(userNumber); // Add the number to the list only if it's not 0
            }
        }

        // Ensure the list is not empty before calculating
        if (values.Count > 0)
        {
            // Calculate the sum
            int sum = values.Sum();
            Console.WriteLine("The sum of the numbers is: " + sum);

            // Calculate the average
            float average = (float)sum / values.Count;
            Console.WriteLine($"The average of the numbers is {average}");

            // Calculate the maximum
            int max = values.Max();
            Console.WriteLine($"The maximum number is {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
