using System;

namespace Game
{
    class Program
    {

        static void Main(string[] args)
        {
            CreditScreen();
            MainMenu();

        }

        static void MainMenu()
        {
            Console.WriteLine("1. Start a new game");
            Console.WriteLine("2. Continue \n");

            Console.Write("action: ");
            int action = Convert.ToInt32(Console.ReadLine());

            if (action == 1)
            {
                MainGame.StartGame();
            }
            else if (action == 2)
            {
                MainGame.ContinueGame();
            }

        }

        static void CreditScreen()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("|  THE GAME   |");
            Console.WriteLine("---------------");
            Console.WriteLine("|  EPIC RPG   |");
            Console.WriteLine("---------------");
            Console.WriteLine("|  By Riiduu  |");
            Console.WriteLine("|  & Jankus   |");
            Console.WriteLine("---------------");
        }
    }
}