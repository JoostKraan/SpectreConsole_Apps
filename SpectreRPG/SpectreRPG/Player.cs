using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using System.Net.Http.Headers;
using Spectre.Console.Advanced;
using Spectre.Console.Extensions;
using Spectre.Console.Rendering;

namespace SpectreRPG
{
    public class Player
    {
        public string name;
        public int health;
        public int strength;
        private int defense;
        public string role;
        private int Experience;
        public int dodge;
        private Inventory playerInventory;
        
        public Player(string name, int health, int strength, string role, int Experience, int defense)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
            this.role = role;
            this.Experience = Experience;
            this.defense = defense;
            this.dodge = dodge;
            this.playerInventory = new Inventory();


        }

        public void ShowStats()
        {
            AnsiConsole.Markup("[seagreen3] Showing stats[/]");
            Console.WriteLine();
            Console.WriteLine();
            if (role == "[bold grey27]Titan[/]")
            {
                AnsiConsole.Markup($"[seagreen3]As an [/][bold grey27]{role}[/][seagreen3] these are your stats currently[/]");
            }

            if (role == "[bold chartreuse3]Rogue[/]")
            {
                
                AnsiConsole.Markup($"[seagreen3]As an [/][bold chartreuse3]{role}[/][seagreen3] these are your stats currently[/]");
            }

            if (role == "[bold blueviolet]Warlock[/]")
            {
                
                AnsiConsole.Markup($"[seagreen3]As an [/][bold purple3]{role}[/][seagreen3] these are your stats currently[/]");
            }
            Console.WriteLine();
            AnsiConsole.Markup($"[green4]HP[/] : {health}");
            Console.WriteLine();
            AnsiConsole.Markup($"[red3]Strenght[/] : {strength}"); 
            Console.WriteLine();
            AnsiConsole.Markup($"[grey50]Defense[/] : {defense}");
            Console.WriteLine();
            AnsiConsole.Markup($"[blueviolet]XP[/] : {Experience}");
            Console.WriteLine();
            AnsiConsole.Markup($"[orange4]Dodge[/] : {dodge}");
            Console.WriteLine();

        }

        public void addToInventory(Weapons weapons)
        {
            this.playerInventory.AddWeapons(weapons);
        }
    }
}
