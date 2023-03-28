using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public static class DisplayWordInProgress
    {
        public static string DetermineWordInProgress(List<char> correctCharacters, List<char> correctGuesses)
        {
            string wordInProgress = string.Empty;
            for (int i = 0; i < correctCharacters.Count; i++)
            {
                if (correctGuesses.Contains(correctCharacters[i]))
                {
                    wordInProgress += $"{correctCharacters[i]} ";
                }
                else
                {
                    wordInProgress += "_ ";
                }
            }
            Console.WriteLine(wordInProgress);
            return wordInProgress;
        }
    }
}
