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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void tbInputArray_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnExecuteTask4_Click(object sender, RoutedEventArgs e)
        {
            string input = tbInputArray.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Введите элементы массива");
                return;
            }

            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out array[i]))
                {
                    MessageBox.Show("Все элементы должны быть целыми числами");
                    return;
                }
            }

            int firstEvenIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    firstEvenIndex = i;
                    break;
                }
            }

            int lastNegativeIndex = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < 0)
                {
                    lastNegativeIndex = i;
                    break;
                }
            }

            if (firstEvenIndex == -1)
            {
                MessageBox.Show("Введите четные числа");
                return;
            }

            if (lastNegativeIndex == -1)
            {
                MessageBox.Show("Введите отрицательные числа");
                return;
            }

            int temp = array[firstEvenIndex];
            array[firstEvenIndex] = array[lastNegativeIndex];
            array[lastNegativeIndex] = temp;

            tbResultTask4.Text = string.Join(" ", array);
        }
    }
}
