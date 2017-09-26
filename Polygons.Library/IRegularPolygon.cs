
namespace Polygons.Library
{
    /// <summary>
    /// Can only be declared, not initialized.
    /// The class implementing the interface provides the details.
    /// All members are automatically public, no other access modifiers.
    /// </summary>
    public interface IRegularPolygon
    {
        //these properties do not have backing fields
        //it is a simple declaration that these properties have to exist
        //the implementing class will initializes this properties
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        //the same as above, these methods do not have implementations
        double GetPerimeter();
        double GetArea();
    }
}
