using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Block_3
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
            AddColumns(dgvMain, 2);
            AddRows(dgvMain, 2);

            AddColumns(dgvLeft, 1);
            AddRows(dgvLeft, 2);

            AddColumns(dgvX, 1);
            AddRows(dgvX, 2);
        }


        void AddColumns(DataGridView dataGrid, int count)
        {
            while (count-- > 0)
            {
                dataGrid.Columns.Add("", "");
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
                item.Height = (dataGrid.Height - 3) / dataGrid.Rows.Count;
            }

            foreach (DataGridViewColumn item in dataGrid.Columns)
            {
                item.Width = (dataGrid.Width - 3) / dataGrid.Columns.Count;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            AddColumns(dgvMain, 1);
            AddRows(dgvMain, 1);

            AddRows(dgvLeft, 1);

            AddRows(dgvX, 1);
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            if (dgvMain.Rows.Count <= 2) return;

            DelColumn(dgvMain);
            DelRow(dgvMain);

            DelRow(dgvLeft);

            DelRow(dgvX);
        }

        private object ReadDataGrid(DataGridView dataGrid)
        {
            try
            {
                if (dataGrid.Columns.Count > 1)
                {
                    double[,] array = new double[dataGrid.Rows.Count, dataGrid.Columns.Count];
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGrid.Columns.Count; j++)
                        {
                            array[i, j] = Convert.ToDouble(dataGrid.Rows[i].Cells[j].Value);
                        }
                    }

                    return array;
                }
                else
                {
                    double[] array = new double[dataGrid.Rows.Count];
                    for (int i = 0; i < dataGrid.Rows.Count; i++)
                    {
                        array[i] = Convert.ToDouble(dataGrid.Rows[i].Cells[0].Value);
                    }

                    return array;
                }
            }
            catch
            {
                return null;
            }
        }

        private void pbGause_Click(object sender, EventArgs e)
        {
            double[,] main = (double[,])ReadDataGrid(dgvMain);
            double[] left = (double[])ReadDataGrid(dgvLeft);
            if(main == null)
            {
                MessageBox.Show("Ошибка ввода в главной матрице.");
                return;
            }
            if (left == null)
            {
                MessageBox.Show("Ошибка ввода в столбце значений.");
                return;
            }

            SoLE sole = new SoLE(main, left);
            double[] result = sole.SolveGause();

            double[,] arrMain = sole.Main;
            for (int i = 0; i < dgvMain.Rows.Count; i++)
            {
                for (int j = 0; j < dgvMain.Columns.Count; j++)
                {
                    dgvMain.Rows[i].Cells[j].Value = arrMain[i, j];
                }
            }

            double[] array = sole.Left;
            for (int i = 0; i < dgvLeft.Rows.Count; i++)
            {
                dgvLeft.Rows[i].Cells[0].Value = array[i];
            }

            if(sole.Status != SoLEStatus.Ok)
            {
                if(sole.Status == SoLEStatus.NoAnswer)
                    MessageBox.Show("Нет решений.");
                else if(sole.Status == SoLEStatus.ZeroDeterminant)
                    MessageBox.Show("Определитель равен нулю.");
                else if(sole.Status == SoLEStatus.ZeroesOnMain)
                    MessageBox.Show("Нули на главной диагонали");

                return;
            }

            for (int i = 0; i < dgvLeft.Rows.Count; i++)
            {
                dgvX.Rows[i].Cells[0].Value = result[i];
            }
        }

        private void pbZeidel_Click(object sender, EventArgs e)
        {
            double[,] main = (double[,])ReadDataGrid(dgvMain);
            double[] left = (double[])ReadDataGrid(dgvLeft);
            if (main == null)
            {
                MessageBox.Show("Ошибка ввода в главной матрице.");
                return;
            }
            if (left == null)
            {
                MessageBox.Show("Ошибка ввода в столбце значений.");
                return;
            }

            double accuracy;
            while(!double.TryParse(Interaction.InputBox("Введите приближение", "", "0,0001", 100, 100), out accuracy))
                MessageBox.Show("Ошибка ввода. Точность должна быть числом.");

            SoLE sole = new SoLE(main, left);
            double[] result = sole.Zeidel(accuracy);

            double[,] arrMain = sole.Main;
            for (int i = 0; i < dgvMain.Rows.Count; i++)
            {
                for (int j = 0; j < dgvMain.Columns.Count; j++)
                {
                    dgvMain.Rows[i].Cells[j].Value = arrMain[i, j];
                }
            }

            double[] array = sole.Left;
            for (int i = 0; i < dgvLeft.Rows.Count; i++)
            {
                dgvLeft.Rows[i].Cells[0].Value = array[i];
            }

            if (sole.Status != SoLEStatus.Ok)
            {
                if (sole.Status == SoLEStatus.NoAnswer)
                    MessageBox.Show("Нет решений.");
                else if (sole.Status == SoLEStatus.Divergence)
                    MessageBox.Show("Система расходится.");
                else if (sole.Status == SoLEStatus.ZeroesOnMain)
                    MessageBox.Show("Нули на главной диагонали");

                return;
            }

            for (int i = 0; i < dgvLeft.Rows.Count; i++)
            {
                dgvX.Rows[i].Cells[0].Value = result[i];
            }
        }
    }
}
