using System;
using System.Collections.Generic;
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
    public class Chess
    {
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamWriter sw = new(Console.OpenStandardOutput());
        static void Main(string[] args)
        {
            var whiteBoard = new char[,] 
            { 
                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
            };
            var blackBoard = new char[,]
            {
                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
                { 'B', 'W', 'B', 'W', 'B', 'W', 'B', 'W' },
                { 'W', 'B', 'W', 'B', 'W', 'B', 'W', 'B' },
            };
            string[] inputSizes = (sr.ReadLine() ?? "0 0").Split(" ");
            Pair<int, int> size = new(int.Parse(inputSizes[0]), int.Parse(inputSizes[1]));
        }
    }
}
