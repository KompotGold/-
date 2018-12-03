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
    public partial class Game : Form
    {
        private string NameClass;
        private int n = 1;
        private int glasses = 0;
        List<string> qList = new List<String>();
        List<string> answerList = new List<String>();
        List<string> ansList = new List<string>();
        string[] qArray;
        string[] aArray;
        string[] answerArray;
        private int v;

        public Game(string Name)
        {
            InitializeComponent();
            NameClass = Name;

        }
        public Game()
        {
            InitializeComponent();

        }



        private void Game_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = "Играет польователь:" + NameClass;
            label3.Text += " " + n.ToString() + " из 10";

            string filename = "Вопросы.txt";
            string filenameAnswer = "Ответы.txt";

            StreamReader reder = new StreamReader(filename);
            StreamReader rederAnswer = new StreamReader(filenameAnswer);
            while (!rederAnswer.EndOfStream)
            {
                
                ansList.Add(rederAnswer.ReadLine());
            }
            rederAnswer.Close();
            answerArray = ansList.ToArray();
            while (!reder.EndOfStream)
            {
                qList.Add(reder.ReadLine());
                answerList.Add(reder.ReadLine());
            }
            qArray = qList.ToArray();
            aArray = answerList.ToArray();
            reder.Close();
            Random random = new Random();
            v = random.Next(0, qArray.Length - 1);

            label2.Text = qArray[v];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string answer = textBox1.Text;
            textBox1.Text = "";
            if (n >= 1 && n <=10)
            {
                if (answer.ToLower() == aArray[v].ToLower())
                {
                    glasses++;
                    n++;
                    
                }
                else
                {
                    n++;
                    MessageBox.Show("Не правильно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                    Random random = new Random();
                    v = random.Next(0, qArray.Length - 1);
                    label2.Text = qArray[v];
                    label3.Text = "Вопрос " + (n - 1).ToString() + " из 10";
             
            }
            else
            {
                MessageBox.Show("Игра закончена\n вы набрали "+ glasses+" очков", "Сообщение", MessageBoxButtons.OK);
                SaveNameCol();
                //Form1 form1 = new Form1();
                this.Close();
                //form1.Show();
            }
            

        }
        private void SaveNameCol()
        {
            string filenameName = "Люди.txt";
            string filenameO = "Очки.txt";
            int j = 0;
            int jTime=0;
            string NameTime;
            List<string> col = new List<string>();
            string[] colArray;
            StreamReader rederName = new StreamReader(filenameName);
            while (!rederName.EndOfStream)
            {
                NameTime=rederName.ReadLine();
                if (NameTime == NameClass)
                {
                    jTime = j;
                    break;
                }
                else
                {
                    j++;
                }
            }
            rederName.Close();
            StreamReader rederO = new StreamReader(filenameO);
            while (!rederO.EndOfStream)
            {
                col.Add(rederO.ReadLine());
            }
            rederO.Close();
            colArray = col.ToArray();
            colArray[jTime] = glasses.ToString();
            StreamWriter writeO = new StreamWriter(filenameO);
            for(int i = 0; i < colArray.Length; i++)
            {
                writeO.WriteLine(colArray[i]);
            }
            writeO.Close();
        }
    }


}

