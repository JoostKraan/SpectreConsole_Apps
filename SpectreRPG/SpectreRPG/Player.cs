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
        public string _name;
        public string _color;
        private int _health;
        private int _atk;
        private int _crit;
        private int _defense;
        public string _role;
        private int _Experience;

        public Player(string name, int health, int damage, string role, int Experience, int crit, int defense, string color)
        {
            _name = name;
            _health = health;
            _atk = damage;
            _role = role;
            _Experience = Experience;
            _crit = crit;
            _defense = defense;
            _color = color;
            
        }

        public string  ReturnRolecolor()
        {
            return _color;
        }

        public void ShowStats()
        {
            Console.WriteLine();
            Console.WriteLine();
            if (_role == "Warrior")
            {
                _color = "[bold grey27]";
                AnsiConsole.Markup($"[seagreen3]As an [/][bold grey27]{_role}[/][seagreen3] these are your stats...[/]");
            }

            if (_role == "Archer")
            {
                _color = "[bold chartreuse3]";
                AnsiConsole.Markup($"[seagreen3]As an [/][bold chartreuse3]{_role}[/][seagreen3] these are your stats...[/]");
            }

            if (_role == "Mage")
            {
                _color = "[bold blueviolet]";
                AnsiConsole.Markup($"[seagreen3]As an [/][bold purple3]{_role}[/][seagreen3] these are your stats...[/]");
            }
            Console.WriteLine();
            AnsiConsole.Markup($"[red3]Damage[/] : {_atk}");
            Console.WriteLine();
            AnsiConsole.Markup($"[green4]HP[/] : {_health}");
            Console.WriteLine();
            AnsiConsole.Markup($"[blueviolet]XP[/] : {_Experience}");
        }
    }
}
