namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double width, double height)
            : base(width, width)
        {
        }

        public override double CalculateSurface()
        {
            return System.Math.PI * this.Width * this.Width / 4d; // cause "width" is the diameter, i guess...
        }
    }
}
