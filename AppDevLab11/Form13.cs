using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB11
{
    public partial class Form13 : Form
    {
        private Bitmap bmp;
        private bool line = false;
        private bool rectangle = false;
        private bool ellipse = false;
        private bool isPie = false;
        private Color color = Color.Black;
        private int penWidht = 1;
        private int textx = 50;
        private int texty = 50;
        Random rand = new Random();

        public Form13()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            saveFileDialog1.Filter = "Picture(*.png)|*.png";
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            label1.Text = $"X: {pictureBox1.ClientSize.Width}";
            label2.Text = $"Y: {pictureBox1.ClientSize.Height}";
            label4.Text = "Выбрано: эллипс";
            ellipse = true;
            ChangeEnabledTextBox(true);
            textBox1.Text = "50";
            textBox2.Text = "25";
            textBox3.Text = "100";
            textBox4.Text = "150";
        }

        private void Form13_SizeChanged(object sender, EventArgs e)
        {
            label1.Text = $"X: {pictureBox1.ClientSize.Width}";
            label2.Text = $"Y: {pictureBox1.ClientSize.Height}";
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Выбрано: прямоугольник";
            ChangeEnabledTextBox(true);
            line = false;
            rectangle = true;
            ellipse = false;
    }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Выбрано: эллипс";
            ChangeEnabledTextBox(true);
            line = false;
            rectangle = false;
            ellipse = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Выбрано: линия";
            ChangeEnabledTextBox(false);
            line = true;
            rectangle = false;
            ellipse = false;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label12.Text = $"{e.NewValue}px";
            penWidht = e.NewValue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            bmp.Save(filename, ImageFormat.Png);
            MessageBox.Show("Файл сохранен");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pictureBox1.Image = bmp;
        }

        private void ChangeEnabledTextBox(bool forRectEll)
        {
            if(forRectEll)
            {
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Pen pen = new Pen(color, penWidht);
                if(line)
                {
                    DrawLine(pen, g);
                }
                else if(rectangle)
                {
                    DrawRectEll(pen, g, true);
                }
                else if(ellipse)
                {
                    DrawRectEll(pen, g, false);
                }
            }
            pictureBox1.Image = bmp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            color = colorDialog1.Color;
        }

        private void DrawLine(Pen pen, Graphics g)
        {
            if(int.TryParse(textBox1.Text, out int x1) &&
                int.TryParse(textBox2.Text, out int y1) &&
                int.TryParse(textBox5.Text, out int x2) &&
                int.TryParse(textBox6.Text, out int y2))
            {
                g.DrawLine(pen, x1, y1, x2, y2);
            }
            else
            {
                MessageBox.Show("Введенные данные ошибочны.");
            }
        }

        private void DrawRectEll(Pen pen, Graphics g, bool isRect)
        {
            SolidBrush solidBrush = new SolidBrush(pen.Color);
            if (int.TryParse(textBox1.Text, out int x1) &&
                int.TryParse(textBox2.Text, out int y1) &&
                int.TryParse(textBox3.Text, out int width) &&
                int.TryParse(textBox4.Text, out int height))
            {
                if(isRect)
                {
                    if (!checkBox1.Checked)
                    {
                        g.DrawRectangle(pen, x1, y1, width, height);
                    }
                    else
                    {
                        g.FillRectangle(solidBrush, x1, y1, width, height);
                    }
                }
                else
                {
                    if (isPie)
                    {
                        if (int.TryParse(textBox7.Text, out int start) && int.TryParse(textBox8.Text, out int sweep))
                        {
                            if (!checkBox1.Checked)
                            {
                                RectangleF rectangle = new RectangleF(x1, y1, width, height);
                                g.DrawPie(pen, rectangle, start, sweep);
                            }
                            else
                            {
                                Rectangle rectangle = new Rectangle(x1, y1, width, height);
                                g.FillPie(solidBrush, rectangle, start, sweep);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не хватает параметров");
                        }
                    }
                    else
                    {
                        if (!checkBox1.Checked)
                        {
                            g.DrawEllipse(pen, x1, y1, width, height);
                        }
                        else
                        {
                            g.FillEllipse(solidBrush, x1, y1, width, height);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Введенные данные ошибочны.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isPie = !isPie;
            if(isPie)
            {
                label13.Text = "Сектор: вкл";
            }
            else
            {
                label13.Text = "Сектор: выкл";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Color color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    SolidBrush brush = new SolidBrush(color);
                    Font font = new Font("Arial", 14);
                    g.DrawString(textBox9.Text, font , brush, textx, texty);
                }
                textx += rand.Next(0, 5);
                texty += rand.Next(0, 5);
                pictureBox1.Image = bmp;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if(checkbox.Checked)
            {
                textx = 50;
                texty = 50;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
