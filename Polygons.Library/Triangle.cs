using System;

namespace Polygons.Library
{
    public class Triangle: AbstractRegularPolygon
    {
        public Triangle(int length) :
            base(3, length) { }

        //overriden because of different area calc
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}
