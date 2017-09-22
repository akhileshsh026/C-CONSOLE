using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Label_TextBox_Control
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            log.Info("Logged 1st time");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

     
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Connot leave empty");
                tb.BackColor = Color.Red;
                e.Cancel = true;
                return;
            }
            if (tb.Name != "textBox1")
            {
                if (tb.Text.Trim().Length < 8)
                {
                    MessageBox.Show("Passsword sholud be between 8 to 16 char");
                    e.Cancel = true;
                    return;
                }
            }
            if (tb.Name == "textBox3")
            {
                if (textBox2.Text.Trim() != textBox3.Text.Trim())
                {
                    MessageBox.Show("Password not macthed");
                    return;
                }
                button1.BackColor = Color.Green;
                button1.Enabled = true;
            }
        }
    }
}
