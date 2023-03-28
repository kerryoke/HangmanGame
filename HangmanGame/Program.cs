using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Contracts;
using System.ComponentModel;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to Hangman.");
            Rules.ShowRules();
            Console.WriteLine("Type 'exit' at any time to leave the game.");

            string hangmanWord = Words.GetRandomWord();

            //included for testing - REMOVE LATER
            Console.WriteLine(hangmanWord);

            List <char> correctCharacters = new List<char>();
            correctCharacters.AddRange(hangmanWord);

            Console.WriteLine();
            //display _ for each letter in the word
            for (int i = 0; i < correctCharacters.Count; i++)
            {
                Console.Write("_ ");
            }
            
            string guess = null;
            List<char> guessedIncorrectlyList = new List<char>();  
            List<char> correctGuesses = new List<char>();
            while (guess != "exit" && guessedIncorrectlyList.Count < 7)
            {
                Console.WriteLine("\n\nGuess a letter:");
                guess = Console.ReadLine().ToLower();

                if (guess.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                int guessLength = guess.Length;
                if (guessLength != 1)
                {
                    Console.WriteLine("Please guess one letter.");
                }
                else
                {
                    //check to see if the guess is actually a letter and if not, give an error message
                    //and ask for another guess
                    char guessAsChar = char.Parse(guess);
                    bool isLetter = char.IsLetter(guessAsChar);
                    if (!isLetter)
                    {
                        Console.WriteLine("Guess must be a letter.");
                    }
                    else
                    {
                        if (correctCharacters.Contains(guessAsChar))
                        {
                            correctGuesses.Add(guessAsChar);
                        }
                        else
                        {
                            guessedIncorrectlyList.Add(guessAsChar);
                        }
                        Console.WriteLine("Letters you have already guessed:");
                        Console.WriteLine(string.Join(", ", guessedIncorrectlyList));

                        //display _ or letter depending on correct guesses
                        string wordInProgress = Utility.DetermineWordInProgress(correctCharacters, correctGuesses);

                        Display.DisplayHangmanImage(guessedIncorrectlyList);

                        string wordInProgressNoSpaces = wordInProgress.Replace(" ", "");
                        if (wordInProgressNoSpaces == hangmanWord)
                        {
                            Console.WriteLine("Congratulations, you won!");
                            break;
                        }
                    }
                }
                
            }


        }

        
    }
}

