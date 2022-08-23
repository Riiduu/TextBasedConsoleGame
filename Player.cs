using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public List<string> inventory = new List<string>();
        public int attackDamage = 2;
        public int health = 100;
        public void AddToInventory(string itemName)
        {
            inventory.Add(itemName);

            if (itemName == "rusty sword")
            {
                attackDamage = attackDamage + 3;
            }
        }

        public void Attack()
        {
            Random random = new Random();
            BirdMother bird = new BirdMother();
            
            int[] damage = {1, 5, 10, 15};
            int damageDealt = random.Next(damage.Length);
            int totalDamage = damageDealt + attackDamage;
            Console.WriteLine("- You attack and deal {0} damage", totalDamage);
            bird.birdHealth = bird.birdHealth - totalDamage;
            Console.WriteLine("- Enemy remaining hp: {0}", bird.birdHealth);
        
        }
    }
}
