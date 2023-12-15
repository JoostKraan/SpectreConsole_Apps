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
        public Player StartingEncounter(Player player)
        {
            AnsiConsole.Markup("[seagreen3]In the vast expanse of a distant galaxy, your adventure begins as you stumble upon a long-forgotten relic, [/]");
            Console.WriteLine();
            AnsiConsole.Markup("[yellow1]the Ancient Bladecrafter[/][seagreen3]. This legendary weapon, steeped in the history of [/][green]Eldoria[/],");
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]is said to hold extraordinary power. As you grasp the hilt of the [/][purple4]EdgeBlade[/],");
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]you feel a surge of energy coursing through you, marking the start of a remarkable journey.[/]");
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]As you traverse the ancient paths, you encounter a wise old man named [/][italic blue]Aric the Wanderer[/]");
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]With a knowing gaze, he senses the aura of the [/][purple4]EdgeBlade[/][seagreen3] and approaches you.[/] ");
            Console.WriteLine();
            AnsiConsole.Markup("[italic blue]Aric[/][seagreen3] reveals that he has been awaiting the arrival of a true adventurer, marked by the legendary weapon.[/]");
            Inventory playerinventory = new Inventory();
            playerWeapon = new Weapons("EdgeBlade", 10, 0, 0, 0, 2, 95);
            
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            AnsiConsole.Markup("You've acquired a new Weapon!");

            string addweapon = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"Do you want to put {playerWeapon.name} in your inventory?")
                .PageSize(3)
                .AddChoices(new[]
                {
                    "[green]Add it![/]","[red]Leave it..[/]"
                }
                ));

            if(addweapon == "[green]Add it![/]")
            playerinventory.AddWeapons(playerWeapon);
            else
            {
                Console.WriteLine("you leave the sword and go home (Quit)");
                Console.ReadLine() ;
                Environment.Exit(0);
            }
            AnsiConsole.Markup("[seagreen3]You have acquired the [/][purple4]Edgebade![/]");
            
            if (player.role == "[bold blueviolet]Warlock[/]")
                playerWeapon.PrintRangedStats();
            else
                playerWeapon.PrintMeleeStats();
            Console.ReadLine();
            Console.Clear();
            AnsiConsole.Markup("[italic blue]Aric[/][seagreen3] hands you a quest note urging you to find an elven camp in [/][green]Eldoria.[/]");
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]They hold vital info about your weapon, the [/][yellow]EdgeBlade.[/]");
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]Ready to uncover secrets?[/]");
            Console.WriteLine();

            string Encounter1 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"[seagreen3]The note that[/][italic blue] Aric [/][seagreen3]handed you says to head north for 3 kilometers to find the elf camp[/]")
                    .PageSize(3)
                    .AddChoices(new[] {
                        "[red]No thanks, I would rather die than find out...[/]","[green]Im in! I will head there as soon as possible![/]"
                    }));
            if(Encounter1 == "[red]No thanks, I would rather die than find out...[/]")
            {
                Console.WriteLine("[seagreen3]You go home and [/][italic blue]Aric[/][seagreen3] is disappointed...[/]");
                Console.ReadLine() ;
                Environment.Exit(0);
            }
            

            Console.WriteLine(player.ShowStats) ;
            Console.ReadLine();
            return player;
        }

        public Player Encounter2(Player player)
        {

            Console.WriteLine(player.ShowStats);
            Console.WriteLine("test");
            Console.ReadLine();
            return player;
        }


    }
}
