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

namespace PZ1_WPF
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

        private void btn_Zd1_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
        }

        private void btn_Zd2_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.ShowDialog();
        }

        private void btn_Zd3_Click(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3();
            w3.ShowDialog();
        }

        private void btn_Zd4_Click(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4();
            w4.ShowDialog();
        }

        private void btn_Zd5_Click(object sender, RoutedEventArgs e)
        {
            Window5 w5 = new Window5();
            w5.ShowDialog();
        }
    }
}
