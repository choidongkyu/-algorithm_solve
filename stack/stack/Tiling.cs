using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm
{
    public class Pair<T, U>
    {
        public Pair()
        {
        }

        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        public T First { get; set; }
        public U Second { get; set; }
    };
    public class Tiling
    {
        static void Main(string[] args)
        {
            Pair<int, int> firstTile = new Pair<int, int>(1, 2);
            Pair<int, int> secondTile = new Pair<int, int>(2, 1);
        }
    }
}
