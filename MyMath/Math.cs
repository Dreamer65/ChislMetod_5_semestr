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

        public struct Interval
        {
            public Interval(double A, double B)
            {
                if (A <= B)
                {
                    this.A = A;
                    this.B = B;
                }
                else
                {
                    this.A = B;
                    this.B = A;
                }
                this.Points = 0;
            }

            public Interval(double A, double B, int points)
            {
                if (A <= B)
                {
                    this.A = A;
                    this.B = B;
                }
                else
                {
                    this.A = B;
                    this.B = A;
                }
                this.Points = points;
            }
            public double A { set; get; }

            public double B { set; get; }

            public int Points { set; get; }

            public double Step
            {
                get { return (B - A) / Points; }
            }
            public bool isValid
            {
                get { return A < B; }
            }


        }


    }
}
