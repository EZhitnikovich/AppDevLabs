using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static LAB6.Manager;

namespace LAB6
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<Item>> items = new Dictionary<string, List<Item>>();

        public Form1()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Text files(*.txt)|*.txt";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            items = new Dictionary<string, List<Item>>();

            string filename = openFileDialog1.FileName;

            string fileText = File.ReadAllText(filename);

            richTextBox1.Text = fileText;

            MessageBox.Show("Файл открыт\n(для просмотра)");
        }

        private void buttonFSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            string str = null;

            foreach (var element in items.Keys)
            {
                str += element + "\r\n";
                foreach (var value in items[element])
                {
                    str += value.GetInfo();
                }

                str += "\n\r";
            }

            File.WriteAllText(filename, str);

            MessageBox.Show("Файл сохранен");
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string answer = null;

            foreach (var el in items)
            {
                double allTime = 0;
                double price = 0;
                foreach (var value in el.Value)
                {
                    allTime += value.Time;
                    price += value.Time * value.Tax;
                }
                answer += el.Key + ": среднее время " + allTime / el.Value.Count + ", цена " + price + " руб.";
            }
            richTextBox1.Text += answer;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Item item = new Item
            {
                Time = ConvertToInt(textBoxCTime.Text),
                NumberC = ConvertToInt(textBoxNCity.Text),
                NumberA = ConvertToInt(textBoxNA.Text),
                CityName = textBoxCity.Text,
                Data = textBoxData.Text,
                CityCode = ConvertToInt(textBoxCCode.Text),
                Tax = ConvertToInt(textBoxTax.Text)
            };

            if (!items.ContainsKey(item.CityName.ToUpper()))
                items.Add(item.CityName.ToUpper(), new List<Item> { item });
            else
                items[item.CityName.ToUpper()].Add(item);

            string str = null;

            foreach (var element in items.Keys)
            {
                str += element + "\r\n";
                foreach (var value in items[element])
                {
                    str += value.GetInfo();
                }

                str += "\n\r";
            }

            richTextBox1.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxCCode.Text = "7";
            textBoxCity.Text = "Минск";
            textBoxCTime.Text = "27";
            textBoxData.Text = "17 январь";
            textBoxNA.Text = "6652412";
            textBoxNCity.Text = "2245212";
            textBoxTax.Text = "2";
        }
    }
}
