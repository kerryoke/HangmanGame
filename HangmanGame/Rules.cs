using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public static class Rules
    {
        public static void ShowRules()
        {
            Console.WriteLine("Type 1 if you would like to read the rules before playing.");
            Console.WriteLine("Press any key if you would like to proceed with the game and skip the instructions.");

            string showRules = Console.ReadLine();

            string pathToFile = AppDomain.CurrentDomain.BaseDirectory + "//RulesofHangman.txt";
            if (showRules == "1")
            {
                string rulesOfHangman = File.ReadAllText(pathToFile);
                Console.WriteLine(rulesOfHangman+ "\n");

            }
            else 
            {
                Console.WriteLine("Let's play!");
            }
            

        }
    }
}
