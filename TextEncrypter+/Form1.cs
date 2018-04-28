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

        String mode = "Encrypt";

        public Form1()
        {
            InitializeComponent();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void compileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "Encryption Meathod: Encrypt";
            this.mode = "Encrypt";        
        }

        private void decompileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Encryption Meathod: Decrypt";
            this.mode = "Decrypt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.mode == "Decrypt")
            {
                textBox2.Text = Base64Decode(textBox1.Text);
                textBox1.Clear();
            } else
            {
                textBox2.Text = Base64Encode(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
