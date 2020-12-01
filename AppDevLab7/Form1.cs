using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Math;

namespace LAB7
{
    public partial class Form1 : Form
    {
        IRows rows = new RowsFirst();
        IFormulae formulae = new FormulaeFirst();

        public Form1()
        {
            InitializeComponent();
            //this.ContextMenuStrip = contextMenuStrip1;
            //textBoxN.ContextMenuStrip = contextMenuStrip2;
            menuStrip2.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxAnswer.Text = "Результаты ст.гр 10701219\r\n" +
                                 "Житникович Е.Н.\r\n";
            textBoxX1.Text = "0,1";
            textBoxX2.Text = "1";
            textBoxN.Text = "14";

        }

        private void Run()
        {
            double X1 = Manager.ConvertToDouble(textBoxX1.Text);
            double X2 = Manager.ConvertToDouble(textBoxX2.Text);

            int N;
            double h;

            if (X1 != X2)
            {
                if (textBoxN.Text == "")
                {
                    N = 14;
                }
                else
                {
                    N = Manager.ConvertToInt(textBoxN.Text);
                }

                if (textBoxH.Text == "")
                {
                    h = Round((X2 - X1) / N, 2);
                }
                else
                {
                    h = Round(Manager.ConvertToDouble(textBoxH.Text), 2);
                }
                textBoxH.Text = h.ToString();

                List<double> rowList = rows.Row(X1, X2, h);

                textBoxAnswer.Text += OutputService.PrintRowAndForm(X1, X2, N, h, rowList, formulae);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ChooseItem(e);
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ChooseItem(e);
        }

        private void ChooseItem(ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Формула 1")
            {
                formulae = new FormulaeFirst();
                rows = new RowsFirst();
                textBoxAnswer.Text += "Выбрана формула: \r\n" +
                                      "(1+2x^2)e^x^2\r\n";
            }
            else if (e.ClickedItem.Text == "Формула 2")
            {
                formulae = new FormulaeSecond();
                rows = new RowsSecond();
                textBoxAnswer.Text += "Выбрана формула: \r\n" +
                                      "(e^x + e^-x)/2\r\n";
            }
            else if (e.ClickedItem.Text == "Закрыть")
            {
                menuStrip1.Visible = false;
                menuStrip2.Visible = true;
            }
            else if (e.ClickedItem.Text == "Выполнить")
            {
                Run();
            }
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Text == "Назад")
            {
                menuStrip1.Visible = true;
                menuStrip2.Visible = false;
            }
        }
    }
}
