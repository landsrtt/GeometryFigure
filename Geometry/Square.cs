using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    // Класс "Квадрат"
    public class Square : Figure
    {
        public double Side { get; set; }

        public Square(double x, double y, double side) : base("Квадрат", x, y)
        {
            Side = side;
        }

        public override double GetSize()
        {
            return Side * Side; // Площадь квадрата
        }
    }
}
