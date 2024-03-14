using Spectre;
namespace Tictactoe

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChooseThingy();


        }
        public static string ChooseThingy()
        {
            Console.WriteLine("Choose for either X or O ");
            string choice = Console.ReadLine();
            return choice;
        }

    }
}