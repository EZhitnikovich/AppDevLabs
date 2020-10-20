using System;
using System.Collections.Generic;
using System.Data;
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
using static AppDevLab4.Manager;

namespace AppDevLab4
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
            ItemCollection itemCollection = dataGrid.Items;

            int lineNum = 0;

            foreach (DataRowView item in itemCollection)
            {
                lineNum++;
                var row = item.Row.ItemArray;
                int k = 0;
                string answer = null;

                for (int i = 1; i < row.Length - 1; i++)
                {
                    if (row[i] != null && row[i - 1] != null && row[i + 1] != null)
                    {
                        if (ConvertToInt(row[i].ToString()) > ConvertToInt(row[i - 1].ToString()) &&
                            ConvertToInt(row[i].ToString()) < ConvertToInt(row[i + 1].ToString()))
                        {
                            k++;
                        }
                    }
                }

                ansLabel.Content += $"В строке {lineNum}\n" +
                                    $"{k} особенных эл-тов\n";
            }
        }

        private void sizeChangerButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow row;
            DataColumn column;

            int M = Manager.ConvertToInt(textBoxM.Text);
            int N = Manager.ConvertToInt(textBoxN.Text);

            for(int i = 0; i < M; i++)
            {
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = $"i = {i}";
                dt.Columns.Add(column);
            }

            for (int i = 0; i < N; i++)
            {
                row = dt.NewRow();
                dt.Rows.Add(row);
            }

            DataView view = new DataView(dt);
            dataGrid.ItemsSource = view;
        }
    }
}
