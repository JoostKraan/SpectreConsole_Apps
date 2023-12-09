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
            

            PlayerInfo();
        }
        public static void PlayerInfo()
        {
            string name = AnsiConsole.Prompt(new TextPrompt<string>("[blue]What is your name[/]").PromptStyle("italic seagreen3"));
            var roles = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What is your class going to be?")
                    .PageSize(3)
                    .AddChoices(new[] {
                        "Warrior", "Mage", "Archer"
                    }));
            AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold red]{roles}[/]"));
            if (roles == "Warrior")
            {
                _player = new Player(name, 20, 15, "Warrior",0);
            }
            _player.ShowStats();
            
            
            
            AnsiConsole.WriteLine();
            Console.ReadLine();
        }
    }
}