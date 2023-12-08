using Spectre.Console;
using System.Net.Http.Headers;
using Spectre.Console.Advanced;
using Spectre.Console.Extensions;
using Spectre.Console.Rendering;

namespace SpectreRPG

{
    public class Program
    {
        static void Main(string[] args)
        {
            ChooseRole();
        }
        public static  void ChooseRole()
        {
            var rule = new Rule("[yellow]Hello[/]"); 

            var roles = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("What is your class going to be?")
                    .PageSize(3)
                    .MoreChoicesText("[Orange] (Move up and down")
                    .AddChoices(new[] {
                        "Warrior", "Mage", "Archer"
                    }));
            AnsiConsole.Write(new Markup($"[seagreen3]You chose [/][bold red]{roles}[/]"));
            Console.ReadLine();
        }
    }
}