using System;

namespace ClassLibraryArea
{
    public class AreaСalculation
    {
        //Площадь круга
        public double CircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        //Площадь треугольника
        public double TriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
