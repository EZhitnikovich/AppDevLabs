using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB9
{
    public partial class Form2 : Form
    {
        public Color ColorValue { get; set; }
        public event EventHandler ScrollBarRValueChageEvent;
        public event EventHandler ScrollBarGValueChageEvent;
        public event EventHandler ScrollBarBValueChageEvent;
        public Form2(int ColorR, int ColorG, int ColorB)
        {
            InitializeComponent();
            vScrollBar1.Value = ColorR;
            vScrollBar2.Value = ColorG;
            vScrollBar3.Value = ColorB;
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarBValueChageEvent?.Invoke(sender, e);
            label3.Text = vScrollBar3.Value.ToString();
            panel1.BackColor = Color.FromArgb(panel1.BackColor.R, panel1.BackColor.G, vScrollBar3.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarGValueChageEvent?.Invoke(sender, e);
            label2.Text = vScrollBar2.Value.ToString();
            panel1.BackColor = Color.FromArgb(panel1.BackColor.R, vScrollBar2.Value, panel1.BackColor.B);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollBarRValueChageEvent?.Invoke(sender, e);
            label1.Text = vScrollBar1.Value.ToString();
            panel1.BackColor = Color.FromArgb(vScrollBar1.Value, panel1.BackColor.G, panel1.BackColor.B);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ColorValue = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
