using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEncrypter_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enc_code = "QsWaEzDxRfCtGvYhBuJnIkmOlP";

            string toCompile = textBox1.Text.ToLower();
            textBox1.Clear();
            char[] c = toCompile.ToCharArray();
            for (int x = 0; x < c.Length; x++)
            {
                for (int y = 0; y < 25; y++)
                {
                    if (c[x] == (char)(97 + y))
                    {
                        c[x] = enc_code[y];
                        break;
                    }
                }
            }
            textBox2.Text = new string(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string enc_code = "QsWaEzDxRfCtGvYhBuJnIkmOlP";
            string dec_code = "abcdefghijklmnopqrstuvwxyz";

            string toCompile = textBox4.Text;
            textBox4.Clear();
            char[] c = toCompile.ToCharArray();
            for (int x = 0; x < c.Length; x++)
            {
                for (int y = 0; y < 25; y++)
                {
                    if (c[x] == enc_code[y])
                    {
                        c[x] = dec_code[y];
                        break;
                    }
                }
            }
            textBox3.Text = new string(c);
        }
    }
}
