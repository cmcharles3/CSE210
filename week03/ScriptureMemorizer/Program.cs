

using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * EXCEEDING REQUIREMENTS NOTE:
             * To get 100%, I have implemented the "scripture library" challenge.
             * The program stores a list of multiple scriptures and selects one at random
             * at the start of each session. This gives the user variety and helps them 
             * memorize more than just one verse.
             * 
             * I also implemented the stretch challenge: the HideRandomWords method
             * only selects from words that have NOT yet been hidden.
             */

            // Scriptures library
            List<Scripture> scriptureLibrary = new List<Scripture>
            {
                new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life."),
                new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths."),
                new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
                new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd I shall not want."),
                new Scripture(new Reference("Mosiah", 2, 17), "And behold I tell you these things that ye may learn wisdom that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.")
            };

            // Selecting a random scripture from the library
            Random random = new Random();
            Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            // Main loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine();

                // Checking if all words are hidden; if so, end the program
                if (currentScripture.IsCompletelyHidden())
                {
                    break;
                }

                Console.WriteLine("Press Enter to continue, or type 'quit' to end:");
                string userInput = Console.ReadLine();

                if (userInput != null && userInput.ToLower().Trim() == "quit")
                {
                    break;
                }

                // Hiding a random number of words (3 is a good amount)
                currentScripture.HideRandomWords(3);
            }
        }
    }
}