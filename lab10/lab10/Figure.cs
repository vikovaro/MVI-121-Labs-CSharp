using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Figure : Form
    {
        internal static int x;
        internal static int y;
        public Figure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                this.Close();
            }
            catch
            {
                Error(true);
            }

        }

        internal void Error(bool isValues)
        {
            if (isValues)
                MessageBox.Show("Введите корректное значение", "Ошибка");
            else
                MessageBox.Show("Выберите объект", "Ошибка");
        }
    }
}
