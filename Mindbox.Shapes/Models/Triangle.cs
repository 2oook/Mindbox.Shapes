namespace Mindbox.Shapes.Models
{
    using Mindbox.Shapes.Exceptions;

    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            Guard.IsLessThanOrEqualToZero(sideA);
            Guard.IsLessThanOrEqualToZero(sideB);
            Guard.IsLessThanOrEqualToZero(sideC);

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double CalculateSquare()
        {
            var semiperimeter = CalculateSemiperimeter();
            CheckSides(semiperimeter);

            return Math.Sqrt(semiperimeter 
                * (semiperimeter - _sideA) 
                * (semiperimeter - _sideB) 
                * (semiperimeter - _sideC));
        }

        public bool IsRight() 
        {
            return (_sideA * _sideA) + (_sideB * _sideB) == (_sideC * _sideC)
                || (_sideA * _sideA) + (_sideC * _sideC) == (_sideB * _sideB)
                || (_sideB * _sideB) + (_sideC * _sideC) == (_sideA * _sideA);
        }

        private double CalculateSemiperimeter()
        {
            return (_sideA + _sideB + _sideC) / 2;
        }

        private void CheckSides(double semiperimeter) 
        {
            if (_sideA < semiperimeter && _sideB < semiperimeter && _sideC < semiperimeter)
                return;

            throw new ThereIsNoSuchRectangleException();
        }
    }
}