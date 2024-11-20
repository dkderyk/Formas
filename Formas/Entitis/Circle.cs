using Formas.Enums;

namespace Formas.Entitis
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        private double Pi = 3.14;

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Pi * Radius * Radius;
        }
    }
}
