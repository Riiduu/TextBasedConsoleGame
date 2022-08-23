using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class MainGame
    {
        public static void StartGame()
        {
            Console.WriteLine("You wake up in a random dungeon...");
            Console.WriteLine("Walk into the left or right cave?\n");

            Console.WriteLine("1. Left");
            Console.WriteLine("2. Right");
            Console.Write("action: ");
            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Pickaxe.GoLeft();
                    break;
                case 2:
                    Sword.GoRight();
                    break;
                default:
                    StartGame();
                    break;
            }
        }

        public static void ContinueGame()
        {
            Console.WriteLine("Continue...");
        }
    }
}
