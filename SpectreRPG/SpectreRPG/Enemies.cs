using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using Spectre.Console;

namespace SpectreRPG
{

    public class Enemies
    {
        
        //Enemy Art
        public SoundPlayer audio = new SoundPlayer(@"D:\Repositories\SpectreConsole_Apps\SpectreRPG\SpectreRPG\Audio\fart.wav");
        public string skeletonSprite = ("      .-.\r\n     (o.o)\r\n      |=|\r\n     __|__\r\n   //.=|=.\\\\\r\n  // .=|=. \\\\\r\n  \\\\ .=|=. //\r\n   \\\\(_=_)//\r\n    (:| |:)\r\n     || ||\r\n     () ()\r\n     || ||\r\n     || ||\r\nl42 ==' '==");
        public string banditSprite = ("                                                 \r\n                                                 \r\n                                                 \r\n                                                 \r\n                     \u2588\u2588\u2588\u2588\u2588                       \r\n                    \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588                     \r\n                   \u2588\u2588\u2588\u2593\u2593\u2592\u2593\u2593\u2588                     \r\n                 \u2588\u2588\u2588\u2588\u2588\u2593\u2592\u2593\u2593\u2593\u2588                     \r\n                    \u2588\u2588\u2588\u2588\u2588\u2588\u2588                      \r\n                  \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588                    \r\n                 \u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2593\u2588\u2588                   \r\n                 \u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2588\u2588\u2588\u2588\u2588                  \r\n                 \u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2593\u2593\u2588\u2588\u2588                  \r\n                 \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2588\u2588\u2588\u2588                  \r\n                 \u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2593\u2593\u2593\u2588\u2588\u2588                  \r\n                 \u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2593\u2593\u2593\u2588\u2588\u2588\u2588                  \r\n                  \u2588\u2588\u2588\u2593\u2588\u2588\u2593\u2593\u2588\u2588\u2588\u2588\u2588                  \r\n                  \u2588\u2588\u2588\u2588\u2593\u2588\u2588\u2593\u2593\u2588\u2588\u2588                   \r\n                   \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2588\u2588\u2588                   \r\n                    \u2588\u2588\u2588  \u2593\u2593\u2588                     \r\n                    \u2588\u2588\u2588  \u2588\u2588\u2588                     \r\n                   \u2588\u2588\u2588\u2588  \u2588\u2588\u2588\u2588                    \r\n                                                 \r\n                                                 \r\n                                                 \r\n                                                 ");
        public string spiderSprite = ("                            \r\n                            \r\n    \u2591\u2592\u2593\u2593\u2593\u2592\u2592\u2592\u2592\u2592\u2592\u2592\u2592\u2592\u2592\u2593\u2593\u2592\u2592\u2591    \r\n    \u2593\u2588\u2592\u2592\u2593\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2592\u2592\u2592\u2593\u2588    \r\n  \u2591\u2593\u2591\u2592\u2588\u2592\u2592\u2593\u2588\u2588\u2593\u2592\u2593\u2593\u2588\u2588\u2588\u2592\u2593\u2588\u2593\u2593\u2593\u2591  \r\n  \u2593\u2588\u2593\u2593\u2588\u2588\u2588\u2588\u2592\u2592\u2592\u2591\u2591\u2592\u2592\u2592\u2593\u2588\u2588\u2588\u2592\u2592\u2588\u2593  \r\n \u2591\u2592\u2592\u2593\u2588\u2588\u2588\u2588\u2593\u2593\u2592\u2592\u2592\u2592\u2592\u2592\u2593\u2593\u2588\u2588\u2588\u2588\u2593\u2592\u2591\u2591 \r\n  \u2593\u2588\u2588\u2593\u2592\u2593\u2588\u2588\u2593\u2593\u2593\u2592\u2592\u2592\u2593\u2593\u2588\u2588\u2593\u2592\u2593\u2588\u2588\u2593  \r\n  \u2593\u2588\u2592\u2592\u2593\u2592\u2592\u2592\u2593\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2592\u2592\u2592\u2593\u2592\u2592\u2588\u2593  \r\n \u2591\u2591\u2592\u2593\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2592\u2591\u2592\u2592\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2593\u2592\u2591\u2591 \r\n  \u2593\u2588\u2588\u2588\u2592\u2592\u2592\u2593\u2593\u2588\u2592\u2592\u2592\u2592\u2588\u2593\u2593\u2592\u2592\u2592\u2593\u2588\u2588\u2593  \r\n  \u2592\u2588\u2592\u2593\u2593\u2588\u2588\u2588\u2593\u2588\u2593\u2593\u2593\u2593\u2588\u2588\u2588\u2588\u2588\u2593\u2593\u2593\u2588\u2592  \r\n  \u2591\u2593\u2592\u2593\u2588\u2593\u2592\u2592\u2592\u2592\u2592\u2593\u2593\u2592\u2592\u2592\u2591\u2592\u2593\u2588\u2593\u2592\u2592\u2591  \r\n    \u2591\u2592\u2592              \u2592\u2592\u2592    \r\n                            ");


        //Stats
        public string name;
        public int health;
        public int atk;
        public int defense;
        public int level;
        public int critChance;


        public Enemies(string name, int health, int atk, int defense, int level, int critChance)
        {
            this.name = name;
            this.health = health;
            this.atk = atk;
            this.defense = defense;
            this.level = level;
            this.critChance = critChance;

        }
        public void TakeDamage(int health, int damage, int defense)
        {
            Random random = new Random();
            double critChance = 1 + (0.01 * )// TO DO, take values from player class

            double defenseReduction = 0.05 * defense;
            int damageTaken = (int) (damage - defenseReduction);
            damageTaken = Math.Max(damageTaken, 0);
            health -= damageTaken;

            AnsiConsole.Markup($"{name} took {damageTaken} damage. Current health: {health}");

        }


    }
}