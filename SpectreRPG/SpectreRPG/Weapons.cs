using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectreRPG
{
    public class Weapons
    {
        public string name;
        public int damage;
        public int accuracy;
        public int skillReq;
        public int maxAmmo;
        public int crit;
        public int hitChance;



        public Weapons(string name,int damage,int accuracy, int skillReq, int maxAmmo, int crit,int hitChance)
        {
            this.name = name;
            this.damage = damage;
            this.accuracy = accuracy;
            this.skillReq = skillReq;
            this.maxAmmo = maxAmmo;
            this.crit = crit;
            this.hitChance = hitChance;
        }

        public void PrintMeleeStats()
        {
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[yellow1]Weapon[/] : {name}");
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[red3]Damage[/] : {damage}");
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[slateblue1]Skill Requirement[/] : {skillReq}");
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[yellow]Critical Chance[/] : {crit}%");
        }

        public void PrintRangedStats()
        {
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[yellow1]Weapon[/] : {name}");
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[red3]Damage[/] : {damage}");
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[slateblue1]Skill Requirement[/] : {skillReq}");
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[yellow]Critical Chance[/] : {crit}%");
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[green1]Hit Chance[/] : {hitChance}");
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[cyan1]Accuracy[/] :  {accuracy}");
            AnsiConsole.WriteLine();
            AnsiConsole.Markup($"[lightslategrey]Maximum Ammunition[/] :  {maxAmmo}");
        }

        

    }
}
