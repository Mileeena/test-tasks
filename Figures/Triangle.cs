using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        private double SideA { get; }
        private double SideB { get; }
        private double SideC { get; }
        public double Perimeter => SideA + SideB + SideC;
        public override double Area => Math.Sqrt((Perimeter / 2) * ((Perimeter / 2) - SideA) * 
                                                ((Perimeter / 2) - SideB) * ((Perimeter / 2) - SideC));
        public bool IsRight => ((Math.Pow(SideA,2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)) || 
                                (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2)) || 
                                (Math.Pow(SideC, 2)) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2)) ? true : false;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if ((sideA <= 0 || sideB <= 0 || sideC <= 0))
            {
                throw new ArgumentException("Стороны должны быть больше 0");
            }
            else if ((sideA >= sideB + sideC) || (sideB >= sideA + sideC) || (sideC >= sideA + sideB))
            {
                throw new ArgumentException("Треугольник с такими сторонами не может существовать");
            }

            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
    }
}