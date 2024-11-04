
namespace SquareFigureLibrary
{
    /// <summary>
    /// Circle.
    /// </summary>
    public class Circle : IShape
    {
        private readonly double _radius;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Ошибка: Радиус не может быть отрицательным числом!");
            }
            _radius = radius;
        }

        /// <inheritdoc />
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
