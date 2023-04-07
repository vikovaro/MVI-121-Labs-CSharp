using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        Dialog d = new Dialog();
        Figure ff; // ССЫЛКА
        public Form1()
        {
            InitializeComponent();
            d.FormClosed += new FormClosedEventHandler(d_FormClosed); // отслеживание закрытия формы dialog
        }

        private void button1_Click(object sender, EventArgs e) //равнобедренный треугольник - RavnobedTriangle
        {
            RavnobedTriangle F1 = new RavnobedTriangle();
            ff = F1;
            d.ShowDialog();
            //отслеживание закрытия формы
        }
        

        private void button2_Click(object sender, EventArgs e) //прямоугольный треугольник - RightTriangle
        {
            RightTriangle F2 = new RightTriangle();
            ff = F2;
            d.ShowDialog();
            //отслеживание закрытия формы
        }

        

        private void d_FormClosed(object sender, FormClosedEventArgs e)
        {
            ff.Height = d.X;
            ff.Width = d.Y;
        }
        

        private void button3_Click(object sender, EventArgs e) //КНОПКА РИСОВАТЬ
        {
            int x;
            int y; 
            if (ff != null)
            {
                
                bool result1 = int.TryParse(textBox1.Text, out var _);
                bool result2 = int.TryParse(textBox2.Text, out var _);

                //обработка результата преобразований 
                if (!result1 || !result2)
                {
                    // если хотя бы одно из чисел не int - выводим ошибку и очищаем неверное поле/неверные поля
                    MessageBox.Show("Введите целые числа!");
                    if (!result1) { textBox1.Text = ""; }
                    if (!result2) { textBox2.Text = ""; }
                }
                else
                {
                    x = int.Parse(textBox1.Text);
                    y = int.Parse(textBox2.Text);
                    Graphics g = CreateGraphics();
                    ff.Draw(g, x, y, ff.Width, ff.Height);
                }

            }
        }

        

        // 19.Первый вариант иерархии классов, 6, 7 варианты фигур.

        //Иерархия включает абстрактный базовый класс под названием «Фигура»,
        //и два его подкласса.Абстрактный класс содержит абстрактный метод
        //рисования фигуры и два поля или два свойства, определяющие размер
        //фигуры.В подклассах переопределяется абстрактный метод.

        //6. Равнобедренный треугольник, основание треугольника совпадает с
        //нижней базового прямоугольника, а противоположная основанию
        //вершина лежит на середине верхней стороны базового прямоугольника.
        //7. Прямоугольный треугольник, катеты которого совпадают со сторонами
        //базового прямоугольника
    }
}
