using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_arch
{
    public partial class Form1 : Form
    {
        okr o1 = new okr(10); // поле главной формы
        public Form1()
        {
            InitializeComponent();
        }
        
        // кнопка ввод
        private void button1_Click(object sender, EventArgs e)
        {
            o1.R = (double)int.Parse(textBox1.Text);
        }

        // кнопка вывод
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = o1.DlinaOkr().ToString();
            textBox3.Text = o1.Sokr().ToString();
        }

        // кнопка расчет
        private void button3_Click(object sender, EventArgs e)
        {
            double r = (double)int.Parse(textBox1.Text);
            okr b = new okr(r);

            button3.Text = "Длина окружности:\n" + b.DlinaOkr().ToString() + "\nПлощадь окружности:\n" + b.Sokr().ToString();


        }

        class okr
        {
            public double R;
            public okr(double r)
            {
                this.R = r;
            }
            public double DlinaOkr()
            {
                return 2 * Math.PI * this.R;
            }
            public double Sokr()
            {
                return Math.PI * this.R * this.R;
            }
            public void setR(double r)
            {
                this.R = r;
            }

            public double getR()
            {
                return this.R;
            }
        }

        
    }
}
