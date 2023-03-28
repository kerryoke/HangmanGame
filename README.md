# Hangman Game

This console app lets the user play a classic game of Hangman. A word is randomly selected from a list and then the program asks for single-letter guesses from the user in order to complete the correct word. The program makes sure that the guess is a single letter and not an invalid character or multiple letters. If a letter is guessed correctly, the letter is displayed in the correct position in the word. If a letter is guessed incorrectly, a corresponding image is shown as the hangman character gets drawn with each successive incorrect guess with a limit of 7 incorrect guesses. 

This program was created using Visual Studio 2022 and .NET 7.0. 

The following features have been included in this project:
1. Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program
2. Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program
3. Calculate and display data based on an external factor (ex: get the current date, and display how many days remaining until some event (counts incorrect guesses and displays corresponding image)
4. Read data from an external file, such as text, JSON, CSV, etc and use that data in your application
5. Analyze text and display information about it (determines how many letters in the random word; compares strings to determine if the correct answer has been reached)
