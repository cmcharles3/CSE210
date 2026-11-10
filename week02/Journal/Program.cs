using System;

// CREATIVITY / EXCEEDING REQUIREMENTS:
// To exceed the core requirements, I added two extra prompts to the PromptGenerator list.
// I also added a check in the DisplayAll method to let the user know if the journal is empty 
// instead of just showing a blank screen.
// Finally, I used the "|" character as a separator because it handles text much better than a comma.

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Write a new entry
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = randomPrompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                // Display the journal
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Load from file
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }
            else if (choice == "4")
            {
                // Save to file
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
            else if (choice == "5")
            {
                // Quit
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number 1-5.");
            }
        }
    }
}
