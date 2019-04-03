using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            Console.WriteLine("main is running");
            try
            {
                MapLocation maplocation = new MapLocation(20, 20, map);
            }
            catch(Exception)
            {
                Console.WriteLine("ThreadStaticAttribute map location if off the map");
            }
            


        }
    }
}   
