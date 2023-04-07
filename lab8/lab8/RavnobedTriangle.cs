using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    //Равнобедренный треугольник - вариант 5 (мой 19)
    //a. * (а* с) умножение высот, возвращаемое значение - число.
    //b. + (а+с) треугольник у которого площадь больше, тип возвращаемого значения
    //совпадает с типом операндов.
    //c. <,> Треугольник больше, если его высота больше, меньше, если высота меньше.
    //d. / (а/к) треугольник у которого стороны уменьшены в к раз, тип возвращаемого
    //значения совпадает с типом первого операнда.

    public class RavnobedTriangle
    {
        private double height { get; set; }
        private double side { get; set; }

        public RavnobedTriangle(double side, double height)
        {
            this.side = side;
            this.height = height;
        }
        private double S()
        {
            return (1.0/2)*height * side;
        }

        public string getInfo()
        {
            return "Высота:"+Math.Round(height,2)+"; Основание:" + Math.Round(side,2) +"; Площадь:"+S().ToString();
        }

        //a. * (а* с) умножение высот, возвращаемое значение - число.
        public static double operator *(RavnobedTriangle ob1, RavnobedTriangle ob2)
        {
            return ob1.height * ob2.height;
        }

        //b. + (а+с) треугольник у которого площадь больше, тип возвращаемого значения совпадает с типом операндов.
        public static RavnobedTriangle operator +(RavnobedTriangle ob1, RavnobedTriangle ob2)
        {
            double Ob1S = ((1.0 / 2) * ob1.side * ob1.height);
            double Ob2S = ((1.0 / 2) * ob2.side * ob2.height);

            if (Ob1S > Ob2S) {
                return ob1;
            }
            else if (Ob1S < Ob2S)
            {
                return ob2;
            }
            else
            {
                MessageBox.Show("треугольники одинаковые");
                return null;
            }
        }
        //c. <,> Треугольник больше, если его высота больше, меньше, если высота меньше.
        public static bool operator <(RavnobedTriangle ob1, RavnobedTriangle ob2)
        {
            return (ob1.height < ob2.height);
        }
        public static bool operator >(RavnobedTriangle ob1, RavnobedTriangle ob2)
        {
            return (ob1.height > ob2.height);
        }
        //d. / (а/к) треугольник у которого стороны уменьшены в к раз, тип возвращаемого
        //значения совпадает с типом первого операнда.
        public static RavnobedTriangle operator /(RavnobedTriangle ob1, double k)
        {

            double side = ob1.side / k;
            double height = ob1.height / k;

            RavnobedTriangle newOb = new RavnobedTriangle(side, height);

            return newOb;

        }
        
    }
}
