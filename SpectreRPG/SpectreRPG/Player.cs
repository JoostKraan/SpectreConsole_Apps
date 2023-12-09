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
        private int _health;
        private int _atk;
        private string _role;
        private int _Experience;


        public Player(string name,int health, int damage, string role, int Experience)
        {
            _name = name;
            _health = health;
            _atk = damage;
            _role = role;
            _Experience = Experience;
        }

        public void ShowStats()
        {
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine($"As a {_role} these are your stats...");
            
            AnsiConsole.WriteLine($"Your stats : {_name}");
            AnsiConsole.WriteLine($"Your Damage : {_atk}");
            AnsiConsole.WriteLine($"Your HP : {_health}");
            AnsiConsole.WriteLine($"Your XP : {_Experience}");
        }





    }
}
