using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SixLabors.ImageSharp.Processing.Processors.Convolution;
using Spectre.Console;

namespace SpectreRPG
{
    public class Encounters
    {
        Enemies Goblin1 = new Enemies("Gorlock", 5, 3, 1, 1, 5);
        Enemies Goblin2 = new Enemies("Bingus", 5, 3, 1, 1, 5);
        Weapons Edgeblade = new Weapons("EdgeBlade", 10, 0, 0, 0, 2, 95);
        Inventory playerinventory;
        public void StartingEncounter(Player player)
        {
            
            AnsiConsole.Markup($"{Textcolor.NormalText("In the vast expanse of a distant galaxy, your adventure begins as you stumble upon a long-forgotten relic, ")}");
            Console.WriteLine();
            AnsiConsole.Markup($"{Textcolor.WeaponText("the Ancient EdgeBlade")}{Textcolor.NormalText("This legendary weapon, steeped in the history of Eldoria ,")}");
            Console.WriteLine();
            AnsiConsole.Markup($"{Textcolor.NormalText("is said to hold extraordinary power. As you grasp the hilt of the")}{Textcolor.WeaponText("EdgeBlade ")}");
            Console.WriteLine();
            AnsiConsole.Markup($"{Textcolor.NormalText("you feel a surge of energy coursing through you, marking the start of a remarkable journey.")}");
            Console.WriteLine();
            AnsiConsole.Markup($"{Textcolor.NormalText("As you traverse the ancient paths, you encounter a wise old man named")}{Textcolor.NameText("Aric the Wanderer")}");
            Console.WriteLine();
            AnsiConsole.Markup($"{Textcolor.NormalText("With a knowing gaze, he senses the aura of the ")}{Textcolor.WeaponText("EdgeBlade")}{Textcolor.NormalText("and approaches you.")}");
            Console.WriteLine();
            AnsiConsole.Markup($"{Textcolor.NameText("Aric")}{Textcolor.NormalText("reveals that he has been awaiting the arrival of a true adventurer, marked by the legendary weapon.")}");
            playerinventory = new Inventory();
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]You've acquired a new Weapon![/]");
            player.GainExperience(125);
            Console.ReadLine();

            string addweapon = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title($"{Textcolor.NormalText("Do you want to put")}{Textcolor.WeaponText(Edgeblade.name)}{Textcolor.NormalText("in your inventory?")}")
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
            Console.Clear();
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
            //Todo 


            AttackEncounter(player,playerinventory);
            Console.ReadLine();
            

        }

        public void AttackEncounter(Player player,Inventory playerinventory)
        {
            AnsiConsole.Markup($"{Textcolor.NormalText("As you start your little journey to the camp you walk into a dark forest.")}");
            AnsiConsole.Markup($"{Textcolor.NormalText("You follow the path which leads to the elven camp for your quest...")}");
            AnsiConsole.Markup($"{Textcolor.NormalText("When following the path you hear footsteps coming closer and closer")}");
            AnsiConsole.Markup($"{Textcolor.NormalText("Before you know it there is a duo of ")}{Textcolor.RogueText("Glowblins")}{Textcolor.NormalText("standing infront of you!")}");
            AnsiConsole.Markup($"{Textcolor.NormalText("You try to talk to them by offering them peace")}");
            AnsiConsole.Markup($"{Textcolor.NormalText("The Glowblins ignore you and demand you to give your shiny sword.")}");

            string Attack1 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Gorlock starts running towards you in an attempt to attack you and steal all of your valuables")
                .PageSize(3)
                .AddChoices(new[] {
                    "Flee","Fight back"
                }));
            if(Attack1 == "Fight back")
            {
                while (Goblin1.health >= 0 && Goblin2.health >= 0)
                {
                    string playerChoice = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                            .Title("")
                            .PageSize(3)
                            .AddChoices(new[] {
                                "Use Melee",""
                            }));
                    switch (playerChoice)
                    {
                        case "Use Melee":
                            Goblin1.TakeDamage(player);
                            break;
                        default:
                            AttackEncounter(player, playerinventory);
                            break;
                    }
                    if (Goblin1.health <= 0)
                    {
                        bool hasdodged = false;
                        AnsiConsole.Markup("As Bingus the goblin watches as you hit his companion. He falls down and dies");
                        AnsiConsole.Markup(". Bingus the goblin charges at you with rage");

                        string playerchoice1 = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                                .Title("")
                                .PageSize(3)
                                .AddChoices(new[] {
                                    "Dodge","Attack"
                                }));

                        switch (playerchoice1)
                        {
                            case "Dodge":
                                hasdodged = true;
                                Dodge(Goblin2,player);
                                    break;
                            case "Attack":
                                attack(Goblin2,player);
                                break;

                        }
                        string playerchoice2 = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                                .Title($"You stand face to face with {Goblin2.name}. You try to negotiate about keeping peace but {Goblin2.name} denies and tries to go in for an attack, " +
                                       $"so the only option you have is to end this fight by swinging your {Edgeblade.name} at the enemy")
                                .PageSize(3)
                                .AddChoices(new[] {
                                    "Attack",""
                                }));

                        if (playerchoice2 == "Attack")
                        {
                            Goblin2.TakeDamage(player);
                        }


                    }
                    AnsiConsole.Markup("");
                    Console.ReadLine();
                    player.GainExperience(100);


                }
                
            }
            if (Attack1 == "Flee")
            {
                Flee(player, playerinventory);
            }
            
            if (player.health == 0) {
                Console.WriteLine("death");
            }

           
           
            Console.ReadLine();
            

        }
        public void Flee(Player player,Inventory playerinventory)
        {
            AnsiConsole.Markup($"{Textcolor.NormalText("You've chosen to flee from the scene to try and outrun the")}{Textcolor.RogueText("Glowblins")}{Textcolor.NormalText("and escape")}");
        }
        public void Fight(Player player, Inventory playerinventory)
        {
            player.TakeDamage(player.health);
            AnsiConsole.Markup("");
        }

        private void playerAcuiredWeapon(Weapons weapon)
        {
            AnsiConsole.Markup($"{Textcolor.NormalText("You have acquired the")}{Textcolor.WeaponText(weapon.name)}");
            
        }
        public void Dodge(Enemies enemy,Player player)
        {
            bool isDodged;
            Random random = new Random();
            int randomChance = random.Next(1);

            if (randomChance == 0)
                isDodged = false;
            else
                isDodged = true;
            
            if (isDodged)
                AnsiConsole.Markup($"You have dodged {Goblin2.name} and escaped his attack by a hair!");
            else
            {
                AnsiConsole.Markup($"Your attempt in dodging {Goblin2.name} failed! He hit you and you took some damage...");
                player.TakeDamage(Goblin2);
            }
            
            Console.ReadLine();
        }

        public void attack(Enemies enemy,Player player)
        {
            Goblin2.TakeDamage(player)//TODO fix this death
        }
       


    }
}
