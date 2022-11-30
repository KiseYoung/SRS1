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
using System.Text.RegularExpressions;

namespace PZ1_WPF
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            rtb_Pole.Document.Blocks.Clear();
        }
        
        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bt_Preobraz_Click(object sender, RoutedEventArgs e)
        {
            string text = new TextRange(rtb_Pole.Document.ContentStart, rtb_Pole.Document.ContentEnd).Text;
            text = Regex.Replace(text, @"\s+", " ");  //совпадение с одинм или несколькими пробелами
            rtb_Pole.Document.Blocks.Clear();
            rtb_Pole.AppendText(text);
        }

        private void bt_Clear_Click(object sender, RoutedEventArgs e)
        {
            rtb_Pole.Document.Blocks.Clear();
        }
    }
}
