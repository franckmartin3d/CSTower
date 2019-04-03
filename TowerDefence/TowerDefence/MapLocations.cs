using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    class MapLocations : Point
    {
        public MapLocations(int x , int y, Map map) : base(x,y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsExeption(x + "," + y + "is outside the boundaries of the map.");
            }
        }
    }
}
