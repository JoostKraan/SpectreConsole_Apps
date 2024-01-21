using Spectre.Console;

namespace SpectreRPG.Automation
{
    public class TextPos
    {



        public static string Center(string input)
        {
            var rule = new Rule(input);
            AnsiConsole.Write(rule);
            return input;
        }
        public static string Left(string input)
        {
            var rule = new Rule(input);
            rule.Justification = Justify.Left;
            AnsiConsole.Write(rule);
            return input;
        }
        public static string Right(string input)
        {
            var rule = new Rule(input);
            rule.Justification = Justify.Right;
            AnsiConsole.Write($"$[orange3]{rule}[/]");
            return input;
        }

        public static void CenterText()
        {
            Console.SetCursorPosition(45, 2);
        }

    }
}
