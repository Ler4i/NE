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
            try 
            { 
                myWorld = new World(x: 5000000.0F, y: 500.0F);
                
            }
            catch
            {
                Console.WriteLine("Что-от пошло не так");
            }
        }

    }
}
