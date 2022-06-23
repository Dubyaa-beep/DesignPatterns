using MathUtils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtils.Shapes
{
    public class Square : IQuadrilateral
    {
        public decimal length { get; set; }
        public decimal width { get; set; }
        public decimal height { get; set; }
        public object GetShapeType()
        {
            return this.GetType().Name;
        }
        public decimal Area()
        {
            return this.length * this.width;
        }

        public decimal Volume()
        {
            return this.width * this.height * this.length;
        }
        
    }
}
