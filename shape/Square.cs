using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Square : Rectangle
    {
        public double Height { get => Height; set => Height = value; }
        public double Width { get => Width; set => Width = value; }
        public Square(bool isHoley, string color, double height, double width) : base(isHoley, color, height, width)
        {
        }

        public override string? ToString()
        {
            string toString = base.ToString();
            return toString.Remove(toString.Length - ("Rectangle".ToCharArray().Length)) + "Square";
        }
    }
}
