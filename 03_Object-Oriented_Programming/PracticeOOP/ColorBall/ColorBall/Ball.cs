using System;

namespace ColorBall
{
    public class Ball
    {
        // Instance variables
        private double size;
        private Color color;
        private int throwCount;

        // Constructor
        public Ball(double size, Color color)
        {
            if(size < 0)
                throw new ArgumentOutOfRangeException(nameof(size), "Size cannot be negative.");
            this.size = size;
            this.color = color ?? throw new ArgumentNullException(nameof(color));
            this.throwCount = 0;
        }

        // Property to get size
        public double Size
        {
            get { return size; }
            private set
            {
                if(value < 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "Size cannot be negative.");
                size = value;
            }
        }

        // Property to get color
        public Color Color
        {
            get { return color; }
        }

        // Method to pop the ball
        public void Pop()
        {
            size = 0;
        }

        // Method to throw the ball
        public void Throw()
        {
            if(size > 0)
                throwCount++;
            else
                Console.WriteLine("Cannot throw a popped ball.");
        }

        // Method to get the throw count
        public int GetThrowCount()
        {
            return throwCount;
        }
    }
}