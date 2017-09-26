
namespace Polygons.Library
{
    public class Square : ConcreteRegularPolygon
    {
        public Square(int length) : 
            base(4, length) { }

        ////inherited class method
        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
