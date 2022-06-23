using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtils.Interfaces;
/// <summary>
/// This factory produces shapes which are used for dependency injection
/// </summary>
namespace MathUtils.Shapes.Factory
{
    public class ShapeFactory
    {
        public static IQuadrilateral GetSquareObj(decimal Pheight, decimal Pwidth, decimal Plength)
        {
            return new Square()
            {                
                height = Pheight,
                width = Pwidth,
                length = Plength
            };
        }

        public static IQuadrilateral GetRectangleObj(decimal Pheight, decimal Pwidth, decimal Plength)
        {
            return new Rectangle()
            {
                height = Pheight,
                width = Pwidth,
                length = Plength
            };
        }

        public static ICircle GetCircleObj(double Pdiameter)
        {
            return new Circle()
            {
                diameter = Pdiameter
            };
        }
    }
}
