
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
        public string race;
        public Inventory inventory;


        public Player(string name, int health, int atk, string role, int experience, int defense, int critChance,
            int dodge, int level, Inventory inventory, string race)
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
            this.race = race;


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
                    AnsiConsole.MarkupLine(Textcolor.NormalText($"You take {Textcolor.EnemyText($"{damageInt}")} damage. Remaining health: {health}"));
                }
            }

            if (this.health < 0)
            {
                EndDeathMenu();
            }
        }

        public void ShowStats()
        {
            Console.Clear();
            TextPos.Center($"{Textcolor.HeaderText("Profile")}");

            TextPos.CenterText();
            AnsiConsole.Markup(
                $"{Textcolor.NormalText("You are")}{Textcolor.NameText(name)}{Textcolor.NormalText($"the {race} ")}{role}");

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
            AnsiConsole.Markup($"{Textcolor.NormalText("Gained")} {Textcolor.XpText($"{amount} XP")}");
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
                AnsiConsole.Markup($"{Textcolor.NormalText("Congratulations! You have reached level : ")}{Textcolor.XpText($"{level}")}");
                int remainingExperience = Math.Max(0, experience - XpToNextLevel);
                experience -= XpToNextLevel;
                XpToNextLevel = (int)(XpToNextLevel * 1.25);
                Console.WriteLine();
                AnsiConsole.Markup($"{Textcolor.NormalText("Experience required for the next level : ")}{Textcolor.XpText($"{XpToNextLevel} XP")}{Textcolor.NormalText("Current experience :")}{Textcolor.XpText($"{remainingExperience} XP")}");
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
                AnsiConsole.Markup($"{Textcolor.NormalText("You have dodged ")}{Textcolor.EnemyText($"{enemy.name}")}{Textcolor.NormalText("and escaped his attack by a hair!")}");
            else
            {
                AnsiConsole.Markup($"{Textcolor.NormalText("You have dodged ")} {Textcolor.EnemyText($"{enemy.name}")} {Textcolor.NormalText("failed! He hit you and you took some damage...")}");
                player.TakeDamage(enemy);
            }

            Console.ReadLine();
        }
        public void PlayerAcquireddWeapon(Weapons weapon)
        {
            AnsiConsole.Markup($"{Textcolor.NormalText("You have acquired the")}{Textcolor.WeaponText(weapon.name)}");

        }

        public void EndDeathMenu()
        {
            Console.Clear();
            AnsiConsole.MarkupLine(Textcolor.NormalText("You lost the game"));
            string Endgame = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title(Textcolor.NormalText("Sadly your journey ends here..."))
                    .PageSize(3)
                    .AddChoices(new[]
                    {
                        "Restart Completely",
                        "Exit game"
                    }));
            if (Endgame == "Restart Completely")
            {
                Console.Clear();
                Game game = new Game();
                game.InputPlayerInfo();
            }

            if (Endgame == "Exit game")
            {
                Environment.Exit(0);
            }

        }

        public void restart()
        {
            Console.Clear();
            AnsiConsole.MarkupLine(Textcolor.NormalText("You Won"));
            string Endgame = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title(Textcolor.NormalText("More content.. Work in progress"))
                    .PageSize(3)
                    .AddChoices(new[]
                    {
                        "Restart Completely",
                        "Exit game"
                    }));
            if (Endgame == "Restart Completely")
            {
                Console.Clear();
                Game game = new Game();
                game.InputPlayerInfo();
            }

            if (Endgame == "Exit game")
            {
                Environment.Exit(0);
            }

        }
    }


}
public static class Roles
{
    public const string Titan = "[bold grey27]Titan[/]";
    public const string Rogue = "[bold chartreuse3]Rogue[/]";
    public const string Warlock = "[bold blueviolet]Warlock[/]";
    public const string Back = "> [underline red]Back[/]";
}
