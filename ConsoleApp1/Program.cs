using System;
using Geometry;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты фигур
            PointPP point = new PointPP(1.0, 2.0);
            Circle circle = new Circle(0.0, 0.0, 5.0);
            Square square = new Square(3.0, 3.0, 4.0);
            Line line = new Line(new PointPP(0, 0), new PointPP(3, 4));

            // Список фигур
            Figure[] shapes = new Figure[] { point, circle, square, line };

            // Вывод информации о фигурах
            foreach (var shape in shapes)
            {
                shape.Display();
            }
        }
    }

}