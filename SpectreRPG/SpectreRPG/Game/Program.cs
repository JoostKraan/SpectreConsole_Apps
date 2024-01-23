using Spectre.Console;
using System.Media;
namespace SpectreRPG.Game

{
    public class Program
    {
        SoundPlayer player;
        static void Main(string[] args)
        {
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Repositories\SpectreConsole_Apps\SpectreRPG\SpectreRPG\bin\Debug\net6.0\fart.wav");
            //player.Play();
            Game game = new Game();
            game.InputPlayerInfo();


        }

    }
}