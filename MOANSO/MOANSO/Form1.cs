﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOANSO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = int.Parse(textBox1.Text);
            b= int.Parse(textBox2.Text);

            c = a + b;

            textBox3.Text = c.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            c = a /b;

            textBox3.Text = c.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            c = a - b;

            textBox3.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            c = a *b;

            textBox3.Text = c.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}

