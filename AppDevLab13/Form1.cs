using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace LAB13
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
            TextBoxX.Text = "-5";
            TextBoxY.Text = "2";
            TextBoxZ.Text = "3";
            textBoxXS.Text = "0,1";
            textBoxXF.Text = "5";

            AnswerTextBox.Text += "Шаг определен для X\r\n";
            
            chart1.Series[0].Points.AddXY(0, 0);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Control();
        }

        private string Calculate(double toChange, double shift, double end, double X, double Y, double Z)
        {
            string Answer = null;

            int rowInd = 0;

            dataGridView1.Rows.Clear();

            bool chart = false, text = false, table = false;

            if (tabControl1.SelectedIndex == 1 && MessageBox.Show("Заполнить таблицу?", "Таблица", MessageBoxButtons.YesNo) == DialogResult.Yes)
                table = true;
            if (tabControl1.SelectedIndex == 2 && MessageBox.Show("Вывести текст?", "Текст", MessageBoxButtons.YesNo) == DialogResult.Yes)
                text = true;
            if (tabControl1.SelectedIndex == 0 && MessageBox.Show("Показать график??", "График", MessageBoxButtons.YesNo) == DialogResult.Yes)
                chart = true;

            while (toChange <= end)
            {
                double U = 0;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[rowInd].HeaderCell.Value = $"{rowInd + 1}";

                var row = dataGridView1.Rows[rowInd];

                if (isX)
                {
                    U = Round(Manager.Calculate(toChange, Y, Z), 2);
                    if(text)
                        Answer += $"X = {Round(toChange, 2)}, Y = {Round(Y, 2)}, Z = {Round(Z, 2)}, U = {U}\r\n";
                    if(table)
                        AddToRow(row, Round(toChange, 2), Round(Y, 2), Round(Z, 2), U);
                }
                else if (isY)
                {
                    U = Round(Manager.Calculate(X, toChange, Z), 2);
                    if (text)
                        Answer += $"X = {Round(X, 2)}, Y = {Round(toChange, 2)}, Z = {Round(Z, 2)}, U = {U}\r\n";
                    if (table)
                        AddToRow(row, Round(X, 2), Round(toChange, 2), Round(Z, 2), U);
                }
                else if (isZ)
                {
                    U = Round(Manager.Calculate(X, Y, toChange), 2);
                    if (text)
                        Answer += $"X = {Round(X, 2)}, Y = {Round(Y, 2)}, Z = {Round(toChange, 2)}, U = {U}\r\n";
                    if (table)
                        AddToRow(row, Round(X, 2), Round(Y, 2), Round(toChange, 2), U);
                }

                
                rowInd++;
                if(chart)
                    chart1.Series[0].Points.AddXY(U, toChange);
                toChange += shift;
            }

            return Answer;
        }

        private DataGridViewRow AddToRow(DataGridViewRow row, params double[] param)
        {
            for(int i = 0; i < param.Length; i++)
            {
                row.Cells[i].Value = param[i];
            }

            return row;
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
            AnswerTextBox.Text = $"Шаг определен для {letter}\r\n";
            chart1.ChartAreas[0].AxisY.Title = $"{letter}";
            chart1.Series[0].Name = $"U к {letter}";
        }
        
        private void Control()
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
            else if (isY)
            {
                Answer += Calculate(Y, XS, XF, X, Y, Z);
            }
            else if (isZ)
            {
                Answer += Calculate(Z, XS, XF, X, Y, Z);
            }

            AnswerTextBox.Text += Answer;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            Control();
        }
    }
}
