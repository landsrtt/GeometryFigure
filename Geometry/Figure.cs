namespace Geometry
{
    public abstract class Figure
    {
        public string Name { get; private set; }
        public double X { get; set; }
        public double Y { get; set; }
        protected Figure(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }
        public abstract double GetSize();

        public void Display()
        {
            Console.WriteLine($"Фигура: {Name} => Координаты: ({X}, {Y}) | Размер: {GetSize()}");
        }
    }
   
}

