using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    abstract class Figure //фигура
    {
        private int width;
        private int height;

        // СВОЙСТВО
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        //рисование
        public abstract void Draw(Graphics g, int x, int y, int xf, int yf);
    }
}
