using System;

namespace Test_Mindbox_Library
{
    //интерфейс фигуры
    public interface IFigure
    {
        double CalculateArea();
    }

    //обобщённый класс фигур
    public class Figure
    {
        //вычисление площади фигуры
        public static double CalculateArea(params double[] sides)
        {
            if (IsCircle(sides)) 
            {
                return Math.PI * Math.Pow(sides[0], 2);
            }
            if (IsTriangle(sides))
            {
                double p = (sides[0] + sides[1] + sides[2]) / 2; //полупериметр
                return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2])); //ф-ла Герона
            }

            return 0; //если неопред-ая фигура
        }
    
        //круг - если передан только радиус
        public static bool IsCircle(double[] d)
        {
            return d.Length == 1;
        }
        //треугольник - если передано 3 стороны
        public static bool IsTriangle(double[] d)
        {
            return d.Length == 3;
        }
    }
}
