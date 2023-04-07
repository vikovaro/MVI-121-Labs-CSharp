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
        okr[] Mas = new okr[22];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 22; i++)
            {
                Mas[i] = new okr(i+1);
            }
        }

        //ввод
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { MessageBox.Show("Не введено число"); return; }

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выделена ячейка"); return;
            }
            double r = (double)int.Parse(textBox1.Text);
            Mas[listBox1.SelectedIndex].setR(r);
        }
          //вывод
        private void button1_Click(object sender, EventArgs e)
        {
            int N = listBox1.SelectedIndex;
            if (N == -1)
            {
                MessageBox.Show("Не выделена ячейка"); return;
            }
            textBox2.Text = Mas[N].DlinaOkr().ToString();
            textBox3.Text = Mas[N].Sokr().ToString();
            textBox1.Text = Mas[N].getR().ToString();

        }
        //очистить
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        //вывести информацию
        private void button4_Click(object sender, EventArgs e)
        {
            String s; // для формирования строки вывода
            for (int i = 0; i < 22; i++)
            {
                s = "Элемент " + i.ToString() + "; значение R=" + Mas[i].getR().ToString() + "; Длина=" + Math.Round(Mas[i].DlinaOkr(), 2).ToString() + "; Площадь=" + Math.Round(Mas[i].Sokr(), 2).ToString();
                listBox1.Items.Add(s);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
        }
    }
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
