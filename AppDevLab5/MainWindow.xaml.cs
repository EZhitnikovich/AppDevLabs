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

namespace AppDevLab5
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
            string lineText = comboBox.SelectedItem.ToString();

            ShowLineInfo(lineText);
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "0" && e.Text != "1" && e.Text != " ")
            {
                e.Handled = true;
            }

            if (textBox.Text != "" && e.Text == "\r")
            {
                listBox.Items.Insert(listBox.Items.Count, textBox.Text);
                comboBox.Items.Insert(comboBox.Items.Count, textBox.Text);
                textBox.Clear();
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string lineText = listBox.SelectedItem.ToString();

            ShowLineInfo(lineText);
        }

        private void ShowLineInfo(string lineText)
        {
            List<string> array = Manager.GetOddGroups(lineText);

            string answer = null;

            foreach (string s in array)
            {
                answer += $"В {s} - {Manager.CalculateUnits(s)} по 1\r\n";
            }

            MessageBox.Show(answer);
        }
    }
}
