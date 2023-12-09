using System.Linq.Expressions;
using Spectre.Console;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Spectre.Console.Advanced;
using Spectre.Console.Extensions;
using Spectre.Console.Rendering;
using System.Xml.Linq;

namespace SpectreRPG

{
    public class Program
    {
        public static Panel _panel = new Panel("                       RPG");
        public static Player _player;
        static void Main(string[] args)
        {
            _panel.Border = BoxBorder.Square;
            _panel.Expand = true;
            AnsiConsole.Render(_panel);
            

            InputPlayerInfo();
        }
        public static void InputPlayerInfo()
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
                _player = new Player(name, 120, 8, "Warrior", 0);
                AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold grey27]{roles}[/]"));
                _player.ShowStats();
            }
           
            if (roles == "[bold chartreuse3]Archer[/]")
            {
                _player = new Player(name, 100, 5, "Archer", 0);
                AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold chartreuse3]{roles}[/]"));
                _player.ShowStats();
            }

            if (roles == "[bold blueviolet]Mage[/]")
            {
                _player = new Player(name, 75, 10, "Mage", 0);
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
            Game game = new Game();
            game.game();
            
            
            
            
            
            
        }
    }
}