using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public class TrList
    {
        public static List<RavnobedTriangle> PiList = new List<RavnobedTriangle>();
        public static int p = -1;

        public static void Add(RavnobedTriangle v)
        {
            PiList.Insert(++p, v);
        }

        public static void Clear()
        {
            PiList.Clear();
            p = -1;

        }
        public static int Count
        {
            get { return PiList.Count; }
        }
    }
}
