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
    public partial class Users : Form
    {
        Game game;
        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            string filename = "Люди.txt";
            StreamReader reader = new StreamReader(filename);
            while (!(reader.EndOfStream))
            {
                comboBox1.Items.Add(reader.ReadLine());
            }
            reader.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename="Люди.txt";
            string name="";
            List<string> nameList = new List<String>();
            StreamReader reder = new StreamReader(filename);
            while (!reder.EndOfStream)
            {
                nameList.Add(reder.ReadLine());
            }
            string[] nameArray=nameList.ToArray();
            for (int i = 0; i < nameArray.Length; i++)
            {
                comboBox1.Items.Add(nameArray[i]);
            }
            if (comboBox1.Text.Length != 0)
            {
                name = comboBox1.Text;
                game = new Game(name);
                game.Show();
                this.Close();
                reder.Close();
            }
            else
            {
                MessageBox.Show("Выберите имя из списка","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {if (textBox1.Text.Length != 0)
            {
                string Name;
                string filename = "Люди.txt";
                string filenameO = "Очки.txt";
                Name = textBox1.Text;

                StreamWriter writer = new StreamWriter(filename, true);
                writer.WriteLine(Name, true);
                StreamWriter writeO = new StreamWriter(filenameO, true);
                writeO.WriteLine("0", true);
                writer.Close();
                writeO.Close();
                game = new Game(Name);
                game.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите имя","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled=true;
        }
    }
}
