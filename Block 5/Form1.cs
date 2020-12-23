using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Math = MyFunctions.Math;

namespace Block_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public double DiffEqFunc(double x, double y)
        {
            return y - (2 * x / y);
        }

        private void pbEiler_Click(object sender, EventArgs e)
        {
            Math.Interval interval = ReadParametrs();
            if (!interval.isValid) return;

            double y0;
            if (!double.TryParse(tbY0.Text, out y0))
            {
                MessageBox.Show("Неверно указана начальная точка");
            }

            List<double> solution = DiffEq.Eiler(interval, DiffEqFunc, y0);
            if (solution == null)
            {
                MessageBox.Show("Произошла ошибка");
            }

            FillDGV(interval.Points, solution, dgvResult);
        }


        private Math.Interval ReadParametrs()
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
            if (!int.TryParse(tbPoints.Text, out count))
            {
                MessageBox.Show("Неверно указано количество точек");
                return new Math.Interval();
            }

            return new Math.Interval(a, b, count);

        }

        private void FillDGV(List<double> X, List<double> Y, DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();
            dataGrid.Columns.Add("X", "X");
            dataGrid.Columns.Add("Y", "Y");

            dataGrid.Columns["X"].Width = (dataGrid.Width - 25) / 2;
            dataGrid.Columns["Y"].Width = (dataGrid.Width - 25) / 2;

            int count = (X.Count <= Y.Count) ? X.Count : Y.Count;
            dataGrid.Rows.Add(count);
            for (int i = 0; i < count; i++)
            {
                dataGrid.Rows[i].Cells["X"].Value = X[i];
                dataGrid.Rows[i].Cells["Y"].Value = Y[i];
            }
        }

        private void pbEilerPlus_Click(object sender, EventArgs e)
        {
            Math.Interval interval = ReadParametrs();
            if (!interval.isValid) return;

            double y0;
            if (!double.TryParse(tbY0.Text, out y0))
            {
                MessageBox.Show("Неверно указана начальная точка");
            }

            List<double> solution = DiffEq.EilerPlus(ref interval, DiffEqFunc, y0);
            if (solution == null)
            {
                MessageBox.Show("Произошла ошибка");
            }

            FillDGV(interval.Points, solution, dgvResult);
        }

        private void pbRungeKutt_Click(object sender, EventArgs e)
        {
            Math.Interval interval = ReadParametrs();
            if (!interval.isValid) return;

            double y0;
            if (!double.TryParse(tbY0.Text, out y0))
            {
                MessageBox.Show("Неверно указана начальная точка");
            }

            List<double> solution = DiffEq.RungeKut(interval, DiffEqFunc, y0);
            if (solution == null)
            {
                MessageBox.Show("Произошла ошибка");
            }

            FillDGV(interval.Points, solution, dgvResult);
        }
    }
}
