using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS223020ne.Test
{
    public static class Start//Входная точка в приложение. static - запускает при старте программу,но запрещает делать объекты. Start() - сам объект!!!!!
    {
        public static World myWorld;//кусочек объекта
        public static void StartApp()//кусочек объекта Start()
        {
            myWorld = new World(x: 50.0F, y: 100.0F);
        }

        public static void StartDay()
        {
            bool isDay = false;
            int duration = myWorld.getDurationDayAndNight();
            checkEndDay();
        }
    }
}
