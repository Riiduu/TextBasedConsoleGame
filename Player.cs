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
    }
}
