using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal abstract class Shape
    {
        bool isHoley;
        string color;

        protected Shape(bool isHoley, string color)
        {
            this.isHoley = isHoley;
            this.color = color;
        }

        protected Shape(string color)
        {
            this.isHoley = false;
            this.color = color;
        }

        public string Color { get => color; set => color = value; }

        protected void MakeHoley()
        {
            isHoley = true;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return $"{color} - {isHoley} - K: {Perimeter()} - T: {Area()}";
        }
    }
}
