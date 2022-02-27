using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020ne.Test
{
    public class Carrot
    {
        public Carrot(int nH)
        {
            newHealth = nH;
        }
        private int newHealth;
        public int NewHealth { set { newHealth = value; } }
    }
}
