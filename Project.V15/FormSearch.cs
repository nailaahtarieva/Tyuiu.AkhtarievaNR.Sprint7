using Project.V15.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.V15
{
    public partial class FormSearch : Form
    { 
        
        public FormSearch()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonClose_ANR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpen_ANR_Click(object sender, EventArgs e)
        {
            openFileDialog_ANR.ShowDialog();
            openFilePath = openFileDialog_ANR.FileName;
            buttonSearch_ANR.Enabled = true;
        }

        private void buttonSearch_ANR_Click(object sender, EventArgs e)
        {
            int col = 9;
            int row = ds.Rows(openFilePath);
            string[,] mas = new string[row, col];
            mas = ds.Mass(openFilePath, row, col);
            string str = textBoxNumber_ANR.Text;
            int k = 1;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j <= 0; j++)
                {
                    if (mas[i, j] == str)
                    {
                        textBoxFullName_ANR.Text = mas[i, k];
                        k++;
                        textBoxAdress_ANR.Text = mas[i, k];
                        k++;
                        textBoxPhone_ANR.Text = mas[i, k];
                        k++;
                        textBoxFunction_ANR.Text = mas[i, k];
                        k++;
                        textBoxSalary_ANR.Text = mas[i, k];
                        k = k + 2;
                        textBoxValidity_ANR.Text = mas[i, k];
                    }
                }
            }
        }
    }
}
