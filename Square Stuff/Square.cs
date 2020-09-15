namespace Shapes
{
    public class Square
    {
        public double SideLength { get; set; }
        public Square(double sideLength)
        {
            this.SideLength = sideLength;
        }

        public double CalculateArea()
        {
            return SideLength * SideLength;
        }

        public double CalculatePerimeter()
        {
            return 4 * SideLength;
        }
    }
}
