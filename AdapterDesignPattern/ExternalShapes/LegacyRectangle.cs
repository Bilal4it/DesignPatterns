using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.ExternalShapes
{
    // Adaptee
    public class LegacyRectangle
    {
        public int X1 { get; set; }
        public int Y1 { get; set; } 

        public int Width { get; set; }

        public int Height { get; set; }

        public int Area()
        {
            return Height * Width;
        }
    }
}
