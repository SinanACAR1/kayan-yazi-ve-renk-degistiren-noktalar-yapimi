using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yana_kayan_yazı_ve_renk_degıstıren_noktalar
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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
          
        }
        string isim = " SİNAN ACAR ";
        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = isim.Substring(1) + isim.Substring(0, 1);
            isim = label17.Text;
            Random random = new Random();
            int a = random.Next(0,255);
            int b = random.Next(0,255);
            int c = random.Next(0,255);
            label1.ForeColor = Color.FromArgb(a, b, c);
            label2.ForeColor = Color.FromArgb(a, b, c);
            label3.ForeColor = Color.FromArgb(a, b, c);
            label4.ForeColor = Color.FromArgb(a, b, c);
            label5.ForeColor = Color.FromArgb(a, b, c);
            label6.ForeColor = Color.FromArgb(a, b, c);
            label7.ForeColor = Color.FromArgb(a, b, c);
            label8.ForeColor = Color.FromArgb(a, b, c);
            label9.ForeColor = Color.FromArgb(a, b, c);
            label10.ForeColor = Color.FromArgb(a, b, c);
            label11.ForeColor = Color.FromArgb(a, b, c);
            label12.ForeColor = Color.FromArgb(a, b, c);
            label13.ForeColor = Color.FromArgb(a, b, c);
            label14.ForeColor = Color.FromArgb(a, b, c);
            label15.ForeColor = Color.FromArgb(a, b, c);
            label16.ForeColor = Color.FromArgb(a, b, c);
            label25.ForeColor = Color.FromArgb(a, b, c);
            label18.ForeColor = Color.FromArgb(a, b, c);
            label19.ForeColor = Color.FromArgb(a, b, c);
            label20.ForeColor = Color.FromArgb(a, b, c);
            label21.ForeColor = Color.FromArgb(a, b, c);
            label22.ForeColor = Color.FromArgb(a, b, c);
            label23.ForeColor = Color.FromArgb(a, b, c);
            label24.ForeColor = Color.FromArgb(a, b, c);
            label26.ForeColor = Color.FromArgb(a, b, c);
            label27.ForeColor = Color.FromArgb(a, b, c);
            label28.ForeColor = Color.FromArgb(a, b, c);
            label29.ForeColor = Color.FromArgb(a, b, c);
            label30.ForeColor = Color.FromArgb(a, b, c);
            label31.ForeColor = Color.FromArgb(a, b, c);
           
   
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }

        
    }
}
