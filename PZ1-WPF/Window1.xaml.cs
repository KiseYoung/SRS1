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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_Chet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string chislo = tb_Vvod.Text;
                int chis = Convert.ToInt32(chislo);
                int[] a = new int[chis.ToString().Length];
                if (chis <= 0)
                {
                    MessageBox.Show("Ошибка,введено отрицательное число или ноль.");
                    tb_Otvet.Clear();
                    return;
                }

                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = chis % 10;
                    chis /= 10;
                }
                if (Convert.ToInt32(a[0] + a[1] + a[2]) == Convert.ToInt16(a[3] + a[4] + a[5]))
                {
                    tb_Otvet.Text = "Сумма равна";
                }
                else
                {
                    tb_Otvet.Text = "Сумма неравна";
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!\nПроверьте ниже перечисленные проблемы:\nПустое поле.\nПервая цифра не должна быть 0.");
            }
        }

        private void tb_Vvod_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void tb_Otvet_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }

       
    }
   
}


