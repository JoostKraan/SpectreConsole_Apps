using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using SpectreRPG.Automation;

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

            AnsiConsole.Markup("This is the word : " + new string(chars));
            return new string(chars);
        }
        public bool PlayScrambleGame()
        {
            bool isCorrect = false;

            while (!isCorrect)
            {
                TextPos.Center($"{Textcolor.HeaderText("Scramble")}");
                AnsiConsole.Markup("I entrust you with a vital mission: decipher a key word that unlocks access to an enemy base, where my friend is currently held captive.");
                AnsiConsole.Markup("The word you need to decrypt is crucial for freeing my friend.");
                AnsiConsole.Markup("Generous rewards await you upon the successful completion of this mission.");
                string scrambledWord = Scramble("trapped");
                AnsiConsole.WriteLine();

                string word = AnsiConsole.Prompt(new TextPrompt<string>("")
                    .PromptStyle("seagreen3"));

                if (word.ToLower() == scrambledWord.ToLower())
                {
                    isCorrect = true;
                    AnsiConsole.Markup("[green]Correct[/]");
                    AnsiConsole.WriteLine();
                }
                else
                {
                    AnsiConsole.Markup("[red]Nu uh[/]");
                    AnsiConsole.WriteLine();
                }
            }

            return isCorrect;
        }
    }
}

