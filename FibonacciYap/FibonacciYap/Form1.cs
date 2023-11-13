using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FibonacciYap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string FibonacciBul(TextBox t1)
        {
            int deger = Int32.Parse(t1.Text);
            int sayi = 1, sayi2 = 1;
            int tpl = 0;
            string sonuc = "1-1";
            

            for (; ; )
            {
                tpl = sayi + sayi2;

                if (tpl>deger)
                {
                    break;
                }

                sonuc += "-" + tpl.ToString();
                sayi = sayi2;
                sayi2 = tpl;

            }
            return sonuc;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = FibonacciBul(textBox1);
        }
    }
}
