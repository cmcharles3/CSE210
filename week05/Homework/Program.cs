using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the base Assignment class
            Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(assignment.GetSummary());
            Console.WriteLine();

            // Testing the MathAssignment class
            MathAssignment mathAssignment = new MathAssignment(
                "James Stewart", 
                "Single-variable", 
                "5.3", 
                "2-13"
            );
            Console.WriteLine(mathAssignment.GetSummary());
            Console.WriteLine(mathAssignment.GetHomeworkList());
            Console.WriteLine();

            // Testing the WritingAssignment class
            WritingAssignment writingAssignment = new WritingAssignment(
                "Charles Dickens", 
                "English Author", 
                "Oliver Twist"
            );
            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingInformation());
        }
    }
}