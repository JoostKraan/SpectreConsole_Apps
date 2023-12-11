using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace SpectreRPG
{
    public class Encounters
    {
        
        public void StartingEncounter(Player player)
        {
            AnsiConsole.Clear();
            AnsiConsole.Markup($"[seagreen3]As [/][italic blue]{player._name}[/][seagreen3] steps into the cave, a small, shadowy figure catches their eye sitting on a boulder...[/]");
            AnsiConsole.Markup($"[seagreen3]The mysterious creature is engrossed in a task, producing a high-pitched metallic sound.[/]");
            AnsiConsole.Markup($"[seagreen3]Approaching cautiously, [/][italic blue]{player._name}[/][seagreen3] realizes the figure is a hideous looking [/][darkgreen]Goblin[/][seagreen3] meticulously counting stolen coins from innocent wanderers in the forest.[/]");
            AnsiConsole.Markup("");
        }


    }
}
