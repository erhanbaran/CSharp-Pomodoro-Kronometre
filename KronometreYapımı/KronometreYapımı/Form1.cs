using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KronometreYapımı
{
    public partial class Form1 : Form
    {
        int dakika = 0, saniye = 0, salise = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); timer2.Start(); timer3.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika++;
            label4.Text = dakika.ToString();
            if(dakika == 1)
            {
                timer1.Stop(); timer2.Stop(); timer3.Stop();
                MessageBox.Show("Tebrikler ! Pomodoro'nun ilk seansını başarıyla tamamladın!");

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(saniye == 59)
            {
                saniye = 0;
            }
            saniye++;
            label5.Text = saniye.ToString();
           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if(salise == 59)
            {
                salise = 0;
            }
            salise++;
            label6.Text = salise.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); timer2.Stop(); timer3.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop(); timer2.Stop(); timer3.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
            label4.Text = "______";
            label5.Text = "______";
            label6.Text = "______";
            dakika = 0;
            saniye = 0;
            salise = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
            timer3.Interval = 10;
            button2.Enabled = false;
        }
    }
}
