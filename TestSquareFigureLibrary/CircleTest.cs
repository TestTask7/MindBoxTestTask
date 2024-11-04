using System;

using NUnit.Framework;

using SquareFigureLibrary;

namespace TestSquareFigureLibrary
{
    [TestFixture(Category = "Unit")]
    public class CircleTest
    {
        [Test]
        public void CalculateArea_PositiveRadius_ReturnsCorrectArea()
        {
            var radius = 5;
            var circle = new Circle(radius);

            var area = circle.CalculateArea();

            var expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.AreEqual(expectedArea, area);
        }

        [Test]
        public void Constructor_ZeroRadius_ThrowsArgumentException()
        {
            var radius = 0;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Test]
        public void Constructor_NegativeRadius_ThrowsArgumentException()
        {
            var radius = -5;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
