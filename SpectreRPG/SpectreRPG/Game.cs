using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace SpectreRPG
{
    public class Game
    {
        public Encounters encounters = new Encounters();
        public Player _player;
        public void Start()
        {
            InputPlayerInfo();
            GameArea();
            Console.ReadLine();
        }

        public void InputPlayerInfo()
        {
            string name = AnsiConsole.Prompt(new TextPrompt<string>("[seagreen3]What is your[/][bold blue] name[/]").PromptStyle("italic blue"));
            AnsiConsole.Clear();
            var roles = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"[seagreen3]Well... {name} , What is your class going to be?[/]")
                    .PageSize(4)
                    .AddChoices(new[] {
                        "[bold grey27]Warrior[/]","[bold blueviolet]Mage[/]","[bold chartreuse3]Archer[/]","> [underline red]Back[/]"
                    }));
            if (roles == "[bold grey27]Warrior[/]")
            {
                _player = new Player(name, 120, 8, "[bold grey27]Warrior[/]", 0, 0, 0);
                AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold grey27]{roles}[/]"));
                _player.ShowStats();
            }

            if (roles == "[bold chartreuse3]Archer[/]")
            {
                _player = new Player(name, 100, 5, "[bold chartreuse3]Archer[/]", 0, 0, 0);
                AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold chartreuse3]{roles}[/]"));
                _player.ShowStats();
            }

            if (roles == "[bold blueviolet]Mage[/]")
            {
                _player = new Player(name, 75, 10, "[bold blueviolet]Mage[/]", 0, 0, 0);
                AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold blueviolet]{roles}[/]"));
                _player.ShowStats();
            }

            if (roles == "> [underline red]Back[/]")
            {
                InputPlayerInfo();
            }
            Console.WriteLine();
            Console.ReadLine();
            AnsiConsole.Clear();
        }
        public void GameArea()
        {
            AnsiConsole.Clear();
            AnsiConsole.Markup($"[seagreen3]As[/][italic blue] {_player._name}[/] [seagreen3]the [/]{_player._role}[seagreen3] awakens in the heart of an ancient forest on a misty morning, the whispers of a forgotten past beckon you towards a cave's entrance.[/]");
            AnsiConsole.Markup("[seagreen3]Surrounding you are towering trees and a thick, mysterious mist that cloaks the landscape.[/]");
            AnsiConsole.Markup("[seagreen3]Rising from a bed of moss, you feel an inexplicable connection to this mystical environment.[/]");
            AnsiConsole.Markup("[seagreen3]The air is heavy with anticipation as you step into the darkness, guided by spectral voices that seem to call out specifically to you.[/]");
            AnsiConsole.Markup("[seagreen3]Inside the cave, hidden chambers adorned with ancient symbols await your exploration.[/]");
            AnsiConsole.Markup("[seagreen3]The whispers intensify, and it becomes clear that your presence here is no accident but a convergence of fate.[/]");
            AnsiConsole.Markup($"[seagreen3]The choices made in the depths of this subterranean labyrinth,[/][italic blue] {_player._name}[/][seagreen3], will shape the course of your adventure and reveal the secrets intertwined with your destiny.[/]");
            Console.ReadLine();
            encounters.StartingEncounter(_player);

        }

        
    }
}
