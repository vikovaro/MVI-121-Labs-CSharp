using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class RightTriangle : Figure // прямоугольный треугольник
    {

        public override void Draw(Graphics g, int x, int y, int xf, int yf)
        {
            Pen pen = new Pen(Color.Black, 3);
            Point[] points = { new Point(x, y), new Point(x + xf, y), new Point(x, y - yf) };
            g.DrawPolygon(pen, points);
        }

        //Требование: добавить исключени и обработку исключений
        // в этой лабораторной нужно защитить ввод данных обработкой исключительных ситуаций 
    }
}
