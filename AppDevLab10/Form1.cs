using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace LAB10
{
    public partial class Form1 : Form
    {
        private static string path = @"C:\Users\1\source\repos\РП\LAB10\settings.ini";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == ' ')
            {
                textBox1.Text += e.KeyChar;
                textBox1.SelectionStart = textBox1.Text.Length;
            }
            else if (e.KeyChar == (char)13 && textBox1.Text != "" && comboBox1.Text == "Добавить")
            {
                listBox1.Items.Insert(listBox1.Items.Count, textBox1.Text);
                textBox1.Clear();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lineText = listBox1.SelectedItem.ToString();

            List<string> array = Manager.GetOddGroups(lineText);

            foreach (string s in array)
            {
                textBox2.Text += "В элементе " + s + " - " + Manager.CalculateUnits(s) + " единицы\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();

            if (selectedState == "Очистить всё")
            {

                DialogResult result = MessageBox.Show(
                                           "Очистить всё?",
                                           "Yes/No",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Information,
                                           MessageBoxDefaultButton.Button1,
                                           MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.Yes)
                {
                    textBox1.Text = "";
                    listBox1.Items.Clear();
                    textBox2.Text = "Результаты ст.гр 10701219 " +
                            "Житникович Е.Н.\r\n";
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(path) &&
                MessageBox.Show("Загрузить предыдущие сохраненные параметры?",
                                "Загрузка",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                INIManager manager = new INIManager(path);
                textBox1.Text = manager.GetPrivateString("InputTextBox", "value");

                int count = int.Parse(manager.GetPrivateString("ListBox", "count"));
                for (int i = 0; i < count; i++)
                {
                    listBox1.Items.Add(manager.GetPrivateString("ListBox", $"line{i}"));
                }
            }
            comboBox1.Text = "Добавить";

            FileInfo fi1 = new FileInfo(path);
            if (!File.Exists(path))
            {
                using (StreamWriter sw = fi1.CreateText());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить данные полей?",
                                "Сохранение",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.WriteAllText(path, string.Empty);

                INIManager manager = new INIManager(path);

                manager.WritePrivateString("ListBox", $"count", listBox1.Items.Count.ToString());
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    manager.WritePrivateString("ListBox", $"line{i}", listBox1.Items[i].ToString());
                }

                manager.WritePrivateString("InputTextBox", "value", textBox1.Text);
            }
        }
    }
}
