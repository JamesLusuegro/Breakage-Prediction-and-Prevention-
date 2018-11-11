using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aboitiz_Water_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = PressureMonitor.Height;
            panel4.Top = PressureMonitor.Top;
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            panel4.Height = Home.Height;
            panel4.Top = Home.Top;
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void PipeMap_Click(object sender, EventArgs e)
        {
            panel4.Height = PipeMap.Height;
            panel4.Top = PipeMap.Top;
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Inspections_Click(object sender, EventArgs e)
        {
            panel4.Height = Inspections.Height;
            panel4.Top = Inspections.Top;
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
