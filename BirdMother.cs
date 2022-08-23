using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class BirdMother
    {
        
        public int birdHealth = 20;

        public void AttackPlayer()
        {
            Player player = new Player();
            Random rand = new Random();

            int[] damage = { 5, 10, 15 };
            int damageDealt = rand.Next(damage.Length);
            Console.WriteLine("- Birdmother attacks you and deals {0} damage", damageDealt);
            player.health = player.health - damageDealt;
            Console.WriteLine("- Remaining hp: {0}", player.health);




            /*int[] attackDamage = { 0, 1, 2, 3, 4, 5, 6 };
            int attack = rand.Next(attackDamage.Length);

            Console.WriteLine("- The bird mother attacks you");
            Console.WriteLine("- She deals {0} damage", attack);
            player.health = player.health - attack;
            Console.WriteLine("- Remaining hp: {0}", player.health);*/
        }
    }
}
