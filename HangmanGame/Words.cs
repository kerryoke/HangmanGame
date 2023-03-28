using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    public static class Words
    {

        public static string GetRandomWord()
        {
            List<string> WordList = new List<string>
            {
                 "banjo",
                 "phone",
                 "buzzard",
                 "rooster",
                 "shovel",
                 "buffalo",
                 "zombie",
                 "abruptly",
                 "bayou",
                 "jackpot",
                 "cobweb",
                 "crypt",
                 "vortex",
                 "luxury",
                 "glyph",
                 "haiku",
                 "jaundice",
                 "swivel",
                 "syndrome",
                 "transcript",
                 "twelfth",
                 "unknown",
                 "whiskey",
                 "whomever",
                 "xylophone",
                 "zilch",
                 "kazoo",
                 "keyhole",
                 "flapjack",
                 "jigsaw",
                 "joking",
                 "kilobyte",
                 "knapsack",
                 "rhythm",
                 "rhubarb",
                 "schnapps",
                 "snazzy",
                 "sphinx",
                 "squawk",
                 "strength",
                 "zipper",
                 "polka",
                 "pneumonia",
                 "psyche",
                 "vaporize",
                 "waltz",
                 "wristwatch",
                 "jazz",

            };

            var random = new Random();
            int index = random.Next(WordList.Count);
            return WordList[index];
        }
            
        

    }
}
