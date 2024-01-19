using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace SpectreRPG.Game
{
    public class Inventory
    {
        private List<Weapons> weaponslist;

        public Inventory()
        {
            weaponslist = new List<Weapons>();
        }

        public void AddWeapons(Weapons weapon)
        {
            weaponslist.Add(weapon);
        }

        public void RemoveWeapons(Weapons weapon)
        {
            weaponslist.Remove(weapon);
        }
        public void ShowInventory()
        {
            Console.WriteLine();
            AnsiConsole.Markup("[seagreen3]Items in Inventory...[/]");
            Console.WriteLine();
            foreach (var weapon in weaponslist)
            {
                Console.WriteLine();
                AnsiConsole.Markup($"[seagreen3]Weapon[/] :[yellow] {weapon.name}[/]");

            }
        }


    }
}
