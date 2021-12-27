using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresTests
{
    [TestClass]
    public class CircleTests
    {
        /// <summary>
        /// Тест на вычисление площади
        /// </summary>
        [TestMethod]
        public void Area_7_153_86Return()
        {
            //arrange
            double a = 7;
            double expected = 153.93804002589985;
            //act
            Circle circle = new Circle(a);
            double actual = circle.Area;
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на отрицательный радиус
        /// </summary>
        [TestMethod]
        public void TriangleCreationExeption()
        {
            //assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(-15));
        }
    }
}
