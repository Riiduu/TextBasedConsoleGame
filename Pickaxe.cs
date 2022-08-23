using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Pickaxe
    {
        

        public static void GoLeft()
        {
            BirdFight bird = new BirdFight();

            Console.WriteLine("- starts digging a tunnel to find a way out and falls \n into a gigabird nest with 3 golden eggs inside");
            Console.WriteLine("Pick up an egg?");
            Console.WriteLine("1. Decline");
            Console.WriteLine("2. Accept");
            Console.Write("action: ");
            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine("- an egg hatches and you tame a bird");
                    break;
                case 2:
                    Console.WriteLine("A bird mother flies into the nest and you \n have to fight it with your pickaxe");
                    bird.StartFight();
                    break;
            }


        }
    }
}
