namespace Shapes
{
    using System;
    
    public class MainClass
    {
        public static void Main()
        {
            Triangle triangle = new Triangle(3d, 3d);
            Rectangle rectangle = new Rectangle(3d, 3d);
            Circle circle = new Circle(3d, 4d);

            Shape[] shapeArr = new Shape[] { triangle, rectangle, circle };

            foreach (Shape shape in shapeArr)
            {
                Console.WriteLine(shape.CalculateSurface().ToString("F2"));
            }
        }
    }
}
