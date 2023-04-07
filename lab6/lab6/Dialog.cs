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
    public partial class Dialog : Form
    {
        public int X;
        public int Y;

        public Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //попытки преобразования в int
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
                X = int.Parse(textBox1.Text);
                Y = int.Parse(textBox2.Text);
                this.Close(); //закрытие формы
            }
               

        }
    }
}
