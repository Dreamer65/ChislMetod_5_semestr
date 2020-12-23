using System.Collections.Generic;
using Math = MyFunctions.Math;

namespace Block_6
{
    public delegate double Func(double x);
    static class Integral
    {
        public static double Rectangle(Func func, Math.Interval interval)
        {
            if (!interval.isValid) return double.NaN;

            double result = 0;
            List<double> x = interval.Points;

            for (int i = 0; i < x.Count - 1; i++)
            {
                result += func(x[i] + interval.Step * 0.5);
            }

            return result * interval.Step;
        }

        public static double Trapezoid(Func func, Math.Interval interval)
        {
            if (!interval.isValid) return double.NaN;

            double result = (func(interval.A) + func(interval.B)) / 2;
            List<double> x = interval.Points;

            for (int i = 1; i < x.Count - 1; i++)
            {
                result += func(x[i]);
            }

            return result * interval.Step;
        }

        public static double Simpson(Func func, Math.Interval interval)
        {
            if (!interval.isValid) return double.NaN;

            if (interval.PointsCount % 2 == 0) interval.PointsCount += 1;
            double result = func(interval.A) + func(interval.B);
            List<double> x = interval.Points;

            double tmp1 = 0;
            double tmp2 = 0;

            for (int i = 1; i < x.Count - 1; i++)
            {
                if (i % 2 != 0)
                {
                    tmp1 += func(x[i]);
                }
                else
                {
                    tmp2 += func(x[i]);
                }
            }
            result += 4 * tmp1 + 2 * tmp2;

            return result * interval.Step / 3;
        }
    }
}
