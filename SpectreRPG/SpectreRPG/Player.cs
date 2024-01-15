
using Spectre.Console;
namespace SpectreRPG
{
   
    public class Player
    {
        public string name;
        private int XpToNextLevel = 100;
        public int health;
        public int atk;
        public int level;
        private int defense;
        public string role;
        public int experience;
        public int dodge;
        public int critChance;
       
        private Inventory playerInventory;

        public Player(string name, int health, int atk, string role, int experience, int defense, int critChance,
            int dodge, int level)
        {
            this.name = name;
            this.health = health;
            this.atk = atk;
            this.role = role;
            this.experience = experience;
            this.defense = defense;
            this.dodge = dodge;
            this.critChance = critChance;
            this.level = level;
            this.playerInventory = new Inventory();


        }

        public void TakeDamage(Enemies enemy)
        {
            double critmultiplier = 1.25;
            double baseDamage = enemy.atk * (1.0 - enemy.defense * 0.01);
            bool isCriticalHit = (new Random().Next(100) < this.critChance);
            double damage;

            if (isCriticalHit)
            {
                enemy.atk = baseDamage * critmultiplier;
            }
            else
            {
                enemy.atk = baseDamage;
            }
            damage = Math.Max(enemy.atk, 1);
            int damageInt = (int)damage;
            this.health -= damageInt;
            if (this.health <= 0)
            {

                Console.WriteLine($"You have been defeated by the {enemy.name}!");
            }
            else
            {

                if (isCriticalHit)
                {
                    Console.WriteLine($"Critical Hit! You take {damageInt} damage. Remaining health: {this.health}");
                }
                else
                {
                    Console.WriteLine($"You take {damageInt} damage. Remaining health: {this.health}");
                }
            }
        }

        public void ShowStats()
        {
            AnsiConsole.Markup($"{Textcolor.NormalText("Showing stats....")}");
            Console.WriteLine();
            Console.WriteLine();
            if (role == "[bold grey27]Titan[/]")
            {
                AnsiConsole.Markup(
                    $"{Textcolor.NormalText("As a")}{Textcolor.TitanText(role)}{Textcolor.NormalText("these are your stats currently")}");
            }

            if (role == "[bold chartreuse3]Rogue[/]")
            {

                AnsiConsole.Markup(
                    $"{Textcolor.NormalText("As a")}{Textcolor.RogueText(role)}{Textcolor.NormalText("these are your stats currently")}");
            }

            if (role == "[bold blueviolet]Warlock[/]")
            {

                AnsiConsole.Markup(
                    $"{Textcolor.NormalText("As a")}{Textcolor.WarlockText($"{role}")}{Textcolor.NormalText("these are your stats currently")}");
            }

            Console.WriteLine();
            AnsiConsole.Markup($"[green4]HP[/] : {health}");
            Console.WriteLine();
            AnsiConsole.Markup($"[red3]Strenght[/] : {atk}");
            Console.WriteLine();
            AnsiConsole.Markup($"[grey50]Defense[/] : {defense}");
            Console.WriteLine();
            AnsiConsole.Markup($"[blueviolet]XP[/] : {experience}");
            Console.WriteLine();
            AnsiConsole.Markup($"[orange4]Dodge[/] : {dodge}");
            Console.WriteLine();

        }

        public void addToInventory(Weapons weapons)
        {
            atk += weapons.damage;
            this.playerInventory.AddWeapons(weapons);
        }

        public void TakeDamage(int _damage)
        {
            health -= _damage;
        }

        public void GainExperience(int amount)
        {
            experience += amount;
            Console.WriteLine();
            AnsiConsole.Markup($"Gained {amount} experience points!");
            if (experience >= XpToNextLevel)
            {
                LevelUp();
            }

        }

        public void LevelUp()
        {
            {
                level++;
                Console.WriteLine();
                AnsiConsole.Markup($"Congratulations! you have reached level {level}");
                int remainingExperience = Math.Max(0, experience - XpToNextLevel);
                experience -= XpToNextLevel;
                XpToNextLevel = (int)(XpToNextLevel * 1.25);
                Console.WriteLine();
                AnsiConsole.Markup($"Experience required for the next level: {XpToNextLevel}, Current experience : {remainingExperience}");
            }
        }
    }
}