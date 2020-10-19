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

namespace AppDevLab3
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

        private void execute_Click(object sender, RoutedEventArgs e)
        {
            double X1 = Manager.ConvertToDouble(textBoxX1.Text);
            double X2 = Manager.ConvertToDouble(textBoxX2.Text);

            int N = Manager.ConvertToInt(textBoxN.Text);
            double h;

            if (X1 != X2)
            {

                if (N == 0)
                {
                    throw new Exception(answerTextBox.Text += "N не может быть равно\r\n");
                }

                h = Math.Round((X2 - X1) / N, 3);
                textBoxH.Text = h.ToString();

                answerTextBox.Text += "X1 = " + X1.ToString() + "\r\n" +
                                      "X2 = " + X2.ToString() + "\r\n" +
                                      "N = " + N.ToString() + "\r\n" +
                                      "H = " + h.ToString() + "\r\n";

                List<double> rowList = Manager.Row(X1, X2, h);

                answerTextBox.Text += "X\t|\tРяд\t|\tФормула\r\n";

                for (int i = 0; i < rowList.Count; i++, X1 += h)
                {
                    answerTextBox.Text += Math.Round(X1, 2) + "\t|\t" + Math.Round(rowList[i], 5) + "\t|\t" + Math.Round(Manager.Formula(X1), 5) + "\r\n";
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBoxX1.Text = "0";
            textBoxX2.Text = "1";
            textBoxN.Text = "14";
        }
    }
}
