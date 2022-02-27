using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020ne.Test
{
    public class World//описываем класс 
    {        
        public World(float x, float y)
        {
            if (x < 1000000.0F) sizeX = x;
            else throw new ArgumentOutOfRangeException();//выбросит ошибку
            if (y < 1000000.0F) sizeY = y;
            else throw new ArgumentOutOfRangeException();//выбросит ошибку
            for (int i = 0; i < 500; i++)
            {
                carrot.Add(new Carrot(nH: 50));
            }
            player = new Player(hp:100, hungry:0, transform: new Transform(x:0, y:0, z:0));
        }       
        private float sizeX;
        private float sizeY;
        private List<Carrot> carrot;

        public Player player;
    }
}
