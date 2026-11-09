using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt for first and last name
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt for last name
        Console.WriteLine("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display the full name in the format "Your name is lastName, firstName lastName!"
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}!");

        
    }
}