using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Mindbox_Library
{
    public class Circle : IFigure
    {
        public double R { get; private set; }

        public Circle(double R)
        {
            this.R = R;
        }

        //вычисление площади
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
