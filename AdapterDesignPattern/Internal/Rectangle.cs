using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterDesignPattern.ExternalShapes;

namespace AdapterDesignPattern.Internal
{
    public class Rectangle : Shape
    {

        LegacyRectangle rec = new LegacyRectangle();

        public int X1 { get; set; }
        public int Y1 { get; set; }

        public int X2 { get; set; }
        public int Y2 { get; set; }

        public int Area()
        {
            rec.X1 = X1;
            rec.Y1 = Y1;

            rec.Width = X2 - X1;
            rec.Height = Y2 - Y1;

            return rec.Area();

        }

        public void Diplay()
        {
            throw new NotImplementedException();
        }
    }
}
