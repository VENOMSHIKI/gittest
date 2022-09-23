using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
private void button1_Click(object sender, EventArgs e)
        {
            long g = Convert.ToInt64(textBox1.Text);
            long p = Convert.ToInt64(textBox2.Text);
            long a = Convert.ToInt64(textBox3.Text);
            long b = Convert.ToInt64(textBox4.Text);
            double A = Math.Pow(g, a) % p;
            double B = Math.Pow(g, b) % p;
            textBox5.Text = A.ToString();
            textBox6.Text = B.ToString();
            double k = Math.Pow(B, a) % p;
            double K = Math.Pow(A, b) % p;
            textBox7.Text = k.ToString();
            textBox8.Text = K.ToString();
        }

    }
}
