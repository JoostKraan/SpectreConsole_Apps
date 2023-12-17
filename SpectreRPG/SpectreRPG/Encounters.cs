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
        Inventory playerinventory;
        public void StartingEncounter(Player player)
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
            playerinventory = new Inventory();
            Weapons Edgeblade = new Weapons("EdgeBlade", 10, 0, 0, 0, 2, 95);
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]You've acquired a new Weapon![/]");
            Console.ReadLine();

            string addweapon = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"[seagreen3]Do you want to put[/] [purple4]{Edgeblade.name}[/][seagreen3] in your inventory?[/]")
                .PageSize(3)
                .AddChoices(new[]
                {
                    "[green]Add it![/]","[red]Leave it..[/]"
                }
                ));

            if (addweapon == "[green]Add it![/]")
            {
                player.addToInventory(Edgeblade);
            }
           
            else
            {
                Console.WriteLine("you leave the sword and go home (Quit)");
                Console.ReadLine() ;
                Environment.Exit(0);
            }
           
            playerAcuiredWeapon(Edgeblade);

            if (player.role == "[bold blueviolet]Warlock[/]")
            {
                Edgeblade.PrintRangedStats();
                Console.WriteLine();
                
            }

            else
            {
                Edgeblade.PrintMeleeStats();
                Console.WriteLine();
                
            }
                
            Console.ReadLine();
            Console.Clear();
            AnsiConsole.Markup("[italic blue]Aric[/][seagreen3] hands you a quest note urging you to find an elven camp in [/][green]Eldoria.[/]");
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]They hold vital info about your weapon, the [/][yellow]EdgeBlade.[/]");
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]Ready to uncover secrets?[/]");
            Console.WriteLine();
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
                AnsiConsole.Clear();
                AnsiConsole.Markup("[seagreen3]You go home and [/][italic blue]Aric[/][seagreen3] is disappointed...[/]");
                Console.ReadLine() ;
                Environment.Exit(0);
              
            }


            AttackEncounter(player);
            Console.ReadLine();
            

        }

        public void AttackEncounter(Player player)
        {
            AnsiConsole.Markup("[seagreen3]As you start your little journey to the camp you walk into a dark forest.[/]");
            AnsiConsole.Markup("[seagreen3]You follow the path which leads to the elven camp for your quest...[/]");
            AnsiConsole.Markup("[seagreen3]When following the path you hear footsteps coming closer and closer[/]");
            AnsiConsole.Markup("[seagreen3]Before you know it there is a Duo of [/][green]globins[/][seagreen3] standing infront of you![/]");
            AnsiConsole.Markup("");
            var test = new Enemies("Shrek", 10, 10, 10, 1, 10);
            test.calculateDamageTo(player.strength , 0);


        }

        private void playerAcuiredWeapon(Weapons weapon)
        {
            AnsiConsole.Markup($"[seagreen3]You have acquired the [/][purple4]{weapon.name}[/]");
            Console.WriteLine();
        }


    }
}
