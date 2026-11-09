using System;

class Program
{
    static void Main(string[] args)
    {
        // Outer loop for "play again" functionality
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");

            // Inner loop for guessing the number
            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Input validation to ensure the user enters a valid integer
                if (int.TryParse(input, out userGuess))
                {
                    attempts++;

                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {attempts} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }