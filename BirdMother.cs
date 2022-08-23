using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class BirdMother
    {
        Player player = new Player();
        int birdHealth = 20;

        public static void AttackPlayer()
        {
            Random rand = new Random();
            int[] attackDamage = { 0, 1, 2, 3, 4, 5, 6 };
            int attack = rand.Next(attackDamage.Length);
            

        }
    }
}
