using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Чертеж_фигур
{
     public class Dot2d
    {
        public int _x { get; set; }
        public int _y { get; set; }
    }
    public struct Point2d
    {
        public static readonly Point2d Empty;
      //  public Point2d(float x, float y);
    }
    public struct Rectang
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int x3 { get; set; }
        public int x4 { get; set; }
    }
}
