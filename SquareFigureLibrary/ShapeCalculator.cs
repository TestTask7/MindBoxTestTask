
namespace SquareFigureLibrary
{
    /// <summary>
    /// Shape calculator.
    /// </summary>
    public class ShapeCalculator
    {
        /// <summary>
        /// Calculate area.
        /// </summary>
        /// <typeparam name="TShape"></typeparam>
        /// <param name="shape"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double CalculateArea<TShape>(TShape shape)
            where TShape : IShape
        {
            var area = shape.CalculateArea();
            if (area <= 0) throw new ArgumentException("Ошибка: Площадь отрицательна или равна 0!");
            return area;
        }
    }
}
