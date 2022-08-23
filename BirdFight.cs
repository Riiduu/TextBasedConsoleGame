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

            player.Attack();
            birdMother.AttackPlayer();
            
            player.Attack();
            birdMother.AttackPlayer();
            
            player.Attack();
            birdMother.AttackPlayer();
            
        }
    }


    
}
