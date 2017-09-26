using System;

namespace Polygons.Library
{
    /// <summary>
    /// Inherits from object, but implements IRegularPolygon.
    /// </summary>
    public class Octagon : IRegularPolygon
    {
        //as per interface requirements
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        //ctor
        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }

        //as per interface requirements
        //NB: method must be initialized
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        //as per interface requirements
        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}
