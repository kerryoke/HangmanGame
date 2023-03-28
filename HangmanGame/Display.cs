using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public static class Display
    {
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