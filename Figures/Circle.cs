using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Figure
    {
        private double Radius { get; }
        public override double Area => Math.PI * Math.Pow(Radius, 2);
        public Circle(double radius)
        {
            if (radius<0)
            {
                throw new ArgumentException("Радиус должен быть положительным");
            }
            this.Radius = radius;
        }
    }
}
