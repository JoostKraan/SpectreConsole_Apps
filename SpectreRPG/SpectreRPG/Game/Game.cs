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
        public void Start()
        {
            //Tables.CreateTable("Stats","Value","HP","100","Strengt","10","Defense","2","XP","100","Dodge","2");
            
            InputPlayerInfo();

            Console.ReadLine();
        }

        public void InputPlayerInfo()
        {
            TextPos.Center($"{Textcolor.NormalText("What is your name?")}");
            string name = AnsiConsole.Prompt(new TextPrompt<string>("")
                .PromptStyle("italic blue"));
            AnsiConsole.Clear();
            TextPos.Center($"{Textcolor.NormalText("Class Selection...")}");
            AnsiConsole.WriteLine();
            var roles = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Textcolor.NormalText($"Well,")}{Textcolor.NameText(name)}{Textcolor.NormalText("What is your class going to be?")}")
                    .PageSize(4)
                    .AddChoices(new[] {
                        "[bold grey27]Titan[/]","[bold blueviolet]Warlock[/]","[bold chartreuse3]Rogue[/]","> [underline red]Back[/]"
                    }));
            if (roles == "[bold grey27]Titan[/]")
            {
                _player = new Player(name, 120, 5, $"Titan[/]", 0, 0, 2, 1, 0);
                AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold grey27]{roles}[/]"));
                _player.ShowStats();
            }

            if (roles == "[bold chartreuse3]Rogue[/]")
            {
                _player = new Player(name, 100, 3, "[bold chartreuse3]Rogue[/]", 0, 0, 5, 1, 0);
                AnsiConsole.Write(new Markup($"{Textcolor.NormalText("You chose")}{Textcolor.RogueText(roles)}"));
                _player.ShowStats();
            }

            if (roles == "[bold blueviolet]Warlock[/]")
            {
                _player = new Player(name, 75, 8, "[bold blueviolet]Warlock[/]", 0, 0, 3, 1, 0);
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

            while (PlayerIsNotDeath)
            {
                encounters.StartingEncounter(_player);
            }

        }

        public Player HijIsNaarDeHemel(Player play)
        {
            PlayerIsNotDeath = false;
            return play;
        }
    }


}

