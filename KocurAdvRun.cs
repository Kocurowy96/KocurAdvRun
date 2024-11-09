using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KocurAdvRun
{
    public partial class KocurAdvRun : Form
    {
        public KocurAdvRun()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {

            }
            else {
                if (File.Exists(textBox1.Text)) {
                    textBox3.Text = "";
                    Process.Start(textBox1.Text, textBox2.Text);
                }
                else
                {
                    textBox3.Text = "Error: File not found";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { 

        }
    }
}
