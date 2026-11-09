using System;

class Program
{
    static void Main(string[] args)
    {

       // Call each function, saving return values and passing data along.
       DisplayWelcomeMessage();
       string userName = PromptUserName();
         int userNumber = PromptUserNumber();
         int squaredNumber = SquareNumber(userNumber);

         DisplayResult(userName, squaredNumber);

         // Function to display a welcome message
         static void DisplayWelcomeMessage()
         {
             Console.WriteLine("Welcome to the Program!");
         }

         // Function to prompt the user for their name
         static string PromptUserName()
         {
             Console.Write("Please enter your name: ");
             return Console.ReadLine();
         }

         // Function to prompt the user for a number
         static int PromptUserNumber()
         {
             Console.Write("Please enter a number: ");
             return int.Parse(Console.ReadLine());
         }

         // Function to square a number
         static int SquareNumber(int number)
         {
             return number * number;
         }

         // Function to display the result
         static void DisplayResult(string name, int squaredNumber)
         {
             Console.WriteLine($"Hello {name}! The square of the number you entered is {squaredNumber}.");
         }

    }

    
}