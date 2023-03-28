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

            };

            var random = new Random();
            int index = random.Next(WordList.Count);
            return WordList[index];
        }
            
        

    }
}
