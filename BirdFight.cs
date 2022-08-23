using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class BirdFight
    {
        public void StartFight()
        {
            Player player = new Player();
            BirdMother birdMother = new BirdMother();
            
            Console.WriteLine("- You have to attack");
            Console.WriteLine("Your current attack damage is {0}", player.attackDamage);
            
        }

        public void AttackOptions()
        {

        }
    }


    
}

/*
 
 -------------------------------------------------------------
| 1. Basic attack       (4/4) |  2 Swing your pickaxe  (4/4)  |
|                             |                               |
|-----------------------------|-------------------------------|
| 3 Try to run away    (1/4)  |  4  Surprize it with  (1/10)  |
|                             |     epic dance moves          |
 -------------------------------------------------------------
 */
