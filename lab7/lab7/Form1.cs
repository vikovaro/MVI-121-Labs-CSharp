using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace lab7
{
    public partial class Form1 : Form
    {

        // ЕСЛИ ПИЗДИТЕ МОЙ КОД, СНАЧАЛА ДОБАВЬТЕ НА ФОРМУ 2 КНОПКИ И LABLE, А УЖЕ ПОТОМ ВСТАВЛЯЙТЕ КОД
        
        Queue myQueue = new Queue(); // 12 - размер накопителя для очереди
        Random rnd = new Random(); // для генератора рандомных чисел

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Элементов в очереди: " + myQueue.Size().ToString();
        }
        



        // Заполнение очереди рандомными значениям
        // Невероятно гениальный генератор для заполнения очереди значениями, используется в классе button2_Click
        // Генерация длины от 1 до 2, и заполнение случайными символами посредством конвертации из ASCII
        public string Generator()
        {
            int nameLength = rnd.Next(1, 3); // генерируем случайное число от 1 до 2
            string name = "";

            for (int i = 0; i < nameLength; i++)
            {
                int asciiValue = rnd.Next(97, 123); // генерация случайного числа от 97 до 122
                char character = (char)asciiValue; // конвертируем число в ASCII-символ
                name += character.ToString(); // добавляем символ к имени
            }
            return name;
        }



        private void button2_Click(object sender, EventArgs e) //добавление
        {
            Graphics g = CreateGraphics();
            myQueue.Enqueue(new unit(Generator().ToString()));
            myQueue.Draw(g);
            label2.Text = "Элементов в очереди: " + myQueue.Size().ToString();

        }
        private void button1_Click(object sender, EventArgs e) //удаление
        {
            Graphics g = CreateGraphics();

            if (myQueue.Size() == 0)
            {
                MessageBox.Show("Ошибка. Очередь пуста.");
                return;
            }


            myQueue.Dequeue();
            myQueue.Draw(g);
            label2.Text = "Элементов в очереди: " + myQueue.Size().ToString();
        }


        

        //Вариант 4. Класс, содержащий следующие члены.
        //a.Поле, в котором хранится имя элемента, имя запрашивается у пользователя в момент создания элемента;
        //b.Метод возвращающий «имя» элемента.
        //c.Конструктор класса с одним параметром

        //Вариант 6
        //Очередь.Первый и последний элементы должны быть закрашены как текущие.
        //На форме должны быть кнопки, выполняющие следующие действия:
        //a.Удалять элемент.
        //b.Вставлять элемент.

    }
    public class Queue
    {
        private Queue<unit> queue;

        public Queue()
        {
            queue = new Queue<unit>();
        }

        public void Enqueue(unit item) 
        {
            
            queue.Enqueue(item);
        }

        public unit Dequeue()
        {
            return queue.Dequeue();
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public int Size()
        {
            return queue.Count;
        }

        

        public unit Peek()
        {
            return queue.Peek();
        }

        public void Draw(Graphics g) //Рисование элементов списка
        {
            if (queue.Count != 0)
            {
                g.Clear(Color.White);

                g.FillEllipse(new SolidBrush(Color.LightBlue), 21, 50, 20, 20);
                g.FillEllipse(new SolidBrush(Color.LightBlue), queue.Count * 21, 50, 20, 20);
                Pen pen = new Pen(Color.Red);

                unit[] items = queue.ToArray();
                for (int i = 0; i < queue.Count; i++)
                {
                    //MessageBox.Show(i.ToString());

                    g.DrawString(items[i].getName(), new Font("Arial", 8), new
                    SolidBrush(Color.Black), (i+1) * 21 + 3, 52);
                    g.DrawEllipse(pen, (i+1)* 21, 50, 20, 20);


                }
            }
            else
            {
                g.Clear(Color.White);
            }
        }

    }
    
    public class unit
    {
        private string name;

        public unit(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
