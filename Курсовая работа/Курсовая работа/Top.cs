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
    public partial class Top : Form
    {
        public Top()
        {
            InitializeComponent();
        }

        private void Top_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            int w=0;
            string filename = "Люди.txt";
            string filenameO = "Очки.txt";
            StreamReader reder = new StreamReader(filename);
            StreamReader rederO = new StreamReader(filenameO);
            while (!reder.EndOfStream)
            {
                label1.Text += reder.ReadLine()+'\n';
                w++;
            }
            reder.Close();
            while (!rederO.EndOfStream)
            {
                label2.Text += rederO.ReadLine() + '\n';
            }
            rederO.Close();
            this.Height = w * 67+40;
            this.Width = 210;
        }
    }
}
