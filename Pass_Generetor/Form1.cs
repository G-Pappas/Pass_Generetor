using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_Generetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int Maximum_Identical = 2; // Max number of identical characters in a row 
        const string lower_chars = "abcdefghijklmnopqrstuvwxyz"; // lower case chars
        const string capital_chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //capital chars
        const string numbers = "0123456789"; //numbers
        const string symbols = @"!#$%&*@\"; //symbols
        int lenght; //password lenght 
        string combination; // all chars will be added here

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder password = new StringBuilder(); //use stringbuilder so I can add more chars later
            lenght = Convert.ToInt32(numericUpDown1.Value); //take max lenght from numericUpDown
            Random rdm = new Random(); // random instance so I can use Next and don't get loops


            

            if (small_letters__Box.Checked)
            {             
                    combination += lower_chars;
            }


            if (capital_letters__Box.Checked)
            {
                   combination += capital_chars;
            }

            if (numbers_Box.Checked)
            {
                combination += numbers;
            }

            if (symbols_Box.Checked)
            {
                combination += symbols;
            }

            if (small_letters__Box.Checked || capital_letters__Box.Checked || numbers_Box.Checked || symbols_Box.Checked)
            {
                //add a random character to pass untill it reaches the selected lenght  
                while (lenght-- > 0)
                {
                    password.Append(combination[rdm.Next(combination.Length)]);
                    textBox1.Text = password.ToString();
                }
                combination = ""; // set combination to null so we can unselect a category 
            }
            else
            {
                textBox1.Text = "Please select at least one category";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         MessageBox.Show("Beta Version 0.8" + Environment.NewLine + "Created by George Pappas");
        }
    }
}