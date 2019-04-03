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

            try
            {
                MapLocations mapLocations = new MapLocations(20, 20, map);
            }
            catch(OutOfBoundsExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenceException ex)
            {
                Console.WriteLine("Unhandle treehousedefenceExeption");
            }
            catch(Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }
           

        }
    }
}
