using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefence
{
    class TreehouseDefenceException : System.Exception
    {
        public TreehouseDefenceException()
        {

        }
        public TreehouseDefenceException(string message) : base(message)
        {

        }
    }
    class OutOfBoundsExeption : TreehouseDefenceException
    {
        public OutOfBoundsExeption()
        {

        }

        public OutOfBoundsExeption(string message) : base(message)
        {

        }
    }
}
