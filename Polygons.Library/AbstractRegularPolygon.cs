
namespace Polygons.Library
{
    /// <summary>
    /// Abstract class, can not be instantiated.
    /// </summary>
    public abstract class AbstractRegularPolygon
    {
        //properties
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        //ctor
        public AbstractRegularPolygon(int sides, int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        //abstract method
        public abstract double GetArea();
    }
}
