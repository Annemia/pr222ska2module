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

namespace pr2module
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1task1_Click(object sender, RoutedEventArgs e)
        {
            btn5task5.Visibility = Visibility.Collapsed;
            btn4task4.Visibility = Visibility.Collapsed;
            btn3task3.Visibility = Visibility.Collapsed;
            btn1task1.Visibility= Visibility.Collapsed;
            btn2task2.Visibility= Visibility.Collapsed;
            FrmMain.Navigate(new Pages.Page1());
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            btn5task5.Visibility = Visibility.Visible;
            btn4task4.Visibility = Visibility.Visible;
            btn3task3.Visibility = Visibility.Visible;
            btn1task1.Visibility = Visibility.Visible;
            btn2task2.Visibility = Visibility.Visible;
            FrmMain.Content = null;
        }

        private void btn2task2_Click(object sender, RoutedEventArgs e)
        {
            btn5task5.Visibility = Visibility.Collapsed;
            btn4task4.Visibility = Visibility.Collapsed;
            btn3task3.Visibility = Visibility.Collapsed;
            btn2task2.Visibility = Visibility.Collapsed;
            btn1task1.Visibility = Visibility.Collapsed;
            FrmMain.Navigate(new Pages.Page2());
        }

        private void btn3task3_Click(object sender, RoutedEventArgs e)
        {
            btn5task5.Visibility = Visibility.Collapsed;
            btn4task4.Visibility = Visibility.Collapsed;
            btn3task3.Visibility = Visibility.Collapsed;
            btn2task2.Visibility = Visibility.Collapsed;
            btn1task1.Visibility = Visibility.Collapsed;
            FrmMain.Navigate(new Pages.Page3());
        }

        private void bt4task4_Click(object sender, RoutedEventArgs e)
        {
            btn5task5.Visibility = Visibility.Collapsed;
            btn4task4.Visibility = Visibility.Collapsed;
            btn3task3.Visibility = Visibility.Collapsed;
            btn2task2.Visibility = Visibility.Collapsed;
            btn1task1.Visibility = Visibility.Collapsed;
            FrmMain.Navigate(new Pages.Page4());
        }

        private void bt5task5_Click(object sender, RoutedEventArgs e)
        {
            btn5task5.Visibility = Visibility.Collapsed;
            btn4task4.Visibility = Visibility.Collapsed;
            btn3task3.Visibility = Visibility.Collapsed;
            btn2task2.Visibility = Visibility.Collapsed;
            btn1task1.Visibility = Visibility.Collapsed;
            FrmMain.Navigate(new Pages.Page5());
        }
    }
}
