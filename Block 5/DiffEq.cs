using System.Collections.Generic;
using Math = MyFunctions.Math;

namespace Block_5
{
    public delegate double FuncDiff(double x, double y);

    static class DiffEq
    {

        public static List<double> Eiler(Math.Interval interval, FuncDiff func, double y0)
        {
            if (!interval.isValid) return null;

            double deltaY, yNext;
            List<double> result = new List<double>();

            foreach (double x in interval.Points)
            {
                deltaY = interval.Step * func(x, y0);
                yNext = y0 + deltaY;
                result.Add(y0);
                y0 = yNext;
            }

            return result;
        }

        public static List<double> EilerPlus(ref Math.Interval interval, FuncDiff func, double y0)
        {
            if (!interval.isValid) return null;

            double deltaY, yNext, yPrev;
            List<double> result = new List<double>();

            yPrev = y0;
            bool parity = true;
            interval.PointsCount = interval.PointsCount * 2 - 1;
            foreach (double x in interval.Points)
            {
                if (parity)
                {
                    deltaY = interval.Step * func(x, y0);
                    yNext = y0 + deltaY;
                }
                else
                {
                    deltaY = 2 * interval.Step * func(x, y0);
                    yNext = yPrev + deltaY;
                }

                result.Add(y0);
                yPrev = y0;
                y0 = yNext;
                parity = !parity;
            }

            return result;
        }

        public static List<double> RungeKut(Math.Interval interval, FuncDiff func, double y0)
        {
            if (!interval.isValid) return null;

            double deltaY, yNext, yPrev;
            List<double> result = new List<double>();

            yPrev = y0;
            double k1, k2, k3, k4;
            foreach (double x in interval.Points)
            {
                k1 = interval.Step * func(x, y0);
                k2 = interval.Step * func(x + (interval.Step / 2), y0 + (k1 / 2));
                k3 = interval.Step * func(x + (interval.Step / 2), y0 + (k2 / 2));
                k4 = interval.Step * func(x + interval.Step, y0 + k3);
                deltaY = (k1 + 2 * k2 + 2 * k3 + k4);
                deltaY /= 6;

                yNext = y0 + deltaY;
                result.Add(y0);
                y0 = yNext;
            }

            return result;
        }
    }
}
