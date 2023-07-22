namespace Mindbox.Shapes.Models
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            Guard.IsNegative(radius);

            _radius = radius;
        }

        public override double CalculateSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
};