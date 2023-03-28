using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Contracts;
using System.ComponentModel;

//ask user for their first letter guess
//throw an error if what they input is more than one letter or isn't a letter
//if the letter is included in the word, have it replace the appropriate dashes
// if it is not included in the word add it to the "incorrect letters" array and display along with the image 
// loop through asking for user input until they either lose or guess correctly


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

                if (guess == "exit")
                {
                    break;
                }

                int guessLength = guess.Length;
                if (guessLength != 1)
                {
                    Console.WriteLine("Please guess one letter.");
                }

                //check to see if the guess is actually a letter and if not, give an error message
                char guessAsChar = char.Parse(guess);
                bool isLetter = char.IsLetter(guessAsChar);
                if (!isLetter)
                {
                    Console.WriteLine("Guess must be a letter.");
                }

                if (correctCharacters.Contains(guessAsChar))
                {
                    correctGuesses.Add(guessAsChar);
                    Console.WriteLine("Letters you have already guessed:");
                    Console.WriteLine(string.Join(", ", guessedIncorrectlyList));
                }
                else
                {
                    guessedIncorrectlyList.Add(guessAsChar);
                    Console.WriteLine("Letters you have already guessed:");
                    Console.WriteLine(string.Join(", ", guessedIncorrectlyList));

                }

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
                

                switch (guessedIncorrectlyList.Count)
                {
                    case 1:
                        Display.FirstWrongAnswer() ; break;
                    case 2:
                        Display.SecondWrongAnswer() ; break;
                    case 3:
                        Display.ThirdWrongAnswer(); break;
                    case 4:
                        Display.FourthWrongAnswer(); break;
                    case 5:
                        Display.FifthWrongAnswer(); break;
                    case 6:
                        Display.SixthWrongAnswer() ; break;
                    case 7:
                        Display.SeventhWrongAnswer() ;
                        Console.WriteLine("Sorry, you're out of guesses! Better luck next time."); break;

                }

                string wordInProgressNoSpaces = wordInProgress.Replace(" ", "");
                if (wordInProgressNoSpaces == hangmanWord)
                {
                    Console.WriteLine("Congratulations, you won!");
                    break;
                }

                
            }


        }

        //while method a or/and method b, go through the loop and based on that prompt user for another guess

        //check if they've gotten all letters correct (all true - in method) 
        //public bool CheckIfAllCorrect()
        //{

        //}

        ////check if they've run out of guesses
        //public bool StillHaveGuessesLeft()
        //{

        //}

        //check if the input is "exit"
        
    }
}

