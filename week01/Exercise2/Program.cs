using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, my daughter! What is your percentage mark? ");
        string input = Console.ReadLine();
        double percentage = double.Parse(input);

        if (percentage >= 90)   
        {
            Console.WriteLine("You got an A!");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("You got a B!");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("You got a C!");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("You got a D!");
        }
        else
        {
            Console.WriteLine("You got an F!");
        }

        //Stretch Challenge
        int lastDigit = (int)percentage % 10;
        string sign;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Display the letter grade with the sign
        if (letter == "A" && sign == "+")
        {
            Console.WriteLine("You got an A+!");
        }
        else if (letter == "A" && sign == "-")
        {
            Console.WriteLine("You got an A-!");
        }
        else if (letter == "B" && sign == "+")
        {
            Console.WriteLine("You got a B+!");
        }
        else if (letter == "B" && sign == "-")
        {
            Console.WriteLine("You got a B-!");
        }
        else if (letter == "C" && sign == "+")
        {
            Console.WriteLine("You got a C+!");
        }
        else if (letter == "C" && sign == "-")
        {
            Console.WriteLine("You got a C-!");
        }
        else if (letter == "D" && sign == "+")
        {
            Console.WriteLine("You got a D+!");
        }
        else if (letter == "D" && sign == "-")
        {
            Console.WriteLine("You got a D-!");
        }
        else
        {
            Console.WriteLine($"You got an {letter}.");
        }

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass.");
        }
    }
}