using Math = MyFunctions.Math;

namespace Block_4
{
    struct Points
    {
        private double[] x;
        private double[] y;

        public Points(int size)
        {
            x = new double[size];
            y = new double[size];
            Size = size;
        }

        public int Size { get; }
        public double[] X { get => x; }
        public double[] Y { get => y; }

        public bool IsEvenly
        {
            get
            {
                double accuracy = 0.0001;
                double delta = x[1] - x[0];
                for (int i = 1; i < Size - 1; i++)
                {
                    if (Math.Abs(x[i + 1] - x[i] - delta) > accuracy) return false;
                }
                return true;
            }
        }

        public double Step { get => (IsEvenly && Size >= 2) ? X[1] - X[0] : -1; }

        public void Sort()
        {
            double tmp;
            for (int i = 0; i < Size - 1; i++)
            {
                for (int j = i + 1; j < Size; j++)
                {
                    if (X[j] < X[j])
                    {
                        tmp = X[j];
                        X[j] = X[i];
                        X[i] = tmp;

                        tmp = Y[j];
                        Y[j] = Y[i];
                        Y[i] = tmp;
                    }
                }
            }
        }

    }
    static class Interpolation
    {
        static private double[][] NewtonDeltaY(Points points)
        {
            double[][] deltaY = new double[points.Size][];

            for (int i = 0; i < points.Size; i++) deltaY[i] = new double[points.Size];
            for (int i = 0; i < points.Size; i++) deltaY[0][i] = points.Y[i];
            for (int i = 1; i < points.Size; i++)
                for (int j = 0; j < points.Size - 1; j++)
                    deltaY[i][j] = deltaY[i - 1][j + 1] - deltaY[i - 1][j];

            return deltaY;
        }
        static public double NewtonBack(double num, Points points)
        {
            if (points.Step < 0) return double.NaN;

            double Res = points.Y[points.Size - 1];
            int fact = 1;
            double t = (num - points.X[points.Size - 1]) / points.Step;
            double mult = 1;
            double[][] deltaY = NewtonDeltaY(points);

            for (int i = 1; i < points.Size; i++)
            {
                fact *= i;
                mult *= t + i - 1;
                Res += mult / fact * deltaY[i][points.Size - i - 1];
            }

            return Res;
        }

        static public double NewtonForward(double num, Points points)
        {
            double Res = points.Y[0];
            int fact = 1;
            double t = (num - points.X[0]) / points.Step;
            double mult = 1;
            double[][] deltaY = NewtonDeltaY(points);

            for (int i = 1; i < points.Size; i++)
            {
                fact *= i;
                mult *= t - i + 1;
                Res += mult / fact * deltaY[i][0];
            }

            return Res;
        }

        static public double Lagrange(double num, Points points)
        {
            double Result = 0;
            for (int i = 0; i < points.Size; i++)
            {
                double HelpPolynom = 1;
                for (int j = 0; j < points.Size; j++)
                {
                    if (i != j)
                    {
                        HelpPolynom *= (num - points.X[j]) / (points.X[i] - points.X[j]);
                    }
                }
                Result += HelpPolynom * points.Y[i];
            }
            return Result;
        }

        static public double ReverseInterpolation(double num, Points points)
        {
            Points reverse = new Points(points.Size);

            for (int i = 0; i < points.Size; i++)
            {
                reverse.X[i] = points.Y[i];
                reverse.Y[i] = points.X[i];
            }

            reverse.Sort();

            return Lagrange(num, reverse);
        }
    }
}
