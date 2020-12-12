using System;
using System.Drawing;

namespace Shapes
{
    public class Rectangle : Shape
    {
        //constructors
        public Rectangle()
        {
            new Rectangle(defaultHeight, defaultWidth);
        }
        public Rectangle(double height, double width)
        {
            this._height = height;
            this._width = width;
        }

        //destructor
        ~Rectangle()
        {

        }

        //fields
        private double _height;
        private double _width;
        public const double defaultHeight = 0;
        public const double defaultWidth = 0;

        internal double whatever = 6;

        //properties
        public Color Color { get; set; }

        public double Height { get; set; }
        //{
        //    get { return height; }

        //    set { height = value; }           
        //}

        public double Width
        {
            get { return _width; }

            set { _width = value; }
        }


        //methods
        public static double CalculateArea(double height, double width)
        {
            return height * width;
        }
        public override double CalculateArea()
        {
            return CalculateArea(_height, _width);
        }

        public static double CalculatePerimeter(double height, double width)
        {
            return (height * 2) + (width * 2);
        }
        public override double CalculatePerimeter()
        {
            return CalculatePerimeter(_height, _height);
        }

        public static bool operator <= (Rectangle FirstBorn, Rectangle SecondBorn)
        {
            if (FirstBorn.CalculatePerimeter() <= SecondBorn.CalculatePerimeter())
                return true;
            return false;
        }
        public static bool operator >=(Rectangle FirstBorn, Rectangle SecondBorn)
        {
            if (FirstBorn.CalculatePerimeter() >= SecondBorn.CalculatePerimeter())
                return true;
            return false;
        }
        public static bool operator < (Rectangle FirstBorn, Rectangle SecondBorn)
        {
            if (FirstBorn.CalculatePerimeter() < SecondBorn.CalculatePerimeter())
                return true;
            return false;
        }
        public static bool operator > (Rectangle FirstBorn, Rectangle SecondBorn)
        {
            if (FirstBorn.CalculatePerimeter() > SecondBorn.CalculatePerimeter())
                return true;
            return false;
        }
        public static bool operator ==(Rectangle FirstBorn, Rectangle SecondBorn)
        {
            if (FirstBorn.CalculatePerimeter() == SecondBorn.CalculatePerimeter())
                return true;
            return false;
        }
        public static bool operator !=(Rectangle FirstBorn, Rectangle SecondBorn)
        {
            if (FirstBorn.CalculatePerimeter() != SecondBorn.CalculatePerimeter())
                return true;
            return false;
        }
    }

}