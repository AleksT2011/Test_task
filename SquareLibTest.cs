using System;
using Xunit;
using SquareLib;

namespace SquareLibTest
{
    public class SquareLibTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void Circle_Square_Exception(double radius)
        {
            //arrange
            //act
            //assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(10, 100 * Math.PI)]
        public void Circle_Square(double radius, double expected)
        {
            //arrange
            Figure fig = new Circle(radius);

            //act
            double actual = fig.getSquare();

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 20, 30)]
        [InlineData(0, 20, 30)]
        [InlineData(10, 0, 30)]
        [InlineData(10, 20, 0)]
        [InlineData(-10, 20, 30)]
        [InlineData(10, -20, 30)]
        [InlineData(10, 20, -30)]
        public void Triangle_Square_Exception(double a, double b, double c)
        {
            //arrange
            //act
            //assert
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Theory]
        [InlineData(6, 8, 10, 24)]
        [InlineData(3, 4, 5, 6)]
        public void Triangle_Square(double a, double b, double c, double expected)
        {
            //arrange
            Figure fig = new Triangle(a, b, c);

            //act
            double actual = fig.getSquare();

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 8, 10)]
        [InlineData(3, 4, 5)]
        public void Triangle_isRight_true(double a, double b, double c)
        {
            //arrange
            Triangle fig = new Triangle(a, b, c);
            bool expected = true;

            //act
            bool actual = fig.isRight();

            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 8, 9)]   //зашли в ветку
        [InlineData(6, 8, 8)]   //прошли все ветки и вышли по умолчанию
        public void Triangle_isRight_false(double a, double b, double c)
        {
            //arrange
            Triangle fig = new Triangle(a, b, c);
            bool expected = false;

            //act
            bool actual = fig.isRight();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
