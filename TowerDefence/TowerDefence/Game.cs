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
                MapLocations[] path =
                {
                    new MapLocations(0, 2, map),
                    new MapLocations(1, 2, map),
                    new MapLocations(2, 2, map),
                    new MapLocations(3, 2, map),
                    new MapLocations(4, 2, map),
                    new MapLocations(5, 2, map),
                    new MapLocations(6, 2, map),
                    new MapLocations(7, 2, map),
                };
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
