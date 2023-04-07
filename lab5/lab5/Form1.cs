using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab5
{
    public partial class Form1 : Form
    {
        tochka Ob1 = new tochka();
        okr Ob2 = new okr(10);
        sektor Ob3 = new sektor(10, 100);
        rectangle Ob4 = new rectangle(5, 5);
        tochka t;
        public Form1()
        {
            InitializeComponent();
            t = Ob2;
        }
        
        // очистка полей после выбора объекта
        private void Ochistka()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Ochistka();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Ochistka();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Ochistka();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Ochistka();
        }
        // -- конец очистки


        
        private Boolean radioButtonSelected() // проверка выбранной кнопки
        {

            if (radioButton1.Checked)
            {
                t = Ob1;
            }
            else if (radioButton2.Checked)
            {
                t = Ob2;
            }
            else if (radioButton3.Checked)
            {
                t = Ob3;
            }
            else if (radioButton4.Checked)
            {
                t = Ob4;
            }
            else
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e) // ПЛОЩАДЬ
        {
            if (radioButtonSelected())
            {

                if (radioButton1.Checked)
                {
                    textBox1.Text = Math.Round(Ob1.S(), 2).ToString();
                }
                else if (radioButton2.Checked)
                {
                    textBox1.Text = Math.Round(Ob2.S(), 2).ToString();
                }
                else if (radioButton3.Checked)
                {
                    textBox1.Text = Math.Round(Ob3.S(), 2).ToString();
                }
                else if (radioButton4.Checked)
                {
                    textBox1.Text = Math.Round(Ob4.S(), 2).ToString();
                }

            }
            else
            {
                MessageBox.Show("Не выбран объект");
            }

        }

        private void button2_Click(object sender, EventArgs e) // ПЕРЕОПРЕДЕЛЕННЫЙ ВИРТУАЛЬНЫЙ МЕТОД ПЛОЩАДЬ
        {
            if (radioButtonSelected())
            {
                textBox2.Text = Math.Round(t.SV(), 2).ToString();
            }
            else
            {
                MessageBox.Show("Не выбран объект");
            }
        }

        private void button3_Click(object sender, EventArgs e) //ДИАМЕТР
        {
            if (radioButtonSelected())
            {
                if (t is okr)
                {
                    textBox3.Text = Math.Round(Ob2.Diametr(), 2).ToString();
                }
                else
                {
                    MessageBox.Show("Выбранный объект не соответствует методу");
                }
            }
            else
            {
                MessageBox.Show("Не выбран объект");
            }
        }

        private void button4_Click(object sender, EventArgs e) // ДЛИНА ДУГИ
        {
            if (radioButtonSelected())
            {

                if (t is sektor)
                {
                    textBox4.Text = Math.Round(Ob3.Ldugi(), 2).ToString();
                }
                else if (t is rectangle) {
                    textBox4.Text = Math.Round(Ob4.Perimetr(), 2).ToString();
                }
                else
                {
                    MessageBox.Show("Выбранный объект не соответствует методу");
                }
            }
            else
            {
                MessageBox.Show("Не выбран объект");
            }
        }

        private void button5_Click(object sender, EventArgs e) // ДИАГОНАЛЬ
        {
            if (radioButtonSelected())
            {
                if (t is rectangle)
                {
                    textBox5.Text = Math.Round(Ob4.Diag(), 2).ToString();
                }
                else
                {
                    MessageBox.Show("Выбранный объект не соответствует методу");
                }
            }
            else
            {
                MessageBox.Show("Не выбран объект");
            }
        }


    }

    class tochka // КЛАСС ТОЧКА
    {
        public double S()
        {
            return 0;
        }   
        public virtual double SV()
        {
            return 0;
        }
    }
    class okr : tochka
    {
        private double R;
        public okr(double r)
        {
            R = r;
        }

        public new double S()
        {
            return Math.PI * R * R;
        }
        public override double SV()
        {
            return Math.PI * R * R;
        }
        public double Diametr()
        {
            return R * 2;
        }


    }
    class sektor : tochka     // СЕКТОР
    {
        private double r;
        private double ugol;
        public sektor(double r, double ugol)
        {
            this.r = r;
            this.ugol = ugol;
        }
        public double S()
        {
            return Math.PI * r * r * (ugol / 360);
        }
        public override double SV()
        {
            return Math.PI * r * r * (ugol / 360);
        }
        public double Ldugi() //длина дуги
        {
            return Math.PI * r * (ugol / 360);
        }

    }
    class rectangle : tochka // прямоугольник
    {
        private double a;
        private double b;
        public rectangle(double a, double b)
        {
            this.a=a;
            this.b=b;
        }
        public double S()
        {
            return a * b;
        }
        public override double SV()
        {
            return a * b;
        }
        public double Diag()
        {
            return Math.Sqrt(a * a + b * b);
        }

        public double Perimetr()
        {
            return (a + b) * 2;
        }

    }
    
   
}
