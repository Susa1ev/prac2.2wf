﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac2._2_wf_
{
    public partial class Form1 : Form
    {
        int ball;
        string result;
        public Form1()
        {
            InitializeComponent();
        }
        string countTheBall()
        {
            if (Int32.TryParse(textBox1.Text, out ball) && (ball >= 0) && (ball <= 100))
            {
                if (ball < 50)
                {
                    result = "неудовлетворительно";
                }
                else if (ball < 70)
                {
                    result = "удовлетворительно";
                }
                else if (ball < 90)
                {
                    result = "хорошо";
                }
                else if (ball < 100)
                {
                    result = "отлично";
                }
                return result;
            }
            else
            {
                MessageBox.Show("Вы ввели что-то не то");
                return "ошибка";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Оценка: " + countTheBall();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Оценка: Отлично";
        }
    }
}
