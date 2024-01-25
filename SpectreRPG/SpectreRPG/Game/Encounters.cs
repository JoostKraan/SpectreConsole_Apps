using Spectre.Console;
using SpectreRPG.Automation;
using System.Reflection.Emit;
using System.Xml.Linq;


namespace SpectreRPG.Game
{
    public class Encounters
    {
        bool hasplayed = false;
        Minigame minigames = new Minigame();
        Enemies Goblin1 = new Enemies("Gorlock", 5, 3, 1, 1, 5);
        Enemies Goblin2 = new Enemies("Bingus", 5, 3, 1, 1, 5);
        Weapons Edgeblade = new Weapons("EdgeBlade", 10, 0, 0, 0, 2, 95);
        Inventory playerinventory;
        public void StartingEncounter(Player player)
        {
            Console.Clear();
            TextPos.Center($"{Textcolor.HeaderText("Story Intro")}");
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("In the vast expanse of a distant galaxy, your adventure begins as you stumble upon a long-forgotten relic, ")}");
            Console.WriteLine();
            AnsiConsole.MarkupLine($"{Textcolor.WeaponText("the Ancient EdgeBlade")}{Textcolor.NormalText("This legendary weapon, steeped in the history of Eldoria ,")}");
            Console.WriteLine();
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("is said to hold extraordinary power. As you grasp the hilt of the")}{Textcolor.WeaponText("EdgeBlade ")}");
            Console.WriteLine();
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("you feel a surge of energy coursing through you, marking the start of a remarkable journey.")}");
            Console.WriteLine();
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("As you traverse the ancient paths, you encounter a wise old man named")}{Textcolor.NameText("Aric the Wanderer")}");
            Console.WriteLine();
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("With a knowing gaze, he senses the aura of the ")}{Textcolor.WeaponText("EdgeBlade")}{Textcolor.NormalText("and approaches you.")}");
            Console.WriteLine();
            AnsiConsole.MarkupLine($"{Textcolor.NameText("Aric")}{Textcolor.NormalText("reveals that he has been awaiting the arrival of a true adventurer, marked by the legendary weapon.")}");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            AnsiConsole.MarkupLine("[seagreen3]You've acquired a new Weapon![/]");
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
                Console.WriteLine($"{Textcolor.NormalText("you leave the sword and go home (Quit)")}");
                Console.ReadLine();
                Environment.Exit(0);
            }
            player.PlayerAcquireddWeapon(Edgeblade);

            if (player.role == "[bold blueviolet]Warlock[/]")
            {
                Console.WriteLine();
                Edgeblade.PrintRangedStats();
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine();
                Edgeblade.PrintMeleeStats();
                Console.WriteLine();

            }

            Console.ReadLine();
            Console.Clear();
            AnsiConsole.MarkupLine("[italic blue]Aric[/][seagreen3] hands you a quest note urging you to find an elven camp in [/][green]Eldoria.[/]");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[seagreen3]They hold vital info about your weapon, the [/][yellow]EdgeBlade.[/]");
            Console.WriteLine();
            AnsiConsole.MarkupLine("[seagreen3]Ready to uncover secrets?[/]");
            Console.WriteLine();
            Console.Clear();
            TextPos.Center($"{Textcolor.HeaderText("Heading where?")}");
            string Encounter1 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"[seagreen3]The note that[/][italic blue] Aric [/][seagreen3]handed you says to head north for 3 kilometers to find the elf camp[/]")
                    .PageSize(3)
                    .AddChoices(new[] {
                        "[red]No thanks, I would rather die than find out...[/]","[green]Im in! I will head there as soon as possible![/]"
                    }));
            if (Encounter1 == "[red]No thanks, I would rather die than find out...[/]")
            {
                AnsiConsole.Clear();
                AnsiConsole.MarkupLine("[seagreen3]You go home and [/][italic blue]Aric[/][seagreen3] is disappointed...[/]");
                Console.ReadLine();
                Environment.Exit(0);

            }
            AttackEncounter(player, playerinventory);
            Console.Clear();
            Console.ReadLine();
        }
        public void AttackEncounter(Player player, Inventory playerinventory)
        {
            Console.Clear();
            TextPos.Center($"{Textcolor.HeaderText("Under Attack!")}");
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("As you start your little journey to the camp you walk into a dark forest.")}");
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("You follow the path which leads to the elven camp for your quest...")}");
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("When following the path you hear footsteps coming closer and closer")}");
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("Before you know it there is a duo of ")}{Textcolor.RogueText("Glowblins")}{Textcolor.NormalText("standing infront of you!")}");
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("You try to talk to them by offering them peace")}");
            AnsiConsole.MarkupLine($"{Textcolor.NormalText("The Glowblins ignore you and demand you to give your shiny sword.")}");

            string Attack1 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Gorlock starts running towards you in an attempt to attack you and steal all of your valuables")
                .PageSize(3)
                .AddChoices(new[] {
                    "Flee","Fight back"
                }));

            if (Attack1 == "Fight back")
            {
                Console.Clear();
                bool isFighting = true;
                TextPos.Center($"{Textcolor.HeaderText($">|[orange3]Battle![/]| [red]Target[/] : {Textcolor.EnemyText(Goblin1.name)} [darkred]Health[/] :[darkred] {Goblin1.health}[/]|<")}");
                while (Goblin1.health > 0 && Goblin2.health > 0 && isFighting == true)
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
                        AnsiConsole.MarkupLine($"{Textcolor.NormalText("As ")}[green]Bingus[/]{Textcolor.NormalText("the goblin watches as you hit his companion. He falls down and dies")}");
                        AnsiConsole.MarkupLine($".{Textcolor.EnemyText("Bingus")}{Textcolor.NormalText("the goblin charges at you with rage")}");
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
                                player.Dodge(Goblin2, player);
                                break;
                            case "Attack":
                                Console.Clear();
                                TextPos.Center($"{Textcolor.HeaderText($">|[orange3]Battle![/]| [red]Target[/] : {Textcolor.EnemyText(Goblin2.name)} [darkred]Health[/] :[darkred] {Goblin2.health}[/]|<")}");
                                Goblin2.TakeDamage(player);
                                break;

                        }
                        string playerchoice2 = AnsiConsole.Prompt(
                            new SelectionPrompt<string>()
                                .Title($"{Textcolor.NormalText("You stand face to face with")}{Textcolor.EnemyText(Goblin2.name)}{Textcolor.NormalText("You try to negotiate about keeping peace but")}{Textcolor.EnemyText(Goblin2.name)}{Textcolor.NormalText("denies and tries to go in for an attack, ")}" +
                                       $"{Textcolor.NormalText("so the only option you have is to end this fight by swinging your ")}{Textcolor.WeaponText(Edgeblade.name)}{Textcolor.NormalText("at the enemy")}")
                                .PageSize(3)
                                .AddChoices(new[] {
                                    "Attack",""
                                }));

                        if (playerchoice2 == "Attack")
                        {
                            Goblin2.TakeDamage(player);
                        }
                    }
                }

                isFighting = false;
                AnsiConsole.MarkupLine("");
                Console.ReadLine();
                player.GainExperience(100);

            }
            if (Attack1 == "Flee")
            {
                AnsiConsole.MarkupLine($"{Textcolor.NormalText("You've chosen to flee from the scene to try and outrun the")}{Textcolor.RogueText("Glowblins")}{Textcolor.NormalText("and escape")}");
            }

            if (player.health == 0)
            {
                Console.WriteLine("death");
            }
            Console.ReadLine();
            MissionEncounter(player);
        }

        void MissionEncounter(Player player)
        {
            AnsiConsole.Clear();
            TextPos.Center($"{Textcolor.HeaderText("Mission")}");
            AnsiConsole.MarkupLine("After that battle you can finally continue your adventure to the Elven Camp");
            AnsiConsole.MarkupLine("You succesfully reached the camp and look around for someone to talk to...");
            AnsiConsole.MarkupLine("You see a strange looking Elf standing there, he looks like he has been through a lot");
            AnsiConsole.MarkupLine("You walk up to the elf he looks at you with a confused look on his face");

            string playerChoice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What do you want to do?")
                    .PageSize(3)
                    .AddChoices(new[]
                    {
                        "Introduce yourself.",
                        "Ask about the Elven Camp.",
                        "Offer assistance."
                    }));
            switch (playerChoice)
            {
                case "Introduce yourself.":
                    Introduction(player);
                    break;
                case "Ask about the Elven Camp.":
                    Camp(player);
                    break;
                case "Offer assistance":
                    //minigame.PlayScrambleGame();
                    break;
            }
            Console.ReadLine();
        }

        public void Introduction(Player player)
        {
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine($"You introduce yourself to the elf as {player.name}, a {player.role} on a quest.");
            AnsiConsole.MarkupLine("The elf, Legolos, welcomes you and then presents you with a challenge:");
            Console.ReadLine();
            ScrambleGame(player);
            Camp(player);

        }
        public string Scramble(string word)
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

            AnsiConsole.MarkupLine("This is the word : " + new string(chars));
            return new string(chars);
        }

        public bool isCorrect;
        public void ScrambleGame(Player player)
        {
            AnsiConsole.MarkupLine("I entrust you with a vital mission: decipher a key word that unlocks access to an enemy base, where my friend is currently held captive.");
            AnsiConsole.MarkupLine("The word you need to decrypt is crucial for freeing my friend.");
            AnsiConsole.MarkupLine("Generous rewards await you upon the successful completion of this mission.");
            Minigame.Scramble("Trapped");
            AnsiConsole.WriteLine();

            isCorrect = false;

            while (!isCorrect)
            {
                TextPos.Center("Scramble");
                string word = AnsiConsole.Prompt(new TextPrompt<string>("")
                    .PromptStyle("seagreen3"));

                if (word == "Trapped")
                {
                    isCorrect = true;
                    Console.Clear();
                    AnsiConsole.MarkupLine("[green]Correct[/]");
                    AnsiConsole.WriteLine();

                }
                else
                {
                    Console.Clear();
                    AnsiConsole.MarkupLine("[red]Nu uh[/]");
                    AnsiConsole.WriteLine();
                }
            }
        }
        public void Camp(Player player)
        {
            if (isCorrect)
            {
                AnsiConsole.MarkupLine(Textcolor.NormalText("Thanks for solving my puzzle!"));
                AnsiConsole.MarkupLine(Textcolor.NormalText("I couldn't have done it without you."));
                AnsiConsole.MarkupLine(Textcolor.NormalText("Now that we know the code, I can help my trapped friend in the enemy base and return him to safety here in our camp"));
                AnsiConsole.MarkupLine(Textcolor.NormalText("I want you to travel south from here. Find the base and kill any foe standing in your way."));
            }
            if (!isCorrect)
            {
                AnsiConsole.MarkupLine(Textcolor.NameText($"Legolas {Textcolor.NormalText("Welcomes you to the camp")}"));
                AnsiConsole.MarkupLine($"{Textcolor.NormalText($"{Textcolor.NormalText(($"Ive got a big problem and I need your help {Textcolor.NameText(player.name)}"))}")}");
                AnsiConsole.MarkupLine(Textcolor.NormalText("I need you to help my trapped friend in the enemy base and return him to safety here in our camp"));
                AnsiConsole.MarkupLine(Textcolor.NormalText("I want you to travel south from here. Find the base and kill any foe standing in your way."));
            }
            Console.ReadLine();
            EnteringBase(player);
        }
        public void EnteringBase(Player player)
        {
            AnsiConsole.MarkupLine(Textcolor.NormalText("As you got your quest to rescue Legolas's friend you head south to find the enemy base."));
            AnsiConsole.MarkupLine(Textcolor.NormalText("You get closer to your destination and see a massive prison with one gate infront of you"));
            AnsiConsole.MarkupLine(Textcolor.NormalText("You try to sneak through a hole in the fence next to the gate to get inside the base,"));
            AnsiConsole.MarkupLine(Textcolor.NormalText("but while you are going through the hole you hear heavy footsteps coming towards you"));
            AnsiConsole.MarkupLine(Textcolor.NormalText($"You look up and you stand face to face with a big {Textcolor.EnemyText("Cyborg")}"));
            AnsiConsole.MarkupLine(Textcolor.NormalText($"The {Textcolor.EnemyText("Cyborg")} looks at your in your eyes"));
            AnsiConsole.MarkupLine(Textcolor.NormalText($"He tells you that he could kill you right now unless you solve his riddles"));
            AnsiConsole.MarkupLine("");


            string question = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("")
                    .PageSize(3)
                    .AddChoices(new[]
                        {
                            "Accept the offer","Decline the offer"
                        }
                    ));
                if (question == "Accept the offer")
            {
                Console.Clear();
                AnsiConsole.MarkupLine($"You have accepted the offer and the {Textcolor.EnemyText("Cyborg")} starts to read his riddles.");
                Riddle(player);
            }
            if (question == "Decline the offer")
            {
                Console.Clear();
                AnsiConsole.MarkupLine("You Decline the offer");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        bool riddlesCompleted = false;
        public void Riddle(Player player)
        {
            while (!riddlesCompleted)
            {
                Console.Clear();
                AnsiConsole.MarkupLine("I dance with flames and flow with grace,");
                AnsiConsole.MarkupLine("A force of nature, in every place.");
                AnsiConsole.MarkupLine("Born of heat, my power is vast,");
                AnsiConsole.MarkupLine("Guess my name, break the spell, and be fast.");
                AnsiConsole.MarkupLine("What am I?");
                string riddle1 = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("")
                        .PageSize(3)
                        .AddChoices(new[]
                            {
                                "Lava","Fire","Magma"
                            }
                        ));

                if (riddle1 == "Lava")
                {
                    AnsiConsole.MarkupLine("[red]False[/]");
                    player.TakeDamage(30);
                    Console.ReadLine();
                }
                if (riddle1 == "Fire")
                {
                    riddlesCompleted = true;
                    AnsiConsole.MarkupLine("[green]You got that right.[/]");
                    Console.ReadLine();
                }
                if(riddle1 == "Magma")
                {
                    AnsiConsole.MarkupLine("[red]False[/]");
                    //player.TakeDamage();
                    Console.ReadLine();
                }
            }
            AnsiConsole.MarkupLine("Yes");
            Console.ReadLine();
        }
    }
}

