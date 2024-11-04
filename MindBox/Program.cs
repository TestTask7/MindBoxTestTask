using SquareFigureLibrary;

var circle = new Circle(6.6);
var circleArea = ShapeCalculator.CalculateArea(circle);
Console.WriteLine($"Площадь круга: {circleArea}");

var triangle = new Triangle(7.7, 3.3, 10);
var triangleArea = ShapeCalculator.CalculateArea(triangle);
Console.WriteLine($"Площадь треугольника: {triangleArea}");
