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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void btn_Vivod_Click(object sender, RoutedEventArgs e)
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
                int count = 1;
                int number = numberInt[0];
                for (int i = 1; i < numberInt.Length; i++)
                {
                    if (numberInt[i] == number)
                        count++;
                    else
                    {
                        tb_Otvet.Text += (count + " ");
                        count = 1;
                        number = numberInt[i];
                    }
                }
                tb_Otvet.Text += (count + " ");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка!\n 1.Перечисление должно быть СТРОГО через запятую(,)\n 2.Введен неверный символ");
            }
        }
    }
}
