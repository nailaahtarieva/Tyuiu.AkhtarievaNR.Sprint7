using Project.V15.Lib;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();
        static string openFilePath;
        static int rows;
        static int columns;
        private void buttonHelp_ANR_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void buttonInfo_ANR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_ANR_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            buttonCreateTable_ANR.Enabled = true;

        }
        private void buttonCreateTable_ANR_Click(object sender, EventArgs e)
        {
            int col = 9;
            int row = ds.Rows(openFilePath);
            dataGridViewTable_ANR.RowCount = row;
            dataGridViewTable_ANR.ColumnCount = col;
            string[,] mtrx = new string[row, col];
            mtrx = ds.Mass(openFilePath, row, col);
            int c = 0;
            for (int i = 2; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewTable_ANR.Rows[c].Cells[j].Value = mtrx[i, j];
                }
                c++;
            }
            buttonCreateChart_ANR.Enabled = true;
            buttonSaveFile_ANR.Enabled = true;

        }

        private void buttonCreateChart_ANR_Click(object sender, EventArgs e)
        {

            string[,] mass = new string[dataGridViewTable_ANR.RowCount, dataGridViewTable_ANR.ColumnCount];
            mass = ds.Mass(openFilePath, dataGridViewTable_ANR.RowCount, dataGridViewTable_ANR.ColumnCount);

            this.chartContract_ANR.ChartAreas[0].AxisX.Title = "Порядковый номер сотрудника";
            this.chartContract_ANR.ChartAreas[0].AxisY.Title = "Длительность, лет";
            for (int i = 0; i < dataGridViewTable_ANR.RowCount; i++)
            {
                chartContract_ANR.Series[0].Points.AddXY(i, mass[i, 7]);
            }
            buttonDone_ANR.Enabled = true;

        }

        private void buttonDone_ANR_Click(object sender, EventArgs e)
        {
            int row = ds.Rows(openFilePath);
            int col = 9;
            string[,] mtrx = new string[row, col];
            mtrx = ds.Mass(openFilePath, row, col);
            int min = 1000;
            int max = 0;
            double mean = 0;
            double summ = 0;

            for (int i = 2; i < row; i++)
            {
                for (int j = 7; j <= 7; j++)
                {
                    min = Math.Min(Convert.ToInt16(mtrx[i, j]), min);
                }
            }
            textBoxMinLen_ANR.Text = min.ToString();

            for (int i = 2; i < row; i++)
            {
                for (int j = 7; j <= 7; j++)
                {
                    max = Math.Max(Convert.ToInt16(mtrx[i, j]), max);
                }
            }
            textBoxMaxLen_ANR.Text = max.ToString();

            for (int i = 2; i < row; i++)
            {
                for (int j = 7; j <= 7; j++)
                {
                    summ += Convert.ToDouble(mtrx[i, j]);
                }
            }
            mean = Math.Round(summ / row, 3);
            textBoxSrLen_ANR.Text = mean.ToString();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveFile_ANR_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();
            string path = saveFileDialogTask.FileName;
            int rows = dataGridViewTable_ANR.Rows.Count;
            int cols = dataGridViewTable_ANR.Columns.Count;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str += dataGridViewTable_ANR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewTable_ANR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
            MessageBox.Show("Файл успешно сохранен!");
        }

        private void buttonSearch_ANR_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.ShowDialog();
        }
    }
}
