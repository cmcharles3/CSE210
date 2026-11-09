using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

    }

    //Create the list of numbers
    List<int> numbers = new List<int>();

    int number;
    do
    {
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        // Add the number to the list if it's not 0
        if (number != 0)
        {
            numbers.Add(number);
        }

    } while (number != 0);

    // Calculate and display the sum
    int sum = 0;
    foreach (int num in numbers)
    {
        sum += num;
    }       
    Console.WriteLine($"The sum of the numbers is: {sum}");

    // Calculate and display the average
    double average = (double)sum / numbers.Count;
    Console.WriteLine($"The average of the numbers is: {average}");

    // Find and display the maximum number
    int max = numbers[0];
    foreach (int num in numbers)
    {
        if (num > max)
        {
            max = num;
        }
    }
    Console.WriteLine($"The maximum number is: {max}");

    // Find and display the minimum number
    int min = numbers[0];
    foreach (int num in numbers)
    {
        if (num < min)
        {
            min = num;
        }
    }
    Console.WriteLine($"The minimum number is: {min}");
}
