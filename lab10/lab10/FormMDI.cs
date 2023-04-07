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
    public partial class FormMDI : Form
    {
        TextChangeForm f1 = new TextChangeForm();
        EditablePicForm f2 = new EditablePicForm();
        SecondPicForm f3 = new SecondPicForm();

        public FormMDI()
        {
            InitializeComponent();
            f1.MdiParent = this;
            f1.Size = new Size(600, 300);
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(0, 0);
            f1.Show();

            f2.MdiParent = this;
            f2.Size = new Size(600, 300);
            f2.StartPosition = FormStartPosition.Manual;
            f2.Location = new Point(0, 301);
            f2.Show();


            f3.MdiParent = this;
            f3.Size = new Size(600, 300);
            f3.StartPosition = FormStartPosition.Manual;
            f3.Location = new Point(0, 601);
            f3.Show();
        }
    }
}
