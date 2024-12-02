using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{

    // Класс "Круг"
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double radius) : base("Круг", x, y)
        {
            Radius = radius;
        }

        public override double GetSize()
        {
            return Math.PI * Radius * Radius; // Площадь круга
        }
    }
}
