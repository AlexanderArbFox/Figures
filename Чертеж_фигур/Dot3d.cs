using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Чертеж_фигур
{
    public class Dot3d:Dot2d
    {
        public int _z { get; set; }


        public Dot3d()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }

        public Dot3d(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
    }
    
}
