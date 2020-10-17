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

namespace AppDevLab1
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

        private void executeButton_Click(object sender, RoutedEventArgs e)
        {
            double X = Manager.ConvertToDouble(xInput.Text);
            double Y = Manager.ConvertToDouble(yInput.Text);
            double Z = Manager.ConvertToDouble(zInput.Text);

            string Answer = $"X = {X}\r\n" +
                            $"Y = {Y}\r\n" +
                            $"Z = {Z}\r\n" +
                            $"Результат U = {Manager.Calculate(X, Y, Z)}\r\n";

            Output.Text += Answer;
        }
    }
}
