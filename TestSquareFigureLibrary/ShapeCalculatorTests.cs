using System;

using NUnit.Framework;

using SquareFigureLibrary;

namespace TestSquareFigureLibrary
{
    [TestFixture(Category = "Unit")]
    public class ShapeCalculatorTests
    {
        private class Rectangle : IShape
        {
            private readonly double _width;
            private readonly double _height;

            public Rectangle(double width, double height)
            {
                _width = width;
                _height = height;
            }

            public double CalculateArea()
            {
                return _width * _height;
            }
        }


        [Test]
        public void CalculateRectangleArea_ValidSides_ReturnsCorrectArea()
        {
            var rectangle = new Rectangle(5,4);
         
            var actualArea = ShapeCalculator.CalculateArea(rectangle);
                        
            Assert.AreEqual(20, actualArea);
        }

        [Test]
        public void CalculateRectangleArea_InvalidSides_ReturnsCorrectArea()
        {
            var rectangle = new Rectangle(5, 0);

            Assert.Throws<ArgumentException>(() => ShapeCalculator.CalculateArea(rectangle));
        }
    }
}