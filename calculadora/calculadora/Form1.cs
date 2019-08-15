using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
     
    public partial class Form1 : Form
    {
        double a;
        double b;
        string c;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button14_Click(object sender, EventArgs e)
        {

            this.txt_calcu.Text = "0";


        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "0";
            }
            else
            {
                txt_calcu.Text += "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_calcu.Text = "0";
        }

        

        private void Txt_calcu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "1";
            }
            else
            {
                txt_calcu.Text += "1";
            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "2";
            }
            else
            {
                txt_calcu.Text += "2";
            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "3";
            }
            else
            {
                txt_calcu.Text += "3";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "4";
            }
            else
            {                      
               txt_calcu.Text += "4";
            }
            
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "5";
            }
            else
            {
                txt_calcu.Text += "5";
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "6";
            }
            else
            {
                txt_calcu.Text += "6";
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "7";
            }
            else
            {
                txt_calcu.Text += "7";
            }

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "8";
            }
            else
            {
                txt_calcu.Text += "8";
            }

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (txt_calcu.Text == "")
            {
                txt_calcu.Text += "9";
            }
            else
            {
                txt_calcu.Text += "9";
            }

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (this.txt_calcu.Text.Contains(',') == false)
            {
                this.txt_calcu.Text +=",";
            }

        }

        private void Btn_suma_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txt_calcu.Text);
            c = "+";
            this.txt_calcu.Clear();
            this.txt_calcu.Focus();          
        }

        private void Btn_division_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txt_calcu.Text);
            c = "/";
            this.txt_calcu.Clear();
            this.txt_calcu.Focus();
        }

        private void Btn_multi_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txt_calcu.Text);
            c = "*";
            this.txt_calcu.Clear();
            this.txt_calcu.Focus();
        }

        private void Btn_resta_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txt_calcu.Text);
            c = "-";
            this.txt_calcu.Clear();
            this.txt_calcu.Focus();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.txt_calcu.Text);
            switch (c)
            {
                case "+":
                    this.txt_calcu.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.txt_calcu.Text = Convert.ToString(b - a);
                    break;

                case "*":
                    this.txt_calcu.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.txt_calcu.Text = Convert.ToString(b /a);
                    break;
            }
        }
    }
}
