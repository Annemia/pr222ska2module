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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnExecuteTask1_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(tbInputNumber.Text, out int n) || n < -999 || n > 999)
            {
                MessageBox.Show("Введите целое число от -999 до 999!");
                return;
            }

            if (n == 0)
            {
                tbResultTask1.Text = "нулевое число";
                return;
            }

            string sign = n > 0 ? "положительное" : "отрицательное";

            int abs = Math.Abs(n);
            string type = "";

            if (abs < 10) type = "однозначное";
            else if (abs < 100) type = "двузначное";
            else type = "трехзначное";

            tbResultTask1.Text = $"{sign} {type} число";
        }
    }
}
