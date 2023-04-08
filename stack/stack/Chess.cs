using System;
using System.Collections.Generic;
using System.Data;
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

        public Pair(T Col, U Row)
        {
            this.Col = Col;
            this.Row = Row;
        }

        public T Col { get; set; }
        public U Row { get; set; }
    };
    public class Chess
    {
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamWriter sw = new(Console.OpenStandardOutput());
        static void Main(string[] args)
        {
            string[] inputSizes = (sr.ReadLine() ?? "0 0").Split(" ");
            Pair<int, int> size = new(int.Parse(inputSizes[0]), int.Parse(inputSizes[1]));
            var board = new string[50];
            int result = int.MaxValue;
            for(int i = 0; i < size.Col; ++i)
            {
                board[i] = sr.ReadLine() ?? string.Empty;
            }

            for(int col = 0; col <= size.Col - 8; ++col)
            {
                for(int row = 0; row <= size.Row - 8; ++row)
                {
                    var min = GetSolution(col, row, board);
                    min = Math.Min(min, 64 - min);
                    result = Math.Min(min, result);
                }
            }
            sw.WriteLine(result);
            sw.Close();
            sr.Close();
        }

        private static int GetSolution(int col, int row, string[] board)
        {
            int cnt = 0;
            for(int i = col; i < col + 8; ++i)
            {
                for(int j = row; j < row + 8; ++j)
                {
                    var c = (i + j) % 2 == 0 ? 'W' : 'B';
                    if(c != board[i].ElementAt(j))
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }
}
