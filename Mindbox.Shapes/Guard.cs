namespace Mindbox.Shapes
{
    internal class Guard
    {
        public static void IsNegative(double number) 
        {
            if (number < 0) throw new ArgumentOutOfRangeException(nameof(number));
        }

        public static void IsLessThanOrEqualToZero(double number) 
        {
            if (number <= 0) throw new ArgumentOutOfRangeException(nameof(number));
        }
    }
}