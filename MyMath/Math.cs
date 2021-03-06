﻿using System.Collections.Generic;

namespace MyFunctions
{
    public static class Math
    {

        public const double PI = System.Math.PI;
        public static long Factor(int number)
        {
            if (number <= 1)
                return 1;
            long result = 1;
            for (int i = 2; i <= number; i++)
                result *= i;
            return result;
        }

        public static double Pow(double x, double pow)
        {
            double result = 1;
            while (pow != 0)
            {
                result = (pow > 0) ? result * x : result / x;
                pow = (pow > 0) ? pow - 1 : pow + 1;
            }
            return result;
        }

        static public double Exp(double x)
        {

            if (x == 0) return 1;
            bool minus = false;

            double accuracy = 0.000000000000001;

            if (x < 0)
            {
                minus = true;
                x *= -1;
            }

            double result = 1 + x;
            double element = x;
            double element1;

            int i = 1;
            do
            {
                element1 = element * x / (i + 1);
                result += element1;
                element = element1;
                i++;
            } while (element > accuracy);

            if (minus) result = 1 / result;

            return result;
        }

        static public double Abs(double x)
        {
            return (x < 0) ? -x : x;
        }

        static public double Max(params double[] values)
        {
            double tmp = values[0];
            foreach (double item in values)
            {
                if (item > tmp)
                    tmp = item;

            }
            return tmp;
        }

        static public double Sqrt(double d) => System.Math.Sqrt(d);

        public struct Interval
        {
            public Interval(double A, double B)
            {
                this.A = A;
                this.B = B;
                this.PointsCount = 0;
            }

            public Interval(double A, double B, int pointsCount)
            {
                this.A = A;
                this.B = B;
                this.PointsCount = pointsCount;
            }
            public double A { set; get; }

            public double B { set; get; }

            public int PointsCount { set; get; }

            public List<double> Points
            {
                get
                {
                    if (!this.isValid) return null;
                    List<double> result = new List<double>();
                    for (double i = this.A; i < this.B && this.B - i > Step/2; i += Step)
                        result.Add(i);
                    result.Add(this.B);
                    return result;
                }
            }

            public double Step
            {
                get { return Math.Abs(B - A) / (PointsCount - 1); }
            }
            public bool isValid
            {
                get { return A < B; }
            }


        }


    }
}
