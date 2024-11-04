using System;

using NUnit.Framework;

using SquareFigureLibrary;

namespace TestSquareFigureLibrary
{
    [TestFixture(Category = "Unit")]
    public class TriangleTests
    {
        [Test]
        public void CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            var side1 = 3.0;
            var side2 = 4.0;
            var side3 = 5.0;

            var triangle = new Triangle(side1, side2, side3);

            var area = triangle.CalculateArea();

            Assert.AreEqual(6.0, area);
        }

        [Test]
        public void IsRightTriangle_RightTriangle_ReturnsTrue()
        {

            var side1 = 3.0;
            var side2 = 4.0;
            var side3 = 5.0;

            var triangle = new Triangle(side1, side2, side3);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.IsTrue(isRightTriangle);
        }

        [Test]
        public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
        {

            var side1 = 3.0;
            var side2 = 4.0;
            var side3 = 6.0;

            var triangle = new Triangle(side1, side2, side3);

            bool isRightTriangle = triangle.IsRightTriangle();

            Assert.IsFalse(isRightTriangle);
        }

        [Test]
        public void Constructor_InvalidSides_ThrowsArgumentException()
        {

            var side1 = -1.0;
            var side2 = 2.0;
            var side3 = 3.0;

            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }    
    }
}
