using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;


namespace LAB12
{
    public partial class Form1 : Form
    {
        private bool isX = true;
        private bool isY = false;
        private bool isZ = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AnswerTextBox.Text = "Лаб.Раб №1 Ст. гр. 10701219\r\n" +
                                 "Житникович Е.Н\r\n";
            TextBoxX.Text = "-5";
            TextBoxY.Text = "2";
            TextBoxZ.Text = "3";
            textBoxXS.Text = "0,1";
            textBoxXF.Text = "5";

            AnswerTextBox.Text += "Шаг определен для X\r\n";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            double X = Manager.ConvertToDouble(TextBoxX.Text);
            double Y = Manager.ConvertToDouble(TextBoxY.Text);
            double Z = Manager.ConvertToDouble(TextBoxZ.Text);
            double XS = Manager.ConvertToDouble(textBoxXS.Text);
            double XF = Manager.ConvertToDouble(textBoxXF.Text);

            string Answer = null;

            chart1.Series[0].Points.Clear();
            if (isX)
            {
                Answer += Calculate(X, XS, XF, X, Y, Z);
            }
            else if(isY)
            {
                Answer += Calculate(Y, XS, XF, X, Y, Z);
            }
            else if(isZ)
            {
                Answer += Calculate(Z, XS, XF, X, Y, Z);
            }

            AnswerTextBox.Text += Answer;
        }

        private string Calculate(double toChange, double shift, double end, double X, double Y, double Z)
        {
            string Answer = null;

            while (toChange <= end)
            {
                double U = 0;

                if (isX)
                {
                    U = Round(Manager.Calculate(toChange, Y, Z), 2);
                    Answer += $"X = {Round(toChange, 2)}, Y = {Round(Y, 2)}, Z = {Round(Z, 2)}, U = {U}\r\n";
                }
                else if (isY)
                {
                    U = Round(Manager.Calculate(X, toChange, Z), 2);
                    Answer += $"X = {Round(X, 2)}, Y = {Round(toChange, 2)}, Z = {Round(Z, 2)}, U = {U}\r\n";
                }
                else if (isZ)
                {
                    U = Round(Manager.Calculate(X, Y, toChange), 2);
                    Answer += $"X = {Round(X, 2)}, Y = {Round(Y, 2)}, Z = {Round(toChange, 2)}, U = {U}\r\n";
                }

                chart1.Series[0].Points.AddXY(U, toChange);
                toChange += shift;
            }

            return Answer;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (isX)
                return;

            isX = true;
            isY = false;
            isZ = false;

            ChangeLabels("X");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (isY)
                return;

            isX = false;
            isY = true;
            isZ = false;

            ChangeLabels("Y");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (isZ)
                return;

            isX = false;
            isY = false;
            isZ = true;

            ChangeLabels("Z");
        }

        private void ChangeLabels(string letter)
        {
            AnswerTextBox.Text += $"Шаг определен для {letter}\r\n";
            chart1.ChartAreas[0].AxisY.Title = $"{letter}";
            chart1.Series[0].Name = $"U к {letter}";
        }
    }
}
