using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtils.Interfaces;
using MathUtils.Shapes.Factory;

namespace DependencyInjectionCONSTRUCTOR
{
    public class MathLogicConsumer
    {
        static IQuadrilateral square;
        static ICircle circle;
        static IQuadrilateral rectangle;
        public MathLogicConsumer(IQuadrilateral Square, ICircle Circle, IQuadrilateral Rectangle)
        {
            square = Square;
            circle = Circle;
            rectangle = Rectangle;

            square = ShapeFactory.GetSquareObj(Pheight: 8, Plength: 8, Pwidth: 8);
            circle = ShapeFactory.GetCircleObj(Pdiameter: 8);
            rectangle = ShapeFactory.GetRectangleObj(Pheight: 10, Plength: 10, Pwidth: 10);
        }

        public static IQuadrilateral GetSquare() { return square; }
        public static ICircle GetCircle() { return circle; }
        public static IQuadrilateral GetRectangle() { return rectangle; }
    }
}
