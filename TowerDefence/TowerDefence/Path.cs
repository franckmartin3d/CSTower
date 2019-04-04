using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    class Path
    {
        private readonly MapLocations[] _path;
        
        public Path(MapLocations[] path)
        {
            _path = path;
        }

        public MapLocations GetLocationAt(int pathStep)
        {
            if(pathStep < _path.Length)
            {
                return _path[pathStep];
            }
            else
            {
                return null;
            }
        }
    }

}
