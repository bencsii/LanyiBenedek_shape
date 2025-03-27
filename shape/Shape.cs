using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal abstract class Shape
    {
        bool isHoley;
        string color;

        public string Color { get => color; set => color = value; }

        protected Shape(string color, bool isHoley = false)
        {
            this.isHoley = isHoley;
            this.color = color;
        }

        protected Shape(string color)
        {
            this.color = color;
            isHoley = false;
        }

        public void MakeHoley()
        {
            isHoley = true;
        }


        public abstract double Perimeter();
        public abstract double Area();


        public override string? ToString()
        {
            return $"Color: {color}\nIsHoley: {isHoley}\n\t-Perimeter: {Perimeter()}\n\t-Area: {Area()}";
        }

    }
}
