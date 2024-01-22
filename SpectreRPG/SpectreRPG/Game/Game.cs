using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using SpectreRPG.Automation;

namespace SpectreRPG.Game
{
    public class Game
    {
        public Encounters encounters = new Encounters();
        public Player player;
        public string InputPlayerName()
        {
            TextPos.Center($"{Textcolor.NormalText("What is your Name?")}");
            return AnsiConsole.Prompt(new TextPrompt<string>("")
                .PromptStyle("italic blue"));
        }
        public string InputRace()
        {
            TextPos.Center($"{Textcolor.NormalText("What is your Race")}");
            return AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("")
                    .PageSize(4)
                    .AddChoices(new[] {
                        "[bold grey27]Black[/]","[bold blueviolet]White[/]","[bold chartreuse3]Bald[/]","> [underline red]Back[/]"
                    }));
            Console.Clear();
        }
        public string InputClass()
        {
            TextPos.Center($"{Textcolor.NormalText("What is your Class?")}");
            return AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("")
                    .PageSize(4)
                    .AddChoices(new[] {
                        "[bold grey27]Titan[/]","[bold blueviolet]Warlock[/]","[bold chartreuse3]Rogue[/]","> [underline red]Back[/]"
                    }));
            Console.Clear();
        }
        public void InputPlayerInfo()
        {
            string name = InputPlayerName();
            Console.Clear();
            string roles = InputClass();
            Console.Clear();
            string race = InputRace();

            switch (roles)
            {
                case Roles.Titan:
                    TextPos.CenterText();
                    player = new Player(name, 12, 5, $"[bold grey27]Titan[/]", 0, 0, 2, 1, 0, new Inventory(), race);
                    AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold grey27]{roles}[/]"));
                    player.ShowStats();
                    break;
                case Roles.Rogue:
                    player = new Player(name, 10, 3, "[bold chartreuse3]Rogue[/]", 0, 0, 5, 1, 0, new Inventory(), race);
                    AnsiConsole.Write(new Markup($"{Textcolor.NormalText("You chose")}{Textcolor.RogueText(roles)}"));
                    player.ShowStats();
                    break;
                case Roles.Warlock:
                    player = new Player(name, 8, 8, "[bold blueviolet]Warlock[/]", 0, 0, 3, 1, 0, new Inventory(), race);
                    AnsiConsole.Write(new Markup($"{Textcolor.NormalText("You chose")}{Textcolor.WarlockText(roles)}"));
                    player.ShowStats();
                    break;
                case Roles.Back:
                    Console.Clear();
                    InputPlayerInfo();
                    break;
            }
            Console.ReadLine();
            encounters.StartingEncounter(player);
        }
    }
}

