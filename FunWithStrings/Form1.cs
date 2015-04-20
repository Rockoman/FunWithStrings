using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithStrings
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create string from text
            string test = txtInput.Text.ToString();
            //create array from the text
            char[] reverseChar = txtInput.Text.ToCharArray();
            //reverse char
            Array.Reverse(reverseChar);
            //assign reversed char to a string
            string reverseStr = new string(reverseChar);

            //convert text to uppercase
            label1.Text = txtInput.Text.ToUpper();
            //convert text to lowercase
            label2.Text = txtInput.Text.ToLower();
            //display entire reversed text
            label3.Text = reverseStr;
            //display reversed text by word
            label4.Text = ReverseWords(reverseStr);
            //display sentence in reverse order
            label10.Text = ReverseWords(test);
        }

        private static string ReverseWords(string x)
        {
            string[] words = x.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
