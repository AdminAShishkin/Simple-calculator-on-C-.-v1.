using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string Action;
        public string Number1;
        public bool Number2;
        public Form1()
        {
            Number2 = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(Number2)
            {
                Number2 = false;
                textBox1.Text = "0";
            }
            System.Windows.Forms.Button B = (System.Windows.Forms.Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button B = (System.Windows.Forms.Button)sender;
            Action = B.Text;
            Number1 = textBox1.Text;
            Number2 = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double dn1, dn2, result=0;
            dn1 = Convert.ToDouble(Number1);
            dn2=Convert.ToDouble(textBox1.Text);
            if(Action=="+") result=dn1+dn2;
            if(Action=="-") result=dn1-dn2;
            if(Action=="x") result=dn1*dn2;
            if(Action== "÷") result=dn1/dn2;
            if(Action=="%") result = dn1*dn2/100;
            Action = "=";
            Number2 = true;
            textBox1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(textBox1.Text);
            result=Math.Sqrt(dn);
            textBox1.Text=result.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(textBox1.Text);
            result = dn*dn;
            textBox1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(textBox1.Text);
            result = 1/dn;
            textBox1.Text = result.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double dn, result;
            dn = Convert.ToDouble(textBox1.Text);
            result = -dn;
            textBox1.Text = result.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Substring(0, textBox1.Text.Length-1);
                if (textBox1.Text == "")
                textBox1.Text = "0";
        }
    }
}
