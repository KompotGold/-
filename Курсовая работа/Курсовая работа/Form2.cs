using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0)
            {
                string filename = "Вопросы.txt";
                string filenameAnswer = "Ответы.txt";
                //filename-переменная, которая хранит путь к файлу с вопросами и ответами

                StreamWriter writer = new StreamWriter(filename, true);//Созданре объекта на запись файла
                StreamWriter writerAnswer = new StreamWriter(filenameAnswer, true);

                writer.WriteLine(textBox1.Text);
                writer.WriteLine(textBox2.Text);
                writer.Close();
                writerAnswer.WriteLine(textBox2.Text);
                writerAnswer.Close();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        else
            {
                MessageBox.Show("Введите вопрос и ответ","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

    }
    }
