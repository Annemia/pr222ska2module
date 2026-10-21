using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void btnExecuteTask3_Click(object sender, RoutedEventArgs e)
        {
            string input = tbInputArray.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите координаты точек!");
                return;
            }

            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double[] points = new double[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (!double.TryParse(parts[i], out points[i]))
                {
                    MessageBox.Show("Все введенные значения должны быть числами!");
                    return;
                }
            }

            if (points.Length == 0)
            {
                MessageBox.Show("Введите хотя бы одно число!");
                return;
            }

            double bestPoint = points[0];
            double minSum = double.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                double currentSum = 0;

                for (int j = 0; j < points.Length; j++)
                {
                    currentSum += Math.Abs(points[i] - points[j]);
                }

                if (currentSum < minSum)
                {
                    minSum = currentSum;
                    bestPoint = points[i];
                }
            }

            tbResultTask3.Text = $"Точка: {bestPoint}, Мин. сумма расстояний: {minSum}";
        }
    }
}
