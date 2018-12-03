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
    public partial class Form1 : Form
    {
        Users users;
        Form2 AddQ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();//закрыть форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddQ = new Form2();
            AddQ.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            users = new Users();
            users.Show();
        }

        private void таблицаУчастниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Top top = new Top();
            top.Show();
        }
    }
}
