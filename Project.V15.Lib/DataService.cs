namespace Project.V15.Lib
{
    public class DataService
    {
        public int Rows(string path)
        {
            int rows = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    rows++;
                }
            }
            return rows;
        }
        public double[] Contract(string[,] mat, int row)
        {
            double[] value = new double[row];
            for (int i = 0; i < row; i++)
            {
                value[i] = Convert.ToDouble(mat[i, 5]);
            }
            return value;
        }

        public string[,] Mass(string path, int row, int col)
        {
            string[,] mas = new string[row, col];
            int j = 0;
            String line = String.Empty;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                String[] parts_of_line = line.Split(';');
                for (int i = 0; i < parts_of_line.Length; i++)
                {
                    parts_of_line[i] = parts_of_line[i].Trim();
                    mas[j, i] = parts_of_line[i].Trim();
                }
                j++;
            }
            return mas;
        }
                
        

    }
}
