using System;



namespace TicTacToe
{
    class Program
    {
        static char[] field = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            bool gameOver = false;
            while (!gameOver)
            {
                DrawField();

                int choice = GetUserChoice();

                if (field[choice - 1] != 'X' && field[choice - 1] != 'O')
                {
                    field[choice - 1] = currentPlayer;
                    if (CheckForWin())
                    {
                        Console.WriteLine($"Player {currentPlayer} Won");
                        gameOver = true;
                    }
                    else if (CheckForDraw())
                    {
                        Console.WriteLine("The game ends, its a draw");
                        gameOver = true;
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("This spot is already taken");
                }
            }

            Console.WriteLine("Want to play again?");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes")
            {
                ResetBoard();
              
            }
        }

        static void DrawField()
        {
            Console.Clear();
            Console.WriteLine("  {0} | {1} | {2} ", field[0], field[1], field[2]);
            Console.WriteLine(" ----------- ");
            Console.WriteLine("  {0} | {1} | {2} ", field[3], field[4], field[5]);
            Console.WriteLine(" ----------- ");
            Console.WriteLine("  {0} | {1} | {2} ", field[6], field[7], field[8]);
            Console.WriteLine();
        }

        static int GetUserChoice()
        {
            int choice = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write($"Player {currentPlayer}, Choose a spot (1-9): ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            return choice;
        }

        static bool CheckForWin()
        {
            return (field[0] == field[1] && field[1] == field[2]) ||
                   (field[3] == field[4] && field[4] == field[5]) ||
                   (field[6] == field[7] && field[7] == field[8]) ||
                   (field[0] == field[3] && field[3] == field[6]) ||
                   (field[1] == field[4] && field[4] == field[7]) ||
                   (field[2] == field[5] && field[5] == field[8]) ||
                   (field[0] == field[4] && field[4] == field[8]) ||
                   (field[2] == field[4] && field[4] == field[6]);
        }

        static bool CheckForDraw()
        {
            foreach (char c in field)
            {
                if (c != 'X' && c != 'O')
                    return false;
            }
            return true;
        }

        static void ResetBoard()
        {
            for (int i = 0; i < field.Length; i++)
            {
                field[i] = (char)('1' + i);
            }
            currentPlayer = 'X';
        }

        static void ShowUserStories()
        {
            Console.WriteLine("Als speler wil ik kunnen navigeren door diverse levels");
            Console.WriteLine("Als speler wil ik power ups kunnen verzamelen en puzzels oplossen terwijl ik vijanden versla");
            Console.WriteLine("als speler wil ik strijden tegen eindbazen om de wereld te redden");
            Console.WriteLine("als speler wil ik kunnen progressen door de wereld alleen of met een vriend");
            Console.WriteLine("als speler wil ik meerdere werelden ontdekken");
        }
    }
}
