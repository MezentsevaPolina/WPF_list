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

namespace WpfApp1
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
        //1
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Title = "ВАЖНО И СРОЧНО";
            window1.Show();
        }
        //2
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Title = "ВАЖНО И НЕ СРОЧНО";
            window2.Show();
        }
        //3
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Title = "НЕ ВАЖНО И СРОЧНО";
            window3.Show();
        }
        //4
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Title = "НЕ ВАЖНО И НЕ СРОЧНО";
            window4.Show();
        }

    }
}
