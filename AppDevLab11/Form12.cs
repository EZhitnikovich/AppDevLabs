using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace LAB11
{
    public partial class Form12 : Form
    {
        private Bitmap bmp;
        private bool drawing = false;
        private Color color = Color.Black;
        private Point start;
        private float width = 1;

        public Form12()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            saveFileDialog1.Filter = "Picture(*.png)|*.png";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //using(Graphics g = Graphics.FromImage(bmp))
            //{
            //g.Clear(Color.White);
            //g.DrawEllipse(Pens.Black, 0, 0, 100, 200);
            //}

            //pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            drawing = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                //bmp.SetPixel(e.X, e.Y, color);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    Point point = new Point(e.X, e.Y);
                    Pen pen = new Pen(color, width);
                    g.DrawLine(pen, start, point);
                    start = point;
                }
                pictureBox1.Image = bmp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            color = colorDialog1.Color;
        }

        private void Form12_SizeChanged(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = $"{e.NewValue}px";
            width = e.NewValue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            bmp.Save(filename, ImageFormat.Png);
            MessageBox.Show("Файл сохранен");
        }
    }
}
