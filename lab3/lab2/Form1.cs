using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        okr o1 = new okr(10); // поля главной формы
        okr o2 = new okr(5);
        okr o3 = new okr(5);
        okr o4 = new okr();
        okr o5 = new okr();

        okr A;
        public Form1()
        {
            InitializeComponent();
        }


        private Boolean radioButtonChoise()
        {
            
            if (radioButton1.Checked)
            {
                A = o1;
            }
            else if (radioButton2.Checked)
            {
                A = o2;
            }
            else if (radioButton3.Checked)
            {
                A = o3;
            }
            else if (radioButton4.Checked)
            {
                A = o4;
            }
            else if (radioButton5.Checked)
            {
                A = o5;
            } else
            {
                return false;
            }
            return true; 
        }

        //ввод
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Не введено число"); return; }
            
            double r = (double)int.Parse(textBox1.Text);

            if (!radioButtonChoise()) {
                MessageBox.Show("Объект не выбран", "Внимание!");
                return;
            }

            A.setR(r);

        }
          //вывод
        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButtonChoise())
            {
                return;
            }
            textBox2.Text = A.DlinaOkr().ToString();
            textBox3.Text = A.Sokr().ToString();

            textBox1.Text = A.getR().ToString();

        }
        // кнопка расчет
        private void button3_Click(object sender, EventArgs e)
        {
            double r = (double)int.Parse(textBox1.Text);
            okr b = new okr(r);

            button3.Text = "Длина окружности:\n" + b.DlinaOkr().ToString() + "\nПлощадь окружности:\n" + b.Sokr().ToString();


        }

       

    }

    //4) Класс, описывающий окружность. Класс должен иметь методы, решающие следующие задачи:
    // a.расчет длины окружности;
    // b.расчет площади окружности.
    class okr
    {
        private double R; 
        
        public okr() {
            Random rnd = new Random();
            int value = rnd.Next(5, 15);
            this.R = value; // значение по умолчанию
        }
        public okr(double r)
        {
            this.R = r;
        }
        public double DlinaOkr()
        {
            return 2*Math.PI * this.R;
        }
        public double Sokr()
        {
            return Math.PI * this.R * this.R;
        }
        public bool setR(double r)
        {
            if (r>4 && r<16) { 
                this.R = r; 
                return true;
            } 
            
            MessageBox.Show("Ошибка");
            return false;
        }

        public double getR()
        {
            return this.R;
        }
    }
}
