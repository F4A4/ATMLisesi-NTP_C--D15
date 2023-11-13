using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calısma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("FATMA");
            listBox1.Items.Add("KÜBRA");
            listBox1.Items.Add("HAFİZE");
            listBox1.Items.Add("BEYZA");
            listBox1.Items.Add("AYNUR");
            listBox1.Items.Add("ÖMER");
            listBox1.Items.Add("SITKI");
            listBox1.Items.Add("HAYDAR");
            listBox1.Items.Add("OSMAN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < listBox1.Items.Count; i++)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                MessageBox.Show(listBox1.Items[i].ToString());
            }
                   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Belirtileni siler index sayısı belli olanı
            int sira = Int32.Parse(textBox1.Text);
            listBox1.Items.RemoveAt(sira);
        }

        private void button8_Click(object sender, EventArgs e)
        { 
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(listBox1.Items[i]);  
            }     
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedIndex.ToString());
            //MessageBox.Show(listBox1.SelectedItem.ToString());

            ////1.YOL:
            //listBox1.Items.Remove(listBox1.SelectedItem);


            //2.YOL:
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
              
            
        }

        
        
    }

