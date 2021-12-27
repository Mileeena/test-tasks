using System;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresTests
{
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// Тест на вычисление площади
        /// </summary>
        [TestMethod]
        public void Area_3and4adn5_6Return()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.Area;
            //assert
            Assert.AreEqual(expected,actual);
        }
        /// <summary>
        /// Тест на прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void Area_3and4adn5_TrueReturn()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;
            //act
            Triangle triangle = new Triangle(a, b, c);
            bool actual = triangle.IsRight;
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
            //Отрицательная сторона
            Assert.ThrowsException<ArgumentException>(() => new Triangle(-5, 5, 5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, -5, 5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 5, -5));
            //Сторона равна 0
            Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 5, 5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 0, 5));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(5, 5, 0));
            //Треугольник не существует
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 7, 3));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(3, 7, 10));
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 5, 2));
        }
    }
}
