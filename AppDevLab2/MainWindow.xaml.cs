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
using static System.Math;

namespace AppDevLab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double F(double X)
        {
            if ((bool)radioSh.IsChecked)
            {
                return Sinh(X);
            }
            else if ((bool)radioX2.IsChecked)
            {
                return Pow(X, 2);
            }
            else if ((bool)radioEX.IsChecked)
            {
                return Pow(E, X);
            }
            else
            {
                throw new Exception("Error: incorrect data from radioButton");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double X = Manager.ConvertToDouble(textBoxX.Text);
            int i = Manager.ConvertToInt(textBoxI.Text);

            double ans;

            if (i % 2 == 1 && X > 0)
            {
                ans = i * Sqrt(F(X));
            }
            else if (i % 2 == 0 && X < 0)
            {
                ans = (i / 2) * Sqrt(Abs(F(X)));
            }
            else
            {
                ans = Sqrt(Abs(i * F(X)));
            }

            AnsTextBox.Text += $"X = {X}\r\n" +
                              $"i = {i}\r\n" +
                              $"Ответ = {ans}\r\n";

            if ((bool)checkBox.IsChecked)
                AnsTextBox.Text += $"MaxAbs(x,i) =  {Max(Abs(X), Abs(i))}\r\n";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxI.Text = "3";
            textBoxX.Text = "2";
        }
    }
}
