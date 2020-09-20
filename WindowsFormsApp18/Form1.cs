using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя 0123456789";
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = ori(textBox1.Text);
        }
        public string ori(string inp)
        {
            StringBuilder code = new StringBuilder();
            string s = textBox1.Text;
            string sd = textBox3.Text;
            int step = Convert.ToInt32(sd);
            for (int i = 0; i < s.Length; i++)
                for (int j = 0; j < Alphabet.Length; j++)
                    if (s[i] == Alphabet[j]) code.Append(Alphabet[j + step]%Alphabet.Length);
            return code.ToString();

        }
    }
}
