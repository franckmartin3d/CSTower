﻿using System;
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

            int area = map.Width * map.Height;

            //Console.WriteLine("it works");
        }
    }
}