using System;

namespace Polygons.Library
{
    public class ConcreteRegularPolygon
    {
        //properties
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        //ctor
        public ConcreteRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            //child classes override this method with appropriate calculation
            throw new NotImplementedException();
        }
    }
}
