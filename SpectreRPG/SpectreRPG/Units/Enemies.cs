﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Runtime.CompilerServices;
using Spectre.Console;
using SpectreRPG.Automation;

namespace SpectreRPG.Game
{

    public class Enemies
    {

        //Enemy Art
        //public SoundPlayer audio = new SoundPlayer(@"D:\Repositories\SpectreConsole_Apps\SpectreRPG\SpectreRPG\Audio\fart.wav");
        public string skeletonSprite = "      .-.\r\n     (o.o)\r\n      |=|\r\n     __|__\r\n   //.=|=.\\\\\r\n  // .=|=. \\\\\r\n  \\\\ .=|=. //\r\n   \\\\(_=_)//\r\n    (:| |:)\r\n     || ||\r\n     () ()\r\n     || ||\r\n     || ||\r\nl42 ==' '==";
        public string banditSprite = "                                                 \r\n                                                 \r\n                                                 \r\n                                                 \r\n                     \u2588\u2588\u2588\u2588\u2588                       \r\n                    \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588                     \r\n                   \u2588\u2588\u2588\u2593\u2593\u2592\u2593\u2593\u2588                     \r\n                 \u2588\u2588\u2588\u2588\u2588\u2593\u2592\u2593\u2593\u2593\u2588                     \r\n                    \u2588\u2588\u2588\u2588\u2588\u2588\u2588                      \r\n                  \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588                    \r\n                 \u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2593\u2588\u2588                   \r\n                 \u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2588\u2588\u2588\u2588\u2588                  \r\n                 \u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2593\u2593\u2588\u2588\u2588                  \r\n                 \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2588\u2588\u2588\u2588                  \r\n                 \u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2593\u2593\u2593\u2588\u2588\u2588                  \r\n                 \u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2593\u2593\u2588\u2588\u2588\u2588                  \r\n                  \u2588\u2588\u2588\u2593\u2588\u2588\u2593\u2593\u2588\u2588\u2588\u2588\u2588                  \r\n                  \u2588\u2588\u2588\u2588\u2593\u2588\u2588\u2593\u2593\u2588\u2588\u2588                   \r\n                   \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2588\u2588\u2588                   \r\n                    \u2588\u2588\u2588  \u2593\u2593\u2588                     \r\n                    \u2588\u2588\u2588  \u2588\u2588\u2588                     \r\n                   \u2588\u2588\u2588\u2588  \u2588\u2588\u2588\u2588                    \r\n                                                 \r\n                                                 \r\n                                                 \r\n                                                 ";
        public string spiderSprite = "                            \r\n                            \r\n    \u2591\u2592\u2593\u2593\u2593\u2592\u2592\u2592\u2592\u2592\u2592\u2592\u2592\u2592\u2592\u2593\u2593\u2592\u2592\u2591    \r\n    \u2593\u2588\u2592\u2592\u2593\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2592\u2592\u2592\u2593\u2588    \r\n  \u2591\u2593\u2591\u2592\u2588\u2592\u2592\u2593\u2588\u2588\u2593\u2592\u2593\u2593\u2588\u2588\u2588\u2592\u2593\u2588\u2593\u2593\u2593\u2591  \r\n  \u2593\u2588\u2593\u2593\u2588\u2588\u2588\u2588\u2592\u2592\u2592\u2591\u2591\u2592\u2592\u2592\u2593\u2588\u2588\u2588\u2592\u2592\u2588\u2593  \r\n \u2591\u2592\u2592\u2593\u2588\u2588\u2588\u2588\u2593\u2593\u2592\u2592\u2592\u2592\u2592\u2592\u2593\u2593\u2588\u2588\u2588\u2588\u2593\u2592\u2591\u2591 \r\n  \u2593\u2588\u2588\u2593\u2592\u2593\u2588\u2588\u2593\u2593\u2593\u2592\u2592\u2592\u2593\u2593\u2588\u2588\u2593\u2592\u2593\u2588\u2588\u2593  \r\n  \u2593\u2588\u2592\u2592\u2593\u2592\u2592\u2592\u2593\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2592\u2592\u2592\u2593\u2592\u2592\u2588\u2593  \r\n \u2591\u2591\u2592\u2593\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2592\u2591\u2592\u2592\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2592\u2591\u2591 \r\n  \u2593\u2588\u2588\u2588\u2592\u2592\u2592\u2593\u2593\u2588\u2592\u2592\u2592\u2592\u2588\u2593\u2593\u2592\u2592\u2592\u2593\u2588\u2588\u2593  \r\n  \u2592\u2588\u2592\u2593\u2593\u2588\u2588\u2588\u2593\u2588\u2593\u2593\u2593\u2593\u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2588\u2592  \r\n  \u2591\u2593\u2592\u2593\u2588\u2593\u2592\u2592\u2592\u2592\u2592\u2593\u2593\u2592\u2592\u2592\u2591\u2592\u2593\u2588\u2593\u2592\u2592\u2591  \r\n    \u2591\u2592\u2592              \u2592\u2592\u2592    \r\n                            ";


        //Stats
        public string name;
        public double health;
        public double atk;
        public int defense;
        public int level;
        public int critChance;


        public Enemies(string name, double health, double atk, int defense, int level, int critChance)
        {
            this.name = name;
            this.health = health;
            this.atk = atk;
            this.defense = defense;
            this.level = level;
            this.critChance = critChance;

        }
        public void TakeDamage(Player player)
        {
            Console.Clear();
            double critMultiplier = 1.15;
            double baseDamage = (int)(player.atk * (1.0 - defense * 0.01));
            bool isCriticalHit = new Random().Next(100) < player.critChance;
            if (isCriticalHit)
            {

                health -= baseDamage * critMultiplier;
            }
            else
            {
                atk = (int)baseDamage;
            }
            atk = Math.Max(atk, 1);
            double damageInt = atk;
           
            health -= damageInt;
            if (health <= 0)
            {   
                health = 0;
                Console.Clear();
                TextPos.Center($"{Textcolor.HeaderText($">|[orange3]Under Attack![/] | [red]Target[/] : {Textcolor.EnemyText(name)} [darkred]Health[/] :[darkred] {health}[/]|<")}");
                AnsiConsole.MarkupLine(Textcolor.NormalText($"The {Textcolor.NameText(name)} has been defeated!"));
            }

            
                if (isCriticalHit)
                {
                    AnsiConsole.MarkupLine(Textcolor.NormalText($"Critical Hit! The {Textcolor.NameText(name)} takes {Textcolor.EnemyText($"{damageInt}")} damage. Remainging health: {health}"));
                }
                else
                {
                    AnsiConsole.MarkupLine(Textcolor.NormalText($"The {name} takes {damageInt} damage. Remaining health {health}"));
                }
            
            //AnsiConsole.MarkupLine(Textcolor.NormalText($"you did {Textcolor.EnemyText($"{damageInt}")} damage"));
            if (health <= 0)
            {
                health = 0;
            }
        }



    }
}