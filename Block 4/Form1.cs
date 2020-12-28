using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Block_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGrids();
        }

        void InitializeDataGrids()
        {
            AddColumns(dgvData, "X", "Y");
            AddRows(dgvData, 5);

            for (int i = 0; i < dgvData.Rows.Count; i++)
            {
                dgvData.Rows[i].Cells["X"].Value = i;
                dgvData.Rows[i].Cells["Y"].Value = i * i;
            }
        }

        void AddColumns(DataGridView dataGrid, params string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                dataGrid.Columns.Add(names[i], names[i]);
                NormilizeCells(dataGrid);
            }
        }

        void AddRows(DataGridView dataGrid, int count)
        {
            while (count-- > 0)
            {
                dataGrid.Rows.Add();
                NormilizeCells(dataGrid);
            }
        }

        void DelColumn(DataGridView dataGrid)
        {
            if (dataGrid.Columns.Count == 0) return;
            DataGridViewColumn column = dataGrid.Columns[dataGrid.Columns.Count - 1];
            dataGrid.Columns.Remove(column);
            NormilizeCells(dataGrid);
        }

        void DelRow(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count == 0) return;
            DataGridViewRow row = dataGrid.Rows[dataGrid.Rows.Count - 1];
            dataGrid.Rows.Remove(row);
            NormilizeCells(dataGrid);
        }

        void NormilizeCells(DataGridView dataGrid)
        {
            foreach (DataGridViewRow item in dataGrid.Rows)
            {
                item.Height = 30;
            }

            foreach (DataGridViewColumn item in dataGrid.Columns)
            {
                item.Width = dataGrid.Width / dataGrid.Columns.Count - 10;
            }
        }

        private void pbRowPlus_Click(object sender, System.EventArgs e)
        {
            AddRows(dgvData, 1);
        }

        private void pbRowMinus_Click(object sender, System.EventArgs e)
        {
            if (dgvData.Rows.Count <= 5) return;
            DelRow(dgvData);
        }

        private Points ReadDataGrid(DataGridView dataGrid)
        {
            Points points = new Points(dataGrid.Rows.Count);
            double x, y;
            for (int i = 0; i < points.Size; i++)
            {
                if (!double.TryParse(dataGrid.Rows[i].Cells["X"].Value.ToString(), out x))
                {
                    MessageBox.Show(string.Format("Ошибка ввода в {0}{1}.", "X", i));
                }
                if (!double.TryParse(dataGrid.Rows[i].Cells["Y"].Value.ToString(), out y))
                {
                    MessageBox.Show(string.Format("Ошибка ввода в {0}{1}.", "Y", i));
                }
                points.X[i] = x;
                points.Y[i] = y;
            }
            return points;
        }

        private void pbInterpolation_Click(object sender, System.EventArgs e)
        {
            Points points = ReadDataGrid(dgvData);
            double x;
            double result;

            while (!double.TryParse(Interaction.InputBox("Введите точку интерполирования", "Интерполяция", "", 100, 100), out x))
                MessageBox.Show("Ошибка ввода. Введите число.");
            if (x < points.X[0] || x > points.X[points.Size - 1])
            {
                MessageBox.Show("Точка лежит вне интервала интерполирования.");
                return;
            }

            if (rbNewton.Checked)
            {
                if (!points.IsEvenly)
                {
                    MessageBox.Show("Для интерполяции по Ньютону необходим одинаковый шаг по X.");
                    return;
                }

                if (x < (points.X[points.Size - 1] - points.X[0]) / 2)
                {
                    result = Interpolation.NewtonForward(x, points);
                    Result("Интерполяция. Ньютон (вперед)", x, result);
                }
                else
                {
                    result = Interpolation.NewtonBack(x, points);
                    Result("Интерполяция. Ньютон (назад)", x, result);
                }
            }
            else if (rbLagrange.Checked)
            {
                result = Interpolation.Lagrange(x, points);
                Result("Интерполяция. Лагранж", x, result);
            }
        }

        private void Result(string method, double x, double y)
        {
            lbResult.Text = string.Format("Результат:" + Environment.NewLine + "{0}" + Environment.NewLine + "X:{1}, Y:{2}", method, x, y);
        }

        private void pbExtrapolation_Click(object sender, EventArgs e)
        {
            Points points = ReadDataGrid(dgvData);
            double x;
            double result;

            string method = "Экстраполирование. ";

            while (!double.TryParse(Interaction.InputBox("Введите точку экстраполирования", "Экстраполирование", "", 100, 100), out x))
                MessageBox.Show("Ошибка ввода. Введите число.");
            if (!(x < points.X[0] || x > points.X[points.Size - 1]))
            {
                MessageBox.Show("Точка лежит внутри интервала.");
                method = "Интерполяция. ";
            }

            if (!points.IsEvenly)
            {
                result = Interpolation.NewtonForward(x, points);
                Result(method + "Лагранж", x, result);
            }
            else
            {
                if (x < (points.X[points.Size - 1] - points.X[0]) / 2)
                {
                    result = Interpolation.NewtonForward(x, points);
                    Result(method + "Ньютон (вперед)", x, result);
                }
                else
                {
                    result = Interpolation.NewtonBack(x, points);
                    Result(method + "Ньютон (назад)", x, result);
                }
            }

        }

        private void pbReverseInterpolation_Click(object sender, EventArgs e)
        {
            Points points = ReadDataGrid(dgvData);
            double y;
            double result;

            while (!double.TryParse(Interaction.InputBox("Введите точку обратного интерполирования", "Обратное интерполирование", "", 100, 100), out y))
                MessageBox.Show("Ошибка ввода. Введите число.");

            result = Interpolation.ReverseInterpolation(y, points);
            Result("Обратное интерполирование. Лагранж", result, y);
        }
    }
}
