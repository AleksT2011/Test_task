using System;

namespace SquareLib
{
    //класс фигуры
    public abstract class Figure
    {
        //получение площади фигуры
        public abstract double getSquare();
    }

    //класс треугольника
    public class Triangle : Figure
    {
        //длины сторон треугольника
        double a;
        double b;
        double c;

        //конструктор класса
        public Triangle(double pA, double pB, double pC)
        {
            a = pA;
            b = pB;
            c = pC;
        }

        //вычисление площади по трем сторонам (формула Герона)
        public override double getSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //проверка теоремы Пифагора
        private bool calcPifagore(double hypotenuse, double cathetus_1, double cathetus_2)
        {
            return Math.Pow(hypotenuse, 2) == Math.Pow(cathetus_1, 2) + Math.Pow(cathetus_2, 2);
        }

        //проверка, является ли треугольник прямоугольным
        public bool isRight()
        {
            if (a > b && a > c)
                return calcPifagore(a, b, c);

            if (b > a && b > c)
                return calcPifagore(b, a, c);

            if (c > a && c > b)
                return calcPifagore(c, a, b);

            return false;
        }
    }

    //класс круга
    public class Circle : Figure
    {
        //радиус круга
        double radius;

        //конструктор класса
        public Circle(double pRadius)
        {
            radius = pRadius;
        }

        //вычисление площади круга
        public override double getSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
