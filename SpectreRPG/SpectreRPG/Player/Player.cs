
using Spectre.Console;
using SpectreRPG.Automation;
using SpectreRPG.Game;

namespace SpectreRPG.Game
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
        public Inventory inventory;
       

        public Player(string name, int health, int atk, string role, int experience, int defense, int critChance,
            int dodge, int level,Inventory inventory)
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
            this.inventory = inventory;


        }

        public void TakeDamage(Enemies enemy)
        {
            double critmultiplier = 1.25;
            double baseDamage = enemy.atk * (1.0 - enemy.defense * 0.01);
            bool isCriticalHit = new Random().Next(100) < critChance;
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
            health -= damageInt;
            if (health <= 0)
            {

                Console.WriteLine($"You have been defeated by the {enemy.name}!");
            }
            else
            {

                if (isCriticalHit)
                {
                    Console.WriteLine($"Critical Hit! You take {damageInt} damage. Remaining health: {health}");
                }
                else
                {
                    Console.WriteLine($"You take {damageInt} damage. Remaining health: {health}");
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
                TextPos.CenterText();
                AnsiConsole.Markup(
                    $"{Textcolor.NormalText("As a")}{Textcolor.TitanText(role)}{Textcolor.NormalText("these are your stats currently")}");
            }

            if (role == "[bold chartreuse3]Rogue[/]")
            {
                TextPos.CenterText();
                AnsiConsole.Markup(
                    $"{Textcolor.NormalText("As a")}{Textcolor.RogueText(role)}{Textcolor.NormalText("these are your stats currently")}");
            }

            if (role == "[bold blueviolet]Warlock[/]")
            {
                TextPos.CenterText();
                AnsiConsole.Markup(
                    $"{Textcolor.NormalText("As a")}{Textcolor.WarlockText($"{role}")}{Textcolor.NormalText("these are your stats currently")}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Tables.CreateStatTable("[italic blue]Stats[/]", "[italic blue]Value[/]", "[red]HP[/]", $"[red]{health}[/]", "[darkorange]Strenght[/]", $"[darkorange]{atk}[/]", "[grey]Defense[/]", $"[grey]{defense}[/]", "[purple]XP[/]", $"[purple]{experience}[/]", "[yellow]Dodge[/]", $"[yellow]{dodge}[/]");

        }

        public void addToInventory(Weapons weapons)
        {
            atk += weapons.damage;
            this.inventory.AddWeapons(weapons);
        }

        public void TakeDamage(int _damage)
        {
            health -= _damage;
        }

        public void GainExperience(int amount)
        {
            experience += amount;
            Console.WriteLine();
            AnsiConsole.Markup($"[seagreen3]Gained[/][purple] {amount} XP![/]");
            Console.WriteLine();
            if (experience >= XpToNextLevel)
            {
                LevelUp();
            }

        }

        public void LevelUp()
        {
            {
                level++;
                AnsiConsole.Markup($"[seagreen3]Congratulations! You have reached level : [/][purple]{level}[/]");
                int remainingExperience = Math.Max(0, experience - XpToNextLevel);
                experience -= XpToNextLevel;
                XpToNextLevel = (int)(XpToNextLevel * 1.25);
                Console.WriteLine();
                AnsiConsole.Markup($"[seagreen3]Experience required for the next level : [/][purple]{XpToNextLevel}[/][seagreen3], Current experience :[/][purple] {remainingExperience}[/]");
            }
        }
        public void Dodge(Enemies enemy, Player player)
        {
            bool isDodged;
            Random random = new Random();
            int randomChance = random.Next(1);

            if (randomChance == 0)
                isDodged = false;
            else
                isDodged = true;

            if (isDodged)
                AnsiConsole.Markup($"You have dodged {enemy.name} and escaped his attack by a hair!");
            else
            {
                AnsiConsole.Markup($"Your attempt in dodging {enemy.name} failed! He hit you and you took some damage...");
                player.TakeDamage(enemy);
            }

            Console.ReadLine();
        }
        public void PlayerAcquireddWeapon(Weapons weapon)
        {
            AnsiConsole.Markup($"{Textcolor.NormalText("You have acquired the")}{Textcolor.WeaponText(weapon.name)}");

        }
    }
}