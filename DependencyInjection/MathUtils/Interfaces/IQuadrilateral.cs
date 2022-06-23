using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtils.Interfaces
{
    public interface IQuadrilateral : IShape
    {
        decimal length { get; set; }
        decimal width { get; set; }
        decimal height { get; set; }
        decimal Area();
        decimal Volume();
    }
}
