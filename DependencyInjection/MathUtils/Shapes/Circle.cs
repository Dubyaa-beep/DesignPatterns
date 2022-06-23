using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathUtils.Interfaces;

namespace MathUtils.Shapes
{
    public class Circle : ICircle
    {
        public double diameter { get; set; }

        public object GetShapeType()
        {
            return this.GetType().Name;
        }
        public double GetRadius()
        {
            return this.diameter / 2;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * this.GetRadius();
        }

        public double GetArea()
        {
            return Math.PI * this.GetRadius() * this.GetRadius();
        }
    }
}
