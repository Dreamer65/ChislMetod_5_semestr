namespace Block_3
{

    enum SoLEStatus
    {
        Ok,
        WrongSize,
        NoAnswer
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
            Swaping();

            if (Status != SoLEStatus.Ok)
                return null;

            double[,] main = Main;
            double[] left = Left;

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
                for (int i = q-1; i >= 0; i--)
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
                        Status = SoLEStatus.NoAnswer;
                    }
                }
            }

            Main = main;
            Left = left;
        }
    }
}
