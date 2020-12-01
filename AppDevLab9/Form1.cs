using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using static System.Math;

namespace LAB9
{
    public partial class Form1 : Form
    {
        IRows rows = new RowsFirst();
        IFormulae formulae = new FormulaeFirst();
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this.BackColor.R, this.BackColor.G, this.BackColor.B);
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
            else if (e.ClickedItem.Text == "Цвета(м)")
            {
                using(Form2 form2 = new Form2(this.BackColor.R, this.BackColor.G, this.BackColor.B))
                {
                    var result = form2.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        this.BackColor = form2.ColorValue;
                    }
                }
            }
            else if (e.ClickedItem.Text == "Цвета")
            {
                form2 = new Form2(this.BackColor.R, this.BackColor.G, this.BackColor.B);
                form2.Show();
                form2.ScrollBarRValueChageEvent += Form2_ScrollBar1Eventt;
                form2.ScrollBarGValueChageEvent += Form2_ScrollBar2Eventt;
                form2.ScrollBarBValueChageEvent += Form2_ScrollBar3Eventt;
            }
            else if (e.ClickedItem.Text == "Выполнить")
            {
                form2.Hide();
                //Run();
            }
            else if (e.ClickedItem.Text == "кнопка!")
            {
                form2.Visible = true;
            }
        }

        private void Form2_ScrollBar3Eventt(object sender, EventArgs e)
        {
            ScrollBar scrollBar = sender as ScrollBar;
            this.BackColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, scrollBar.Value);
        }

        private void Form2_ScrollBar2Eventt(object sender, EventArgs e)
        {
            ScrollBar scrollBar = sender as ScrollBar;
            this.BackColor = Color.FromArgb(this.BackColor.R, scrollBar.Value, this.BackColor.B);
        }

        private void Form2_ScrollBar1Eventt(object sender, EventArgs e)
        {
            ScrollBar scrollBar = sender as ScrollBar;
            this.BackColor = Color.FromArgb(scrollBar.Value, this.BackColor.G, this.BackColor.B);
        }
    }
}
