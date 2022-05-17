using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Mindbox_Library
{
    public class Triangle : IFigure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        
        //свойство определения прямоуг-ый ли треуг-ик
        public bool IsRectangular
        { 
            get
            {
                bool a = Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2);
                bool b = Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2);
                bool c = Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
                return a || b || c;
            } 
            private set { }
        }
            
        public Triangle(double A, double B, double C)
        {
            this.A = A; 
            this.B = B; 
            this.C = C; 
        }

        //вычисление площади
        public double CalculateArea()
        {
            double p = (A + B + C) / 2; //полупериметр
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); //ф-ла Герона
        }
    }
}
