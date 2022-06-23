using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtils.Interfaces;
using MathUtils.Shapes.Factory;


namespace DependencyInjectionINTERFACES
{
    // The point of this is to create loosely coupled functionality that can be re-used with other projects. We inject the MathUtils project using interfaces.
    // We can create a factory object which creates the objects we intended.
    internal class Program
    {
        static IQuadrilateral rectangle;
        static IQuadrilateral square;
        static ICircle circle;
        static void Main(string[] args)
        {
            rectangle = ShapeFactory.GetRectangleObj(Plength: 8, Pwidth: 8, Pheight: 10); //Create the object from the ShapeFactory *NOTICE you do not have to have parameters in the Factory 
            Console.WriteLine($"Type: {rectangle.GetShapeType()}");
            Console.WriteLine($"Volume: {rectangle.Volume()}");
            Console.WriteLine($"Area: {rectangle.Area()}");

            square = ShapeFactory.GetSquareObj(Plength: 9, Pwidth: 9, Pheight: 10); //Create the object from the ShapeFactory *NOTICE you do not have to have parameters in the Factory
            Console.WriteLine($"Type: {square.GetShapeType()}");
            Console.WriteLine($"Volume: {square.Volume()}");
            Console.WriteLine($"Area: {square.Area()}");

            circle = ShapeFactory.GetCircleObj(Pdiameter: 10); //Create the object from the ShapeFactory *NOTICE you do not have to have parameters in the Factory
            Console.WriteLine($"Type: {circle.GetShapeType()}");
            Console.WriteLine($"Volume: {circle.GetCircumference()}");
            Console.WriteLine($"Area: {circle.GetArea()}");
        }
    }
}
