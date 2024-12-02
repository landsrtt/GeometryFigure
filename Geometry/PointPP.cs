using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
   
    public class PointPP : Figure
    {
        public PointPP(double x, double y) : base("Точка", x, y) { }

        public override double GetSize()
        {
            return 0; // Размер точки равен 0
        }
    }
}
