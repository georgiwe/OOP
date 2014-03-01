namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            protected set
            {
                CheckForZero(value);

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            protected set
            {
                CheckForZero(value);

                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        protected static void CheckForZero(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException();
            }
        }
    }
}
