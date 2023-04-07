using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class EditablePicForm : Form
    {
        Figure fig = new Figure();
        public static Pen pen;
        public static Bitmap bmp;
        public static Graphics g;

        public EditablePicForm()
        {
            InitializeComponent();
            ToolTip t = new ToolTip(); //позволяет отображать всплывающую подсказку при наведении курсора
            t.SetToolTip(pictureBox1, "Нажмите ПКМ для взаимодействия"); //подсказка

            pictureBox1.ContextMenuStrip = contextMenuStrip1; //определяем границы для контексного меню
            toolStripStatusLabel1.Text = "Путь к файлу"; //нижняя строка имени файла
        }


        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; //Масштабирует изображение, чтобы оно соответствовало размеру PictureBox и при этом сохранял свои пропорции. 

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); 
            toolStripStatusLabel1.Text = openFileDialog1.FileName; //в статус записывается имя файла
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Невозможно сохранить пустое изображение");
                return;
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                
                //при сохранении файла бывали ошибки, поэтому обернуто в try catch
                try
                {
                    bmp.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("Файл сохранен");
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка сохранения");
                }

                
            }
        }
        private void DrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image != null)
            {
                fig.ShowDialog();
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                Pen pen = new Pen(Color.Red, 5);
                g.DrawRectangle(pen, Figure.x, Figure.y, 50, 50); //рисует прямоугольник размерами 50х50 по заданным координатам в форме 
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("Изображение отсутстввует");
            }
            
        }




        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = null; 
            toolStripStatusLabel1.Text = "Путь к файлу";
            
            MessageBox.Show("Изображение удалено");
        }

        

        
    }
}
