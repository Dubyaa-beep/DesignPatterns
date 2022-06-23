using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtils.Interfaces
{
    public interface ICircle : IShape
    {
        double diameter { get; set; }
        double GetRadius();
        double GetCircumference();
        double GetArea();

    }
}
