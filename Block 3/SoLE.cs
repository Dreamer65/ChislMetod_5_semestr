using Math = MyFunctions.Math;

namespace Block_3
{

    enum SoLEStatus
    {
        Ok,
        WrongSize,
        NoAnswer,
        Divergence,
        ZeroDeterminant,
        ZeroesOnMain
    }

    class SoLE
    {
        public SoLE(double[,] main, double[] left)
        {
            Main = (double[,])main.Clone();
            Left = (double[])left.Clone();

            if (main.GetLength(0) != main.GetLength(1))
            {
                Status = SoLEStatus.WrongSize;
            }
            else if (main.GetLength(0) != left.Length)
            {
                Status = SoLEStatus.WrongSize;
            }
            else
                Status = SoLEStatus.Ok;
        }

        public SoLEStatus Status { get; private set; }

        double[,] _main;
        public double[,] Main
        {
            set
            {
                Status = (value.GetLength(0) != value.GetLength(1)) ? SoLEStatus.WrongSize : SoLEStatus.Ok;
                _main = value;
            }
            get => (double[,])_main.Clone();
        }

        double[] _left;
        public double[] Left
        {
            set
            {
                Status = (value.Length != Main.GetLength(0)) ? SoLEStatus.WrongSize : SoLEStatus.Ok;
                _left = value;
            }
            get => (double[])_left.Clone();
        }

        public double[] SolveGause()
        {
            Status = SoLEStatus.Ok;

            double[,] main = Main;
            double[] left = Left;
            double det = Determinant(main);
            if(det == 0)
            {
                Status = SoLEStatus.ZeroDeterminant;
                return null;
            }
            
            Swaping();

            if (Status != SoLEStatus.Ok)
                return null;



            double v;
            for (int q = 0; q < Size; q++)
            {
                v = main[q, q];
                if (v == 0)
                {
                    Status = SoLEStatus.NoAnswer;
                    return null;
                }
                left[q] /= v;
                for (int k = 0; k < Size; k++)
                    main[q, k] /= v;

                for (int i = q + 1; i < Size; i++)
                {
                    v = main[i, q];
                    left[i] -= left[q] * v;
                    for (int k = q; k < Size; k++)
                        main[i, k] -= main[q, k] * v;
                }
            }
            for (int q = Size - 1; q >= 0; q--)
            {
                for (int i = q - 1; i >= 0; i--)
                {
                    v = main[i, q];
                    if (v == 0) continue;

                    left[i] -= left[q] * v;
                    main[i, q] -= main[q, q] * v;
                }
            }

            return left;
        }

        private int Size { get => _left.Length; }

        private void Swaping()
        {
            if (Status != SoLEStatus.Ok)
                return;

            double[,] main = Main;
            double[] left = Left;


            for (int i = 0; i < Size; i++)
            {
                if (main[i, i] == 0)
                {
                    int j = i + 1;
                    while (j < Size && main[j, i] == 0)
                        j++;
                    if (j < Size && main[j, i] != 0)
                    {
                        double tmp;

                        tmp = left[j];
                        left[j] = left[i];
                        left[i] = tmp;

                        for (int k = 0; k < Size; k++)
                        {
                            tmp = main[j, k];
                            main[j, k] = main[i, k];
                            main[i, k] = tmp;
                        }
                    }
                    else
                    {
                        Status = SoLEStatus.ZeroesOnMain;
                    }
                }
            }

            Main = main;
            Left = left;
        }

        public double[] Zeidel(double accuracy)
        {
            Status = SoLEStatus.Ok;

            double[] LastIter = new double[Size];
            double[] matrixX = new double[Size];

            double[,] main = Main;
            double[] left = Left;

            Swaping();

            if (Status != SoLEStatus.Ok)
                return null;

            if (Convergence())
            {
                do
                {
                    for (int i = 0; i < Size; i++) LastIter[i] = matrixX[i];
                    for (int i = 0; i < Size; i++)
                    {
                        double temp = 0;
                        for (int j = 0; j < i; j++) temp += main[i, j] * matrixX[j];
                        for (int j = i + 1; j < Size; j++) temp += main[i, j] * LastIter[j];
                        matrixX[i] = (left[i] - temp) / main[i, i];
                    }
                }
                while (!Termination(matrixX, LastIter, accuracy));
            }

            return matrixX;
        }

        private bool Convergence()
        {

            double[,] main = Main;
            double[] left = Left;
            for (int i = 0; i < Size; i++)
            {
                left[i] /= main[i, i];
                for (int j = 0; j < Size; j++)
                {
                    if(i != j) main[i, j] /= -main[i, i];
                }
                main[i, i] = 0;
            }
            double sum = 0, m = 0, max = 0;
            for (int i = 0; i < Size; i++)
            {
                m += Math.Abs(main[0, i]);
            }
            for (int i = 1; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    sum += Math.Abs(main[i, j]);
                }
                max = Math.Max(m, sum);
            }
            return (max < 1);
        }

        public bool Termination(double[] xk, double[] xkk, double accuracy)
        {
            double norm = 0, norm2 = 0;
            for (int i = 0; i < Size; i++) norm += (xk[i] - xkk[i]) * (xk[i] - xkk[i]);
            for (int i = 0; i < Size; i++) norm2 += xk[i] * xk[i];
            return (Math.Sqrt(norm) / Math.Sqrt(norm2) <= accuracy);
        }

        private int Abs(int x){ return x >= 0 ? x : -x; }

        private double Determinant(double[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) return double.NaN;

            double result = 0;
            double diag;
            
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                diag = 1;
                for(int j = 0; j < size; j++)
                {
                    diag *= matrix[j, (i + j) % size];  
                }
                result += diag;
            }

            for (int i = size; i >= 0; i--)
            {
                diag = 1;
                for (int j = 0; j < size; j++)
                {
                    diag *= matrix[j, Abs((i - j) % size)];
                }
                result -= diag;
            }

            return result;
        }

    }
}
