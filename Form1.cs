using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(textBox1.Text); int q = Convert.ToInt32(textBox2.Text);
            int n = 0;
            int f = 0;
            int E = 0;
            int d = 0;
            n = p * q;
            f = (p - 1) * (q - 1);
            //вычисление ключей
            for (int i = 17; i <= f; i++)
                if (IsSimple(i) && (f % i != 0))
                {
                    E = i;
                }
            textBox3.Text += E + "," + n.ToString();
            for (int i = 17; i <= f; i++)
            {
                if (IsSimple(i) && (i * E % f == 1))
                {
                    d = i;
                }
            }
            textBox4.Text += d + "," + n.ToString();
            //шифрование
            int P = Convert.ToInt32(textBox5.Text);
            int r = (p ^ E) % n;
            textBox6.Text += r.ToString();
            //расшифровка
            int v = (r ^ d) % n;
            textBox7.Text += v.ToString();
        }
        public static bool IsSimple(int N)
        {
            for (int i = 16; i <= N / 16; i++)
            {
                if (N % 1 == 0)
                    return false;
            }
            return true;
        }

    }
}
