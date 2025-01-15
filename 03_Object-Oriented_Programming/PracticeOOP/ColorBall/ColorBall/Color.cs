using System;

namespace ColorBall
{
    public class Color
    {
        // Instance variables
        private int red;
        private int green;
        private int blue;
        private int alpha;

        // Constructor with red, green, blue, and alpha
        public Color(int red, int green, int blue, int alpha)
        {
            this.red = ValidateColorValue(red);
            this.green = ValidateColorValue(green);
            this.blue = ValidateColorValue(blue);
            this.alpha = ValidateColorValue(alpha);
        }

        // Constructor with red, green, blue (alpha defaults to 255)
        public Color(int red, int green, int blue) : this(red, green, blue, 255)
        {
        }

        // Properties with getters and setters
        public int Red
        {
            get { return red; }
            set { red = ValidateColorValue(value); }
        }

        public int Green
        {
            get { return green; }
            set { green = ValidateColorValue(value); }
        }

        public int Blue
        {
            get { return blue; }
            set { blue = ValidateColorValue(value); }
        }

        public int Alpha
        {
            get { return alpha; }
            set { alpha = ValidateColorValue(value); }
        }

        // Method to calculate grayscale value
        public double GetGrayscale()
        {
            return (red + green + blue) / 3.0;
        }

        // Helper method to validate color values
        private int ValidateColorValue(int value)
        {
            if(value < 0 || value > 255)
                throw new ArgumentOutOfRangeException(nameof(value), "Color values must be between 0 and 255.");
            return value;
        }
    }
}
