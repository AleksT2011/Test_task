using System;
using Xunit;
using SquareLib;

namespace SquareLibTest
{
    public class UnitTest1
    {
        [Fact]
        public void Circle_Square_0_0()
        {
            //arrange
            Figure fig = new Circle(0);
            double expected = 0;

            //act
            double actual = fig.getSquare();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Circle_Square_1_pi()
        {
            //arrange
            Figure fig = new Circle(1);
            double expected = Math.PI;

            //act
            double actual = fig.getSquare();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Circle_Square_10_100PI()
        {
            //arrange
            Figure fig = new Circle(10);
            double expected = Math.PI * 100;

            //act
            double actual = fig.getSquare();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_Square_10_20_30_0()
        {
            //arrange
            Figure fig = new Triangle(10, 20, 30);
            double expected = 0;

            //act
            double actual = fig.getSquare();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_Square_6_8_10_24()
        {
            //arrange
            Figure fig = new Triangle(6, 8, 10);
            double expected = 24;

            //act
            double actual = fig.getSquare();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_isRight_true()
        {
            //arrange
            Triangle fig = new Triangle(6, 8, 10);
            bool expected = true;

            //act
            bool actual = fig.isRight();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_isRight_false_condition()
        {
            //arrange
            Triangle fig = new Triangle(6, 8, 9);
            bool expected = false;

            //act
            bool actual = fig.isRight();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_isRight_false_default()
        {
            //arrange
            Triangle fig = new Triangle(6, 8, 8);
            bool expected = false;

            //act
            bool actual = fig.isRight();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
