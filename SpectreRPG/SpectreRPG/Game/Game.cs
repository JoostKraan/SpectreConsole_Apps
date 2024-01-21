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
        public Player _player;
        private bool PlayerIsNotDeath = true;
        
        public void InputPlayerInfo()
        {
            TextPos.Center($"{Textcolor.NormalText("What is your name?")}");

            string name = AnsiConsole.Prompt(new TextPrompt<string>("")
                .PromptStyle("italic blue"));
            AnsiConsole.Clear();
            TextPos.Center($"{Textcolor.NormalText("Class Selection...")}");
            TextPos.CenterText();
            AnsiConsole.Markup($"{Textcolor.NormalText($"Well,")}{Textcolor.NameText(name)}{Textcolor.NormalText("What is your class going to be?")}");
            string roles = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("")
                    .PageSize(4)
                    .AddChoices(new[] {
                        "[bold grey27]Titan[/]","[bold blueviolet]Warlock[/]","[bold chartreuse3]Rogue[/]","> [underline red]Back[/]"
                    }));
            if (roles == "[bold grey27]Titan[/]")
            {
                TextPos.CenterText();
                _player = new Player(name, 120, 5, $"[bold grey27]Titan[/]", 0, 0, 2, 1, 0, new Inventory());
                AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold grey27]{roles}[/]"));
                _player.ShowStats();
            }

            if (roles == "[bold chartreuse3]Rogue[/]")
            {
                _player = new Player(name, 100, 3, "[bold chartreuse3]Rogue[/]", 0, 0, 5, 1, 0,new Inventory());
                AnsiConsole.Write(new Markup($"{Textcolor.NormalText("You chose")}{Textcolor.RogueText(roles)}"));
                _player.ShowStats();
            }

            if (roles == "[bold blueviolet]Warlock[/]")
            {
                _player = new Player(name, 75, 8, "[bold blueviolet]Warlock[/]", 0, 0, 3, 1, 0, new Inventory());
                AnsiConsole.Write(new Markup($"{Textcolor.NormalText("You chose")}{Textcolor.WarlockText(roles)}"));
                _player.ShowStats();
            }

            if (roles == "> [underline red]Back[/]")
            {
                Console.Clear();
                InputPlayerInfo();
            }
            Console.WriteLine();
            Console.ReadLine();
            AnsiConsole.Clear();

           encounters.StartingEncounter(_player);

        }
    }


}

