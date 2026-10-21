using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr2module.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void btnExecuteTask5_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbRows.Text, out int n) || n <= 0 ||
                !int.TryParse(tbCols.Text, out int m) || m <= 0)
            {
                MessageBox.Show("Введите корректные положительные размеры N и M!");
                return;
            }

            int[,] matrix = new int[n, m];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11);
                }
            }

            int minVal = matrix[0, 0];
            int maxVal = matrix[0, 0];

            foreach (int val in matrix)
            {
                if (val < minVal) minVal = val;
                if (val > maxVal) maxVal = val;
            }

            tbMin.Text = minVal.ToString();
            tbMax.Text = maxVal.ToString();

            dgOriginal.ItemsSource = ConvertToDataTable(matrix, n, m).DefaultView;

            int[] flatArray = matrix.Cast<int>().ToArray();

            int[] ascArray = flatArray.OrderBy(x => x).ToArray();
            int[,] ascMatrix = ConvertTo2D(ascArray, n, m);
            dgAscending.ItemsSource = ConvertToDataTable(ascMatrix, n, m).DefaultView;

            int[] descArray = flatArray.OrderByDescending(x => x).ToArray();
            int[,] descMatrix = ConvertTo2D(descArray, n, m);
            dgDescending.ItemsSource = ConvertToDataTable(descMatrix, n, m).DefaultView;
        }

        private DataTable ConvertToDataTable(int[,] matrix, int rows, int cols)
        {
            DataTable table = new DataTable();
            for (int j = 0; j < cols; j++)
            {
                table.Columns.Add($"Столбец {j + 1}", typeof(int));
            }

            for (int i = 0; i < rows; i++)
            {
                DataRow row = table.NewRow();
                for (int j = 0; j < cols; j++)
                {
                    row[j] = matrix[i, j];
                }
                table.Rows.Add(row);
            }
            return table;
        }

        private int[,] ConvertTo2D(int[] array, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = array[index++];
                }
            }
            return matrix;
        }
    }
}        

