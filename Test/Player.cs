using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020ne.Test
{
    public class Player
    {
        private int hp;
        private int hungry;
        private Transform transform;
        
        public Player(int hp, int hungry,Transform transform)
        {
            this.hp = hp;
            this.hungry = hungry;
            this.transform = transform;
        }
    }
}
