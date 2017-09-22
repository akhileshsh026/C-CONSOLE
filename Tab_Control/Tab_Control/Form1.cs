using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tab_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Orange;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Pink;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.White;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Gray;
        }
    }
}
