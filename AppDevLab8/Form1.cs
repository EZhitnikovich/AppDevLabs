using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Math;


namespace LAB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            double X = Manager.ConvertToDouble(TextBoxX.Text);
            double Y = Manager.ConvertToDouble(TextBoxY.Text);
            double Z = Manager.ConvertToDouble(TextBoxZ.Text);
            double XS = Manager.ConvertToDouble(textBoxXS.Text);
            double XF = Manager.ConvertToDouble(textBoxXF.Text);

            string Answer = null;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            while (X <= XF)
            {
                double U = Round(Manager.Calculate(X, Y, Z), 2);
                Answer += $"X = {Round(X, 2)}, Y = {Round(Y, 2)}, Z = {Round(Z, 2)}, U = {U}\r\n";
                chart1.Series[0].Points.AddXY(U, X);
                chart1.Series[1].Points.AddXY(U + 1, X);
                X += XS;
            }

            AnswerTextBox.Text += Answer;
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
        }
    }
}
