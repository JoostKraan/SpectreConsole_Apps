using System.Linq.Expressions;
using Spectre.Console;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Spectre.Console.Advanced;
using Spectre.Console.Extensions;
using Spectre.Console.Rendering;
using System.Xml.Linq;
using System;
using System.Media;


namespace SpectreRPG

{
    public class Program
    {
        public static Game game = new Game();
        public static Panel _panel = new Panel("                       RPG");
        
        static void Main(string[] args)
        {
            _panel.Border = BoxBorder.Square;
            _panel.Expand = true;
            AnsiConsole.Render(_panel);
            game.game();
            
        }
        
    }
}