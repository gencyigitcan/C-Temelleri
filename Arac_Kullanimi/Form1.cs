using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Yiğitcan";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Şimdilik boş duruyor.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Yiğitcan";
            label7.Text = "Genç";
            label9.Text = "Full Stack Developer";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Full Stack Developer";

            label2.Text = textBox1.Text;
        }
    }
}
