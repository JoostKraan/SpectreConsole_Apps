using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SpectreRPG
{
    public static class Textcolor
    {
        internal static string Seagreen => ("[seagreen3]");
        internal static string Yellow => ("[yellow1]");
        internal static string Blue => ("[bold blue]");
        internal static string Titan => ("[bold grey27]");
        internal static string Rogue => ("[bold chartreuse3]");
        internal static string Warlock => ("[bold blueviolet]");
        public static string NormalText(String text) => ($"{Seagreen} {text}[/]");
        public static string WeaponText(String text) => ($"{Yellow} {text}[/]");
        public static string NameText(String text) => ($"{Blue} {text}[/]");
        public static string TitanText(string text) => ($"{Titan} {text}[/]");
        public static string RogueText(string text) => ($"{Rogue} {text}[/]");
        public static string WarlockText(string text) => ($"{Warlock} {text}[/]");

        
    }

}
