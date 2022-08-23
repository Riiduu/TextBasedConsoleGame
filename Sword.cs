using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Sword
    {
        public static void GoRight()
        {
            Player player = new Player();

            Console.WriteLine("- You found a rusty sword");
            player.AddToInventory("rusty sword");

            Console.WriteLine("+3 Attack Damage, Total {0}", player.attackDamage);
            Console.WriteLine("- You see an escape out of the dungeon but you also see a crowd of skeletons ganging up on a dead animal");
            Console.WriteLine("- What are you gonna do?\n");

            Console.WriteLine("1. Escape");
            Console.WriteLine("2. Fight the zombies");
            Console.Write("action: ");
            int action = Convert.ToInt32(Console.ReadLine());
        }
    }
}
