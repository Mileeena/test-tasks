using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresTests
{
    [TestClass]
    public class RectangleTests
    {
        /// <summary>
        /// Тест на вычисление площади
        /// </summary>
        [TestMethod]
        public void Area_3and4_14Return()
        {
            //arrange
            double a = 3;
            double b = 4;
            double expected = 14;
            //act
            Rectangle rectangle = new Rectangle(a,b);
            double actual = rectangle.Area;
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест на ошибки аргументов
        /// </summary>
        [TestMethod]
        public void TriangleCreationExeption()
        {
            //assert
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(3,-5));
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(-3, 5));
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(0, 5));
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(3, 0));
        }
    }
}
