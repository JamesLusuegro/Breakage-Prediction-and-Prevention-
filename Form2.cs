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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Show();
            label1.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label3.Show();
            label1.Hide();
            label2.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label4.Show();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label5.Show();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
            label7.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String txt = serialPort1.ReadExisting();
            SetText(txt.ToString());
        }
        delegate void SetTextCallBack(string text);

        private void SetText(string text)
        {

            if (this.label7.InvokeRequired)
            {
                SetTextCallBack a = new SetTextCallBack(SetText);
                this.Invoke(a, new object[] { text });


            }

            else
            {
                this.label7.Text = text;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
