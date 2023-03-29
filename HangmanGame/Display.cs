using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public static class Display
    {
        public static void DisplayHangmanImage(List<char> guessedIncorrectlyList)
        {
            switch (guessedIncorrectlyList.Count)
            {
                case 1:
                    Display.FirstWrongAnswer(); break;
                case 2:
                    Display.SecondWrongAnswer(); break;
                case 3:
                    Display.ThirdWrongAnswer(); break;
                case 4:
                    Display.FourthWrongAnswer(); break;
                case 5:
                    Display.FifthWrongAnswer(); break;
                case 6:
                    Display.SixthWrongAnswer(); break;
                case 7:
                    Display.SeventhWrongAnswer();
                    Console.WriteLine("Sorry, you're out of guesses! Better luck next time.");
                    Console.ReadKey();
                    break;

            }
        }
        
        public static void FirstWrongAnswer()
        {
            Console.WriteLine(" " + " " + "_______");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
        }
        public static void SecondWrongAnswer()
        {
            Console.WriteLine(" " + " " + "_______");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("(" + " " + ")" + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
        }
        public static void ThirdWrongAnswer()
        {
            Console.WriteLine(" " + " " + "_______");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("(" + " " + ")" + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
        }
        public static void FourthWrongAnswer()
        {
            Console.WriteLine(" " + " " + "_______");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("(" + " " + ")" + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("\\|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
        }
        public static void FifthWrongAnswer()
        {
            Console.WriteLine(" " + " " + "_______");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("(" + " " + ")" + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("\\|/" + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + " " + " " + " " + " " + " " + " " + " " + " " + "|");
        }
        public static void SixthWrongAnswer()
        {
            Console.WriteLine(" " + " " + "_______");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("(" + " " + ")" + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("\\|/" + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("/" + " " + " " + " " + " " + " " + " " + " " + " " + "|");
        }
        public static void SeventhWrongAnswer()            
        {
            Console.WriteLine(" " + " " + "_______");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("(" + " " + ")" + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("\\|/" + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine(" " + "|" + " " + " " + " " + " " + " " + " " + " " + "|");
            Console.WriteLine("/" + " " + "\\" + " " + " " + " " + " " + " " + " " + "|");
        }


        
        
        
        
       
    }
}



//final losing image:
/*  
  _______
 |       |
( )      |
\|/      |
 |       |
/ \      |


*/