using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Circle : Shape
    {
        double radius;
        public double Radius { get => radius; set => radius = value; }

        public Circle(string color, double radius, bool isHoley = false) : base(color, isHoley)
        {
            this.radius = radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string? ToString()
        {
            return base.ToString() + "\n- Circle";
        }
    }
}
