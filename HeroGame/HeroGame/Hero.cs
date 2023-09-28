using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    public class Hero
    {
        // 
        public int Vitality { get; set; }  // once reduced to zero, game over

        public Hero(int vitality)
        {
            this.Vitality = vitality;
        }

        public void LowerVitals(int hp) //hp = hit points
        {
            Vitality -= hp;
            if (Vitality <= 1)
            {
                throw new Exception("GAME OVER! " + "\nAnother Cabin Dweller bites the dust.");
            }
        }
    }
}

