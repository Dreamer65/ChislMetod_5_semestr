using Math = MyFunctions.Math;

namespace ChislMethod_5_Semestr
{
    static class Equalites
    {
        public static double Dichotomy(Func polynom, Math.Interval interval, double accuracy)
        {
            double root, funcVal;
            do
            {
                root = (interval.A + interval.B) / 2;
                funcVal = polynom(root);
                if (funcVal == 0) break;
                if (polynom(interval.A) * funcVal < 0)
                {
                    interval.B = root;
                }
                else
                {
                    interval.A = root;
                }
            } while (Math.Abs(interval.A - interval.B) >= accuracy);

            return root;
        }

        public static double Hords(Func polynom, Func d2x, Math.Interval interval, double accuracy)
        {
            double border, root;
            if (d2x(interval.A) * polynom(interval.A) > 0)
            {
                do
                {
                    border = interval.B;
                    interval.B = interval.B - ((interval.B - interval.A) * polynom(interval.B)) / (polynom(interval.B) - polynom(interval.A));
                    root = interval.B;
                } while (Math.Abs(interval.B - border) >= accuracy);
            }
            else
            {
                do
                {
                    border = interval.A;
                    interval.A = interval.A - ((interval.B - interval.A) * polynom(interval.A)) / (polynom(interval.B) - polynom(interval.A));
                    root = interval.A;
                } while (Math.Abs(interval.A - border) >= accuracy);
            }
            return root;
        }

        public static double Tangent(Func polynom, Func dx, Func d2x, Math.Interval interval, double accuracy)
        {
            double point, root;
            if (polynom(interval.A) * d2x(interval.A) > 0)
            {
                do
                {
                    point = interval.A;
                    interval.A = point - polynom(point) / dx(point);
                    root = interval.A;
                }
                while (Math.Abs(interval.A - point) >= accuracy);
            }
            else
            {
                do
                {
                    point = interval.B;
                    interval.B = point - polynom(point) / dx(point);
                    root = interval.B;
                }
                while (Math.Abs(interval.B - point) >= accuracy);
            }
            return root;
        }

        public static double Iteration(Func polynom, Func dx, Math.Interval interval, double accuracy)
        {
            double xk = interval.A; 
            double x;
            double dxMin, dxMax;
            double lyambda;
            dxMin = dxMax = dx(interval.A);
            for (double i = interval.A; i < interval.B; i += accuracy)
            {
                if (dxMin > dx(i)) dxMin = dx(i);

                if (dxMax < dx(i)) dxMax = dx(i);
            }
            if (dxMax <= 3 * dxMin)
                lyambda = 1.25 / dxMax;
            else
                lyambda = 1 / dxMax;
            do
            {
                x = xk;
                xk = x - lyambda * polynom(x);
            }
            while (Math.Abs(x - xk) >= accuracy);
            return xk;
        }

    }



}
