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
using System.Windows.Shapes;

namespace PZ1_WPF
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void btn_preobraz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tb_Otvet.Clear();
                string text = tb_Vvod.Text;
                string[] numbers = text.Split(',');
                int[] numberInt = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    numberInt[i] = int.Parse(numbers[i]);
                }
                int d = int.MaxValue;
                int c = int.MaxValue;
                foreach (int a in numberInt)
                {
                    if (a < 0 && a < d)
                    {
                        d = a;
                    }
                    else if (a > 0 && a < c)
                    {
                        c = a;
                    }
                }
                for (int i = 0; i < numberInt.Length; i++)
                {
                    if (numberInt[i] == d)
                    {
                        numberInt[i] = c;
                    }
                    else if (numberInt[i] == c)
                    {
                        numberInt[i] = d;
                    }
                }
                for (int i = 0; i < numberInt.Length; i++)
                {
                    tb_Otvet.Text += (numberInt[i] + " ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\n 1.Перечисление должно быть СТРОГО через запятую(,)\n 2.Введен неверный символ");
            }
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            tb_Vvod.Clear();
            tb_Otvet.Clear();
        }
    }
}
