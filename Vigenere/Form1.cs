using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] characters = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                                            'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            int N = characters.Length;
            string keyword = textBox1.Text;
            string input = textBox2.Text;
            string result = "";
            int keyword_index = 0;
            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) + Array.IndexOf(characters, keyword[keyword_index])) % N;
                result += characters[c];
                keyword_index++;
                if ((keyword_index + 1) == keyword.Length)
                        keyword_index = 0;
            }
            MessageBox.Show(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] characters = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                                            'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            int N = characters.Length;
            string keyword = textBox1.Text;
            string input = textBox2.Text;
            string result = "";
            int keyword_index = 0;
            foreach (char symbol in input)
            {
                int p = (Array.IndexOf(characters, symbol) + N - Array.IndexOf(characters, keyword[keyword_index])) % N;
                result += characters[p];
                keyword_index++;
                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }
            MessageBox.Show(result);
        }
    }
}
