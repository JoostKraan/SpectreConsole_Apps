using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace SpectreRPG.Game
{
    public class Minigame
    {
        public static string Scramble(string word)
        {
            char[] chars = word.ToCharArray();
            Random random = new Random();

            for (int i = chars.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
            }

            // Use the shuffled chars array, not the original word
            AnsiConsole.Markup("This is the word : " + new string(chars));

            // Return the shuffled word
            return new string(chars);
        }


    }





}

