using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public abstract class Shape
    {
        
        public abstract int CalculateArea();
        public abstract int numVerteces { get;}

        public override string ToString()
        {
            return GetType().ToString();
        }
    }

    public class Rectangle: Shape
    {
        public override int numVerteces { get; } = 4;
        public int Width { get; set; }
        public int Length { get; set; }
        public override int CalculateArea()
        {
            return Width * Length;
        }

        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;

        }

    }
}
