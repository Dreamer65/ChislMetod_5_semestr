using System;
using System.Windows.Forms;
using Math = MyFunctions.Math;
using Eq = ChislMethod_5_Semestr.Equalites;

namespace ChislMethod_5_Semestr
{
    public partial class Form1 : Form
    {

        Math.Interval chartInterval;
        Math.Interval rootInterval;
        double rootAccuracy;
        public static double Polindrome(double x)
        {
            return 2 * Math.Pow(x, 3) + Math.Pow(x, 2) - 15 * x + 10;
        }

        public static double Pol_Dx(double x)
        {
            return 6 * Math.Pow(x, 2) + 2 * x - 15;
        }
        public static double Pol_D2x(double x)
        {
            return 12 * x + 2;
        }

        public Form1()
        {
            InitializeComponent();
            chartInterval = new Math.Interval(-2, 2);
            rootInterval = new Math.Interval(-2, 2);
            tbA.Text = (-2).ToString();
            tbB.Text = (2).ToString();
            tbRootA.Text = (-2).ToString();
            tbRootB.Text = (2).ToString();
            rootAccuracy = 0.001;
            tbRootAccuracy.Text = rootAccuracy.ToString();
        }

        private void DrawChart(Math.Interval interval, double step)
        {
            if (!interval.isValid) return;
            chPolindrome.Series[0].Points.Clear();
            for (double i = interval.A; i <= interval.B + step; i += step)
                chPolindrome.Series[0].Points.AddXY(i, Polindrome(i));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawChart(chartInterval, 0.1);
        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!double.TryParse(tbA.Text, out a))
                return;
            chartInterval.A = a;
            DrawChart(chartInterval, 0.1);
        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {
            double b;
            if (!double.TryParse(tbB.Text, out b))
                return;
            chartInterval.B = b;
            DrawChart(chartInterval, 0.1);
        }

        private void tbRootA_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!double.TryParse(tbRootA.Text, out a))
                return;
            rootInterval.A = a;
        }

        public bool Verification(Func polynom, Math.Interval interval, Label tbResult)
        {
            if (polynom(interval.A) == 0)
            {
                tbResult.Text = interval.A.ToString();
                return false;
            }
            if (polynom(interval.B) == 0)
            {
                tbResult.Text = interval.B.ToString();
                return false;
            }
            if (polynom(interval.A) * polynom(interval.B) > 0)
            {
                tbResult.Text = "Нет корня";
                return false;
            }
            if (!interval.isValid)
            {
                tbResult.Text = "Неверно указан интервал";
                return false;
            }
            return true;
        }

        private void tbRootB_TextChanged(object sender, EventArgs e)
        {
            double b;
            if (!double.TryParse(tbRootB.Text, out b))
                return;
            rootInterval.B = b;
        }
        private void tbRootAccuracy_TextChanged(object sender, EventArgs e)
        {
            double acc;
            if (!double.TryParse(tbRootAccuracy.Text, out acc))
                return;
            rootAccuracy = acc;
        }

        private void pbDihotomy_Click(object sender, EventArgs e)
        {
            if (!Verification(Polindrome, rootInterval, lbDihotomyRoot)) return;

            lbDihotomyRoot.Text = Eq.Dichotomy(Polindrome, rootInterval, rootAccuracy).ToString();

        }

        private void pbHords_Click(object sender, EventArgs e)
        {
            if (!Verification(Polindrome, rootInterval, lbHordsRoot)) return;

            lbHordsRoot.Text = Eq.Hords(Polindrome, Pol_D2x,  rootInterval, rootAccuracy).ToString();
        }

        private void pbTangent_Click(object sender, EventArgs e)
        {
            if (!Verification(Polindrome, rootInterval, lbTangentRoot)) return;

            lbTangentRoot.Text = Eq.Tangent(Polindrome, Pol_Dx, Pol_D2x, rootInterval, rootAccuracy).ToString();
        }

        private void pbIter_Click(object sender, EventArgs e)
        {
            if (!Verification(Polindrome, rootInterval, lbIterRoot)) return;

            lbIterRoot.Text = Eq.Iteration(Polindrome, Pol_Dx, rootInterval, rootAccuracy).ToString();
        }
    }


    public delegate double Func(double x);
}
