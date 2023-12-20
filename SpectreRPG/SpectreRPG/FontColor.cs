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
        internal static string Defense => ("[grey50]");
        internal static string Xp => ("[blueviolet]");
        internal static string Dodge => ("[orange4]");
        internal static string Health => ("[green4]");
        internal static string Weapon => ("[yellow1]");
        internal static string Blue => ("[bold blue]");
        internal static string Titan => ("[bold grey27]");
        internal static string Rogue => ("[bold chartreuse3]");
        internal static string Warlock => ("[bold blueviolet]");
        public static string NormalText(String text) => ($"{Seagreen} {text}[/]");
        public static string WeaponText(String text) => ($"{Weapon} {text}[/]");
        public static string NameText(String text) => ($"{Blue} {text}[/]");
        public static string TitanText(string text) => ($"{Titan} {text}[/]");
        public static string RogueText(string text) => ($"{Rogue} {text}[/]");
        public static string WarlockText(string text) => ($"{Warlock} {text}[/]");
        public static string HpText(string text) => ($"{Health} {text}[/]");
        public static string DefenseText(string text) => ($"{Defense} {text}[/]");
        public static string DodgeText(string text) => ($"{Dodge} {text}[/]");
        public static string XpText(string text) => ($"{Xp} {text}[/]");

        

        
    }

}
