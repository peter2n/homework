using System;

namespace EX_1_ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                {
                    //throw new ArgumentException(nameof(Length), "Lenght cannot be zero or negative.");
                    Console.WriteLine("Lenght cannot be zero or negative.");
                    Environment.Exit(1);

                }
                length = value;
            }
        }
        public double Width
        {
            get => width;
            private set
            {
                if (value < +0)
                {
                    //throw new ArgumentException(nameof(Width), "Width cannot be zero or negative.");
                    Console.WriteLine("Width cannot be zero or negative.");
                    Environment.Exit(1);
                }
                width = value;
            }
        }

        public double Height
        {
            get => height;
            private set

            {
                if (value <= 0)
                {
                    //throw new ArgumentException(nameof(Height), "Height cannot be zero or negative.");
                    Console.WriteLine("Height cannot be zero or negative.");
                    Environment.Exit(1);

                }
                height = value;
            }
        }

        public double CalcSurfaceArea()
        {
            return 2 * (Length * Width + Length * Height + Width * Height );
        }

        public double CalcLateralSurfaceArea()
        {
            return 2 * (Height  * Width + Length * Height);
        }

        public double CalcVolume()
        {
            return Length * Width * Height;
        }
    }
}
