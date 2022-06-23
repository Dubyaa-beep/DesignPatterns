using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtils.Interfaces;

namespace MathUtils.Shapes.Factory
{
    public class ShapeFactoryNonStatic
    {
        public IQuadrilateral GetSquareObj(decimal Pheight, decimal Pwidth, decimal Plength)
        {
            return new Square()
            {
                height = Pheight,
                width = Pwidth,
                length = Plength
            };
        }

        public IQuadrilateral GetRectangleObj(decimal Pheight, decimal Pwidth, decimal Plength)
        {
            return new Rectangle()
            {
                height = Pheight,
                width = Pwidth,
                length = Plength
            };
        }

        public ICircle GetCircleObj(double Pdiameter)
        {
            return new Circle()
            {
                diameter = Pdiameter
            };
        }
    }
}
