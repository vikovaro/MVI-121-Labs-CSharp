using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab10
{
    public partial class TextChangeForm : Form
    {
        public TextChangeForm()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            toolStripStatusLabel1.Text = "Путь к файлу";
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string fileText = File.ReadAllText(openFileDialog1.FileName);
            richTextBox1.Text = fileText;
            toolStripStatusLabel1.Text = openFileDialog1.FileName;
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("Файл сохранен");
            toolStripStatusLabel1.Text = saveFileDialog1.FileName;
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            toolStripStatusLabel1.Text = "Путь к файлу";
            MessageBox.Show("Поле очищено");
        }
    }
}
