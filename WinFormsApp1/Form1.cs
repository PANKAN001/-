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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //string[] person = {"Имя Фамилия Отчество Телефон Дата_Рождения"};



            //listBox1.Items.AddRange(person);

            //listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;


            //string[] lines = File.ReadAllLines(@"C:\Users\User105\Desktop\Новая папка (2)\TextInfo.txt");
            //string[] person = new string [100];
            //int number = 0;
            //foreach (string s in lines)
            //{
            // что-нибудь делаем с прочитанной строкой s
            //  person[number] = s;
            //  number++;
            //}
            //listBox1.Items.AddRange(person);
            string path = @"C:\Users\User105\Desktop\Новая папка (2)\TextInfo.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                int index = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Insert(index, line);
                    index++;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                string selectedPerson = listBox1.SelectedItem.ToString();

                string[] num_info = selectedPerson.Split(' ');

                //Имя
                textBox1.Text = num_info[0];
                //Фамилия
                textBox2.Text = num_info[1];
                //Отчество
                textBox3.Text = num_info[2];
                //Номер Телефона
                textBox4.Text = num_info[3];
                //Дата Рождения
                textBox5.Text = num_info[4];

                
            }
            catch (Exception)
            {
             
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //Добавить
        private void button1_Click(object sender, EventArgs e)
        {
            //Имя
            string textbox_1 = textBox1.Text;
            if (textBox1.Text == "")
            {
                textbox_1 = "Нет";
            }
            
            //Фамилия
            string textbox_2 = textBox2.Text;
            if (textBox2.Text == "")
            {
                textbox_2 = "Нет";
            }

            //Отчество
            string textbox_3 = textBox3.Text;
            if (textBox3.Text == "")
            {
                textbox_3 = "Нет";
            }

            //Номер Телефона
            string textbox_4 = textBox4.Text;
            if (textBox4.Text == "")
            {
                textbox_4 = "Нет";
            }

            //Дата Рождения
            string textbox_5 = textBox5.Text;
            if (textBox5.Text == "")
            {
                textbox_5 = "Нет";
            }

            string information = textbox_1 + " " + textbox_2 + " " + textbox_3 + " " + textbox_4 + " " + textbox_5;

            int number = listBox1.Items.Count;

            

            listBox1.Items.Insert(number, information);
        }
        //Изменить
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    int index = listBox1.SelectedIndex;
                    listBox1.Items.RemoveAt(index);

                    //Имя
                    string textbox_1 = textBox1.Text;
                    if (textBox1.Text == "")
                    {
                        textbox_1 = "Нет";
                    }

                    //Фамилия
                    string textbox_2 = textBox2.Text;
                    if (textBox2.Text == "")
                    {
                        textbox_2 = "Нет";
                    }

                    //Отчество
                    string textbox_3 = textBox3.Text;
                    if (textBox3.Text == "")
                    {
                        textbox_3 = "Нет";
                    }

                    //Номер Телефона
                    string textbox_4 = textBox4.Text;
                    if (textBox4.Text == "")
                    {
                        textbox_4 = "Нет";
                    }

                    //Дата Рождения
                    string textbox_5 = textBox5.Text;
                    if (textBox5.Text == "")
                    {
                        textbox_5 = "Нет";
                    }

                    string information = textbox_1 + " " + textbox_2 + " " + textbox_3 + " " + textbox_4 + " " + textbox_5;

                    listBox1.Items.Insert(index, information);

                }
            }
            catch (Exception)
            {

            }
        }
        //Удалить
        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Выберите элемент");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = @"C:\Users\User105\Desktop\Новая папка (2)\TextInfo.txt";

            if (e.CloseReason == CloseReason.UserClosing)
                using (StreamReader sr = new StreamReader(path))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            e.Cancel = true;
        }
    }
}
