using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab8
{

    public partial class Form1 : Form
    {
        private int size = 0;

        public Form1()
        {
            InitializeComponent();
            label6.Text = "";
        }

        private void Boxes()
        {
            if (listBox1.SelectedIndex != -1)
            {
                string str = "Объект " + size + ": " + TrList.PiList[TrList.p].getInfo();
                listBox1.Items.Insert(listBox1.SelectedIndex + 1, str);
                listBox2.Items.Insert(listBox2.SelectedIndex + 1, str);
                size++;
            }
            else
            {
                string str = "Объект " + size + ": " + TrList.PiList[TrList.p].getInfo();
                listBox1.Items.Insert(size, str);
                listBox2.Items.Insert(size, str);
                size++;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            // проверка на число
            if (!int.TryParse(textBox1.Text, out _) || !int.TryParse(textBox2.Text, out _))
            {
                if (!int.TryParse(textBox1.Text, out _))
                    textBox1.Text = "";

                if (!int.TryParse(textBox2.Text, out _))
                    textBox2.Text = "";
                MessageBox.Show("Введите целые числа");
                return;
            }

            // проверка что число >0
            if (Convert.ToInt32(textBox1.Text) <= 0 || Convert.ToInt32(textBox2.Text) <= 0)
            {
                if (Convert.ToInt32(textBox1.Text) <= 0)
                    textBox1.Text = "";
                if (Convert.ToInt32(textBox2.Text) <= 0)
                    textBox2.Text = "";
                MessageBox.Show("Числа не могут быть отрицательными/равными нулю");
                return;
            }


            //РАБОТАЕМ
            RavnobedTriangle TempTriangle = new RavnobedTriangle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            TrList.Add(TempTriangle);
            Boxes();



        }

        //Кнопка очистки, очищаем листбоксы и список
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label6.Text = "";
            TrList.Clear();
            size = 0;
        }

        //класс для проверки выбранных объектов
        public bool proverka()
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите первый объект");
                return false;
            }

            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите второй объект");
                return false;
            }

            return true;
        }

        //+
        private void button4_Click(object sender, EventArgs e)
        {
            if (!proverka()) return; //проверка на выбранные объекты

            if (TrList.PiList[listBox1.SelectedIndex] + TrList.PiList[listBox2.SelectedIndex] == null)
            {  //в случае если треугольники одинаковые
                return; 
            } 
            
            label6.Text = "Треугольник с большей площадью:\n" + (TrList.PiList[listBox1.SelectedIndex] + TrList.PiList[listBox2.SelectedIndex]).getInfo().ToString();




        }

        //*
        private void button3_Click(object sender, EventArgs e)
        {
            if (!proverka()) return; //проверка на выбранные объекты

            label6.Text = "Умножение высот:\n" + (TrList.PiList[listBox1.SelectedIndex] * TrList.PiList[listBox2.SelectedIndex]).ToString();
        }

        //< >
        private void button5_Click(object sender, EventArgs e)
        {
            if (!proverka()) return; //проверка на выбранные объекты

            if (TrList.PiList[listBox1.SelectedIndex] > TrList.PiList[listBox2.SelectedIndex])
            {
                label6.Text = "Больший треугольник:\n" + TrList.PiList[listBox1.SelectedIndex].getInfo().ToString();
            }
            else if (TrList.PiList[listBox1.SelectedIndex] < TrList.PiList[listBox2.SelectedIndex]) {
                label6.Text = "Больший треугольник:\n" + TrList.PiList[listBox2.SelectedIndex].getInfo().ToString();
            } else
            {
                label6.Text = "Треугольники равны";
            }

        }

        // /
        private void button6_Click(object sender, EventArgs e)
        {
            //проверка на число
            if (!int.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("Ошибка. Введите число.");
                return;
            }
            
            //проверка на выбранный объект
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите элемент из 1 списка");
                return;
            }
            
            //проверка что число >0
            if (Convert.ToInt32(textBox3.Text) <= 0)
            {
                MessageBox.Show("Число не должно быть равно нулю или быть меньше, чем 0");
                return;
            }

            //работаем
            int k = Convert.ToInt32(textBox3.Text);
            RavnobedTriangle res = TrList.PiList[listBox1.SelectedIndex] / (double)k;
            label6.Text = "Результат:\n"+res.getInfo();

            
        }
    }

    

    

}
