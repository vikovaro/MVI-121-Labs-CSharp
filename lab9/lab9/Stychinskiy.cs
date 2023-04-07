using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class Stychinskiy
    {
        private Graphics g = Form1.g;
        private static Graphics gg = Form1.gg;
        private static Stychinskiy ttt = new Stychinskiy();
        
        //передние лапки
        public void DrawPaws1() //нестатический метод
        {
            ttt = this;
            this.g = Form1.g;
            

            //верхняя лапка 1
            Point[] Lapca1 =
            {
                new Point(255, 253),
                new Point(217, 230),
                new Point(184,218),
                new Point(184,209),
                new Point(188,204),
                new Point(208,209),
                new Point(217,220),
                new Point(262,239),
                new Point(255, 253),
            };

            g.FillPolygon(new SolidBrush(Color.Gray), Lapca1);

            //верхняя лапка 2
            Point[] Lapca2 =
            {
                new Point(439,239),
                new Point(483,223),

                new Point(493,214),
                new Point(494,210),
                new Point(498,205),
                new Point(516,200),

                new Point(520, 210),
                new Point(516, 219),

                new Point(484, 232),
                new Point(443, 253),
                new Point(439,239),
            };
            g.FillPolygon(new SolidBrush(Color.Gray), Lapca2);


        }

        //задние лаки
        public static void DrawPaws2() //статический метод
        {
            gg = Form1.gg;
            //нижняя лапка 3
            gg.FillEllipse(Brushes.Gray, 300, 405, 50, 30);

            //нижняя лапка 4
            gg.FillEllipse(Brushes.Gray, 355, 405, 50, 30);
        }
    }
}
