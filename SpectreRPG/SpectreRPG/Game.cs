using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
        private Boolean PlayerIsNotDeath = true;
        public void Start()
        {
            InputPlayerInfo();
          
            Console.ReadLine();
        }

        public void InputPlayerInfo()
        {
            string name = AnsiConsole.Prompt(new TextPrompt<string>($"{Textcolor.NormalText("What's your")}" +
                                                                    $"{Textcolor.NameText("name?")}")
                .PromptStyle("italic blue"));
            AnsiConsole.Clear();
            var roles = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title($"{Textcolor.NormalText($"Well")}{Textcolor.NameText(name)}{Textcolor.NormalText("What is your class going to be?")}")
                    .PageSize(4)
                    .AddChoices(new[] {
                        "[bold grey27]Titan[/]","[bold blueviolet]Warlock[/]","[bold chartreuse3]Rogue[/]","> [underline red]Back[/]"
                    }));
            if (roles == "[bold grey27]Titan[/]")
            {
                _player = new Player(name, 120, 5, $"Titan[/]", 0, 0,2,1,0);
                AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold grey27]{roles}[/]"));
                _player.ShowStats();
            }

            if (roles == "[bold chartreuse3]Rogue[/]")
            {
                _player = new Player(name, 100, 3, "[bold chartreuse3]Rogue[/]", 0, 0,5,1,0);
                AnsiConsole.Write(new Markup($"{Textcolor.NormalText("You chose")}{Textcolor.RogueText(roles)}"));
                _player.ShowStats();
            }

            if (roles == "[bold blueviolet]Warlock[/]")
            {
                _player = new Player(name, 75, 8, "[bold blueviolet]Warlock[/]", 0, 0,3,1,0);
                AnsiConsole.Write(new Markup($"{Textcolor.NormalText("You chose")}{Textcolor.WarlockText(roles)}"));
                _player.ShowStats();
            }

            if (roles == "> [underline red]Back[/]")
            {
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

