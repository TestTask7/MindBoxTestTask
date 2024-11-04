
namespace SquareFigureLibrary
{
    /// <summary>
    /// Triangle.
    /// </summary>
    public class Triangle : IShape
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new ArgumentException("Ошибка: Стороны не могут быть отрицательными числами!");
            }

            if (!IsValidTriangle(side1, side2, side3))
            {
                throw new ArgumentException("Ошибка: Треугольник с такими сторонами не существует!");
            }

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        /// <inheritdoc />
        public double CalculateArea()
        {
            var semiPerimeter = (_side1 + _side2 + _side3) / 2;
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));

            return area;
        }

        /// <summary>
        /// Is right triangle.
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            var a2 = Math.Pow(_side1, 2);
            var b2 = Math.Pow(_side2, 2);
            var c2 = Math.Pow(_side3, 2);

            return (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
        }

        private static bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideB + sideC > sideA) && (sideC + sideA > sideB);
        }
    }
}
