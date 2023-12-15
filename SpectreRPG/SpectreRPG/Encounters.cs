using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Spectre.Console;

namespace SpectreRPG
{
    public class Encounters
    {
        Weapons playerWeapon;
        public void StartingEncounter(Player player)
        {
            AnsiConsole.Markup("in the vast expanse of a distant galaxy, your adventure begins as you stumble upon a long-forgotten relic");
            AnsiConsole.Markup("the Ancient Bladecrafter. This legendary weapon, steeped in the history of Eldoria,");
            AnsiConsole.Markup("is said to hold extraordinary power. As you grasp the hilt of the [purple4]EdgeBlade[/],");
                AnsiConsole.Markup("you feel a surge of energy coursing through you, marking the start of a remarkable journey.");
                AnsiConsole.Markup("As you traverse the ancient paths, you encounter a wise old man named [italic blue]Aric the Wanderer[/]");
                AnsiConsole.Markup(" With a knowing gaze, he senses the aura of the [purple4]EdgeBlade[/] and approaches you. ");
                AnsiConsole.Markup("Aric reveals that he has been awaiting the arrival of a true adventurer, marked by the legendary weapon.");
            playerWeapon = new Weapons("EdgeBlade",10,0,0,0,2,80);
            Console.WriteLine();
            AnsiConsole.Markup("You've acquired a new Weapon!");
            if (player.role == "[bold blueviolet]Warlock[/]") 
                playerWeapon.PrintRangedStats();
            else
            playerWeapon.PrintMeleeStats();
            

            
            //var Encounter1 = AnsiConsole.Prompt(
            //    new SelectionPrompt<string>()
            //        .Title($"[seagreen3] [/]")
            //        .PageSize(4)
            //        .AddChoices(new[] {
            //            ""
            //        }));

        }


    }
}
