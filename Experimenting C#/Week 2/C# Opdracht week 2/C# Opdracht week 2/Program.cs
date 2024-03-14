namespace C__Opdracht_week_2
{
    public class Program
    {
       public static int randomGetal;
        public static bool isGeraden = true;
        //User Story : als  speler wil ik het nummer raden door een getal binnen een bereik te gokken 
        // User Story : als speler maak ik gebruik van hints zodat ik makkelijker het getal kan raden

        static void Main(string[] args)
        {
            Play();
        }
        public static void GenereerGetal()
        {
            Random random = new Random();
            randomGetal = random.Next(0, 51);
        }
        public static void Play()
        {
            GenereerGetal();
            Console.WriteLine("Gok een getal tussen de 0 en de 50"); //Een bereik tussen de 0 en de 10
            while (isGeraden)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == randomGetal)
                {
                    Console.WriteLine("Correct");
                    isGeraden = false;
                    Console.ReadLine();
                }
                if (userInput < randomGetal)
                {
                    Console.WriteLine("Hoger");//Speler krijgt hints
                }
                if (userInput > randomGetal)
                {
                    Console.WriteLine("Lager");//Speler krijgt hints
                }
                if (userInput == null)
                {
                    Play();
                }
            }
        }
    }
}