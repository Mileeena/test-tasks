using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle : Figure
    {
        private double SideA { get; }
        private double SideB { get; }
        public override double Area => 2 * (SideA + SideB);
        public Rectangle(double sideA, double sideB)
        {
            if (sideA <= 0 || sideB <= 0)
            {
                throw new ArgumentException("Cтороны должны быть больше 0");
            }
            this.SideA = sideA;
            this.SideB = sideB;
        }
    }
}
