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
            sizeX = x;
            sizeY = y;
        }
        public float sizeX;
        public float sizeY;

        public int durationDayAndNight { get; private set { if(value > 100) } } = 30;
    }
}
