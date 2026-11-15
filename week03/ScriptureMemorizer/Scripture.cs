using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            
            // Splitting text into words and create Word objects
            string[] wordsArray = text.Split(' ');
            foreach (string w in wordsArray)
            {
                _words.Add(new Word(w));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            
            // Stretch Challenge: Only selecting from words that are NOT already hidden
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

            // Hiding the requested number of words (or all remaining visible words if less than requested)
            int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

            for (int i = 0; i < wordsToHide; i++)
            {
                // Picking a random index from the visible words
                int randomIndex = random.Next(visibleWords.Count);
                visibleWords[randomIndex].Hide();
                
                // Removing from the list so we don't pick it again in this loop
                visibleWords.RemoveAt(randomIndex); 
            }
        }

        public string GetDisplayText()
        {
            string displayText = _reference.GetDisplayText() + " ";
            foreach (Word word in _words)
            {
                displayText += word.GetDisplayText() + " ";
            }
            return displayText.Trim();
        }

        public bool IsCompletelyHidden()
        {
            // Returns true if all words are hidden
            return _words.All(w => w.IsHidden());
        }
    }
}