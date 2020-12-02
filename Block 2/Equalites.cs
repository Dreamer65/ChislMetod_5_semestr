using Math = MyFunctions.Math;

namespace ChislMethod_5_Semestr
{
    static class Equalites
    {
        public static double Dichotomy(Func polynom, Interval interval, double accuracy)
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

        public static double Hords(Func polynom, Func diff2, Interval interval, double accuracy)
        {
            double border, root;
            if (diff2(interval.A) * polynom(interval.A) > 0)
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

    }



}
