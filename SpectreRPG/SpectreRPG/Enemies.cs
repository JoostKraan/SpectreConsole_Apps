using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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
        public string _name;
        public int _health;
        public int _atk;
        public int _defense;
        public int _level;
        public int _crit;

        
        public Enemies(string name, int health, int atk, int defense, int level, int crit)
        {
            _name = name;
            _health = health;
            _atk = atk;
            _defense = defense;
            _level = level;
            _crit = crit;
        
        }
        
    }


}
