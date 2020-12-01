using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB11
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Picture(*.png)|*.png|Picture(*.jpg)|*.jpg|Picture(*.gif)|*.gif";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string path = openFileDialog1.FileName;

            pictureBox1.Image = Image.FromFile(path);
            pictureBox2.Image = Image.FromFile(path);
            pictureBox3.Image = Image.FromFile(path);
            pictureBox4.Image = Image.FromFile(path);
            pictureBox5.Image = Image.FromFile(path);
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            string path = "sample.jpg";

            pictureBox1.Image = Image.FromFile(path);
            pictureBox2.Image = Image.FromFile(path);
            pictureBox3.Image = Image.FromFile(path);
            pictureBox4.Image = Image.FromFile(path);
            pictureBox5.Image = Image.FromFile(path);
        }
    }
}
