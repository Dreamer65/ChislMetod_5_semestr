using System;
using System.Windows.Forms;
using Math = MyFunctions.Math;

namespace Block_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double Function(double x)
        {
            return 1 / (x + 1);
            //return x* x;
        }

        private void pbRectangle_Click(object sender, EventArgs e)
        {
            double result = Integral.Rectangle(Function, ReadInterval());

            lbRectangleResult.Text = result.ToString();
        }

        private void pbTrapezoid_Click(object sender, EventArgs e)
        {
            double result = Integral.Trapezoid(Function, ReadInterval());

            lbTrapezoidResult.Text = result.ToString();
        }

        private Math.Interval ReadInterval()
        {
            double a, b;
            if (!double.TryParse(tbIntervalA.Text, out a))
            {
                MessageBox.Show("Неверно указана точка A");
                return new Math.Interval();
            }

            if (!double.TryParse(tbIntervalB.Text, out b))
            {
                MessageBox.Show("Неверно указана точка B");
                return new Math.Interval();
            }

            int count;
            if (!int.TryParse(tbSegmentsCount.Text, out count))
            {
                MessageBox.Show("Неверно указано количество отрезков");
                return new Math.Interval();
            }

            return new Math.Interval(a, b, count+1);

        }

        private void pbSimpson_Click(object sender, EventArgs e)
        {
            double result = Integral.Simpson(Function, ReadInterval());

            lbSimpsonResult.Text = result.ToString();
        }
    }
}
