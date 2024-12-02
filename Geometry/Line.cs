using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
 
    // Класс "Линия"
    public class Line : Figure
    {
        private PointPP StartPoint;
        private PointPP EndPoint;

        public Line(PointPP start, PointPP end) : base("Линия", (start.X + end.X) / 2, (start.Y + end.Y) / 2)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public override double GetSize()
        {
            return Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + Math.Pow(EndPoint.Y - StartPoint.Y, 2));
        }
    }
}
